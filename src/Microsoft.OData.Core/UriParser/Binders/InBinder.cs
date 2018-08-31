﻿//---------------------------------------------------------------------
// <copyright file="InBinder.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace Microsoft.OData.UriParser
{
    using System;
    using System.Diagnostics;
    using System.Text;
    using Microsoft.OData.Edm;
    using ODataErrorStrings = Microsoft.OData.Strings;

    /// <summary>
    /// Class that knows how to bind the In operator.
    /// </summary>
    internal sealed class InBinder
    {
        /// <summary>
        /// Method to use for binding the parent node, if needed.
        /// </summary>
        private readonly Func<QueryToken, QueryNode> bindMethod;

        /// <summary>
        /// Constructs a InBinder with the given method to be used binding the parent token if needed.
        /// </summary>
        /// <param name="bindMethod">Method to use for binding the parent token, if needed.</param>
        internal InBinder(Func<QueryToken, QueryNode> bindMethod)
        {
            this.bindMethod = bindMethod;
        }

        /// <summary>
        /// Binds an In operator token.
        /// </summary>
        /// <param name="inToken">The In operator token to bind.</param>
        /// <param name="state">State of the metadata binding.</param>
        /// <returns>The bound In operator token.</returns>
        internal QueryNode BindInOperator(InToken inToken, BindingState state)
        {
            ExceptionUtils.CheckArgumentNotNull(inToken, "inToken");

            SingleValueNode left = this.GetSingleValueOperandFromToken(inToken.Left);
            CollectionNode right = this.GetCollectionOperandFromToken(
                inToken.Right, new EdmCollectionTypeReference(new EdmCollectionType(left.TypeReference)), state.Model);

            return new InNode(left, right);
        }

        /// <summary>
        /// Retrieve SingleValueNode bound with given query token.
        /// </summary>
        /// <param name="queryToken">The query token</param>
        /// <returns>The corresponding SingleValueNode</returns>
        private SingleValueNode GetSingleValueOperandFromToken(QueryToken queryToken)
        {
            SingleValueNode operand = this.bindMethod(queryToken) as SingleValueNode;
            if (operand == null)
            {
                throw new ODataException(ODataErrorStrings.MetadataBinder_LeftOperandNotSingleValue);
            }

            return operand;
        }

        /// <summary>
        /// Retrieve CollectionNode bound with given query token.
        /// </summary>
        /// <param name="queryToken">The query token</param>
        /// <param name="expectedType">The expected type that this collection holds</param>
        /// <param name="model">The Edm model</param>
        /// <returns>The corresponding CollectionNode</returns>
        private CollectionNode GetCollectionOperandFromToken(QueryToken queryToken, IEdmTypeReference expectedType, IEdmModel model)
        {
            CollectionNode operand = null;
            LiteralToken literalToken = queryToken as LiteralToken;
            if (literalToken != null)
            {
                string jsonReadableLiteralText = MakeJSONReadable(literalToken.OriginalText);
              
                object collection = ODataUriConversionUtils.ConvertFromCollectionValue(jsonReadableLiteralText, model, expectedType);
                LiteralToken collectionLiteralToken = new LiteralToken(collection, jsonReadableLiteralText, expectedType);
                operand = this.bindMethod(collectionLiteralToken) as CollectionConstantNode;
            }
            else
            {
                operand = this.bindMethod(queryToken) as CollectionNode;
            }

            if (operand == null)
            {
                throw new ODataException(ODataErrorStrings.MetadataBinder_RightOperandNotCollectionValue);
            }

            return operand;
        }

        /// <summary>
        /// We use JSON deserializer to deserialize collection type.
        /// This method manipulates a collection value string to be JSON readable by changing individual members as strings.. 
        /// </summary>
        /// <param name="originalLiteralText"></param>
        /// <returns></returns>
        public static string MakeJSONReadable(string originalLiteralText)
        {
            StringBuilder bracketLiteralText = new StringBuilder(originalLiteralText);
            if (bracketLiteralText[0] == '(')
            {
                Debug.Assert(bracketLiteralText[bracketLiteralText.Length - 1] == ')',
                    "Collection with opening '(' should have corresponding ')'");
                bracketLiteralText[0] = '[';
                bracketLiteralText[bracketLiteralText.Length - 1] = ']';
            }

            if(bracketLiteralText[0]=='[')
            {
                int i = 1;
                while(i<bracketLiteralText.Length)
                {
                    if(bracketLiteralText[i]=='\'')
                    {
                        
                        while(i < bracketLiteralText.Length - 1 && bracketLiteralText[++i]!='\'')
                        {
                            //Forward the index till the single quotes do not get closed.
                        }
                    }
                    else if(i==1)
                    {
                        bracketLiteralText.Insert(i, '\'');
                        i++;
                        continue;
                    }
                    else if(bracketLiteralText[i]==',')
                    {
                        
                        if(bracketLiteralText[i-1]!='\'')
                        {
                            bracketLiteralText.Insert(i, '\'');
                            i++;
                        }

                        bracketLiteralText.Insert(i + 1, '\'');
                        i++;
                    }
                    else if(bracketLiteralText[i]==']')
                    {
                        if (bracketLiteralText[i - 1] != '\'')
                        {
                            bracketLiteralText.Insert(i, '\'');
                            i++;
                        }
                    }

                    i++;
                    
                }
            }
            return bracketLiteralText.ToString();
        }
    }
}
