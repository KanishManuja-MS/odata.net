//---------------------------------------------------------------------
// <copyright file="CollectionConstantNodeTests.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.OData.UriParser;
using Microsoft.OData.Edm;
using Xunit;

namespace Microsoft.OData.Tests.UriParser.SemanticAst
{
    /// <summary>
    /// Unit tests for the CollectionConstantNode class
    /// </summary>
    public class CollectionConstantNodeTests
    {
        [Fact]
        public void NumberCollectionThroughLiteralTokenIsSetCorrectly()
        {
            const string text = "(1,2,3)";
            var expectedType = new EdmCollectionTypeReference(new EdmCollectionType(EdmCoreModel.Instance.GetInt32(false)));
            object collection = ODataUriConversionUtils.ConvertFromCollectionValue("[1,2,3]", HardCodedTestModel.TestModel, expectedType);
            LiteralToken literalToken = new LiteralToken(collection, text, expectedType);

            CollectionConstantNode collectionConstantNode = new CollectionConstantNode(
                (literalToken.Value as ODataCollectionValue)?.Items, text, expectedType);

            var expectedList = new ConstantNode[] {
                new ConstantNode(1, "1", EdmCoreModel.Instance.GetInt32(false)),
                new ConstantNode(2, "2", EdmCoreModel.Instance.GetInt32(false)),
                new ConstantNode(3, "3", EdmCoreModel.Instance.GetInt32(false)),
            };

            collectionConstantNode.Collection.ShouldBeEquivalentTo(expectedList);
        }



        [Fact]
        public void GuidColletionThroughLiteralTokenIsSetCorrectly()
        {
            const string text = "(a2ed4096-9d03-4415-adcb-3791788b1d47,8e3547a2-2f01-41d9-9948-66b9251dbeef)";
            var expectedType = new EdmCollectionTypeReference(new EdmCollectionType(EdmCoreModel.Instance.GetGuid(false)));
            object collection = ODataUriConversionUtils.ConvertFromCollectionValue("[a2ed4096-9d03-4415-adcb-3791788b1d47, 8e3547a2-2f01-41d9-9948-66b9251dbeef]", HardCodedTestModel.TestModel, expectedType);
            LiteralToken literalToken = new LiteralToken(collection, text, expectedType);

            CollectionConstantNode collectionConstantNode = new CollectionConstantNode(
                (literalToken.Value as ODataCollectionValue)?.Items, text, expectedType);

            var expectedList = new ConstantNode[] {
                new ConstantNode(new Guid("a2ed4096-9d03-4415-adcb-3791788b1d47"),"a2ed4096-9d03-4415-adcb-3791788b1d47", EdmCoreModel.Instance.GetGuid(false)),
               new ConstantNode(new Guid("8e3547a2-2f01-41d9-9948-66b9251dbeef"), "8e3547a2-2f01-41d9-9948-66b9251dbeef", EdmCoreModel.Instance.GetGuid(false)),
            };

            collectionConstantNode.Collection.ShouldBeEquivalentTo(expectedList);
        }

        [Fact]
        public void DateTimeColletionThroughLiteralTokenIsSetCorrectly()
        {
            const string text = "[2012-04-23 -7h,2014-04-23 -7h]";
            var expectedType = new EdmCollectionTypeReference(new EdmCollectionType(EdmCoreModel.Instance.GetDateTimeOffset(false)));
            object collection = ODataUriConversionUtils.ConvertFromCollectionValue("[2012-04-23 -7h,2014-04-23 -7h]", HardCodedTestModel.TestModel, expectedType);
            LiteralToken literalToken = new LiteralToken(collection, text, expectedType);

            CollectionConstantNode collectionConstantNode = new CollectionConstantNode(
                 (literalToken.Value as ODataCollectionValue)?.Items, text, expectedType);

            var expectedList = new ConstantNode[] {
                new ConstantNode(new DateTime(2012,4,23), "2012-04-23", EdmCoreModel.Instance.GetDateTimeOffset(false)),
                    new ConstantNode(new DateTime(2014,4,23), "2014-04-23", EdmCoreModel.Instance.GetDateTimeOffset(false)),
            };

            collectionConstantNode.Collection.ShouldBeEquivalentTo(expectedList);
        }
        [Fact]
        public void StringCollectionThroughLiteralTokenIsSetCorrectly()
        {
            const string text = "('abc','def','ghi')";
            var expectedType = new EdmCollectionTypeReference(new EdmCollectionType(EdmCoreModel.Instance.GetString(true)));
            object collection = ODataUriConversionUtils.ConvertFromCollectionValue("['abc','def','ghi']", HardCodedTestModel.TestModel, expectedType);
            LiteralToken literalToken = new LiteralToken(collection, text, expectedType);

            CollectionConstantNode collectionConstantNode = new CollectionConstantNode(
                (literalToken.Value as ODataCollectionValue)?.Items, text, expectedType);

            var expectedList = new ConstantNode[] {
                new ConstantNode("abc", "abc", EdmCoreModel.Instance.GetString(true)),
                new ConstantNode("def", "def", EdmCoreModel.Instance.GetString(true)),
                new ConstantNode("ghi", "ghi", EdmCoreModel.Instance.GetString(true)),
            };

            collectionConstantNode.Collection.ShouldBeEquivalentTo(expectedList);
        }

        [Fact]
        public void TextIsSetCorrectly()
        {
            const string text = "(1,2,3)";
            var expectedType = new EdmCollectionTypeReference(new EdmCollectionType(EdmCoreModel.Instance.GetInt32(false)));
            object collection = ODataUriConversionUtils.ConvertFromCollectionValue("[1,2,3]", HardCodedTestModel.TestModel, expectedType);
            LiteralToken literalToken = new LiteralToken(collection, text, expectedType);

            CollectionConstantNode collectionConstantNode = new CollectionConstantNode(
                (literalToken.Value as ODataCollectionValue)?.Items, text, expectedType);

            collectionConstantNode.LiteralText.Should().Be(text);
        }

        [Fact]
        public void ItemTypeIsSetCorrectly()
        {
            const string text = "(1,2,3)";
            var expectedType = new EdmCollectionTypeReference(new EdmCollectionType(EdmCoreModel.Instance.GetInt32(false)));
            object collection = ODataUriConversionUtils.ConvertFromCollectionValue("[1,2,3]", HardCodedTestModel.TestModel, expectedType);
            LiteralToken literalToken = new LiteralToken(collection, text, expectedType);

            CollectionConstantNode collectionConstantNode = new CollectionConstantNode(
                (literalToken.Value as ODataCollectionValue)?.Items, text, expectedType);

            collectionConstantNode.ItemType.FullName().Should().Be("Edm.Int32");
        }

        [Fact]
        public void CollectionTypeIsSetCorrectly()
        {
            const string text = "(1,2,3)";
            var expectedType = new EdmCollectionTypeReference(new EdmCollectionType(EdmCoreModel.Instance.GetInt32(false)));
            object collection = ODataUriConversionUtils.ConvertFromCollectionValue("[1,2,3]", HardCodedTestModel.TestModel, expectedType);
            LiteralToken literalToken = new LiteralToken(collection, text, expectedType);

            CollectionConstantNode collectionConstantNode = new CollectionConstantNode(
                (literalToken.Value as ODataCollectionValue)?.Items, text, expectedType);

            collectionConstantNode.CollectionType.FullName().Should().Be("Collection(Edm.Int32)");
        }

        [Fact]
        public void KindIsSetCorrectly()
        {
            const string text = "(1,2,3)";
            var expectedType = new EdmCollectionTypeReference(new EdmCollectionType(EdmCoreModel.Instance.GetInt32(false)));
            object collection = ODataUriConversionUtils.ConvertFromCollectionValue("[1,2,3]", HardCodedTestModel.TestModel, expectedType);
            LiteralToken literalToken = new LiteralToken(collection, text, expectedType);

            CollectionConstantNode collectionConstantNode = new CollectionConstantNode(
                (literalToken.Value as ODataCollectionValue)?.Items, text, expectedType);

            collectionConstantNode.InternalKind.Should().Be(InternalQueryNodeKind.CollectionConstant);
        }

        [Fact]
        public void NullValueShouldThrow()
        {
            const string text = "(1,2,3)";
            var expectedType = new EdmCollectionTypeReference(new EdmCollectionType(EdmCoreModel.Instance.GetInt32(false)));
            object collection = ODataUriConversionUtils.ConvertFromCollectionValue("[1,2,3]", HardCodedTestModel.TestModel, expectedType);
            LiteralToken literalToken = new LiteralToken(collection, text, expectedType);

            Action target = () => new CollectionConstantNode(null, text, expectedType);
            target.ShouldThrow<ArgumentNullException>().Where(e => e.Message.Contains("objectCollection"));
        }

        [Fact]
        public void NullLiteralTextShouldThrow()
        {
            const string text = "(1,2,3)";
            var expectedType = new EdmCollectionTypeReference(new EdmCollectionType(EdmCoreModel.Instance.GetInt32(false)));
            object collection = ODataUriConversionUtils.ConvertFromCollectionValue("[1,2,3]", HardCodedTestModel.TestModel, expectedType);
            LiteralToken literalToken = new LiteralToken(collection, text, expectedType);

            Action target = () => new CollectionConstantNode((literalToken.Value as ODataCollectionValue)?.Items, null, expectedType);
            target.ShouldThrow<ArgumentNullException>().Where(e => e.Message.Contains("literalText"));
        }

        [Fact]
        public void NullCollectionTypeShouldThrow()
        {
            const string text = "(1,2,3)";
            var expectedType = new EdmCollectionTypeReference(new EdmCollectionType(EdmCoreModel.Instance.GetInt32(false)));
            object collection = ODataUriConversionUtils.ConvertFromCollectionValue("[1,2,3]", HardCodedTestModel.TestModel, expectedType);
            LiteralToken literalToken = new LiteralToken(collection, text, expectedType);

            Action target = () => new CollectionConstantNode((literalToken.Value as ODataCollectionValue)?.Items, text, null);
            target.ShouldThrow<ArgumentNullException>().Where(e => e.Message.Contains("collectionType"));
        }


        #region MakeJSONreaderCompatible tests
        [Fact]
        public void MakeJSONreaderCompatibleSimpleInteger()
        {
            const string text = "(1,2,3)";
            string expectedOutput = "['1','2','3']";
            string actualOutput = ODataUriConversionUtils.MakeJSONReadable(text);
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void MakeJSONreaderCompatibleSomeStrings()
        {
            const string text = "('abc',ced,edf)";
            string expectedOutput = "['abc','ced','edf']";
            string actualOutput = ODataUriConversionUtils.MakeJSONReadable(text);
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void MakeJSONreaderCompatibleNULLCollection()
        {
            const string text = "()";
            string expectedOutput = "[]";
            string actualOutput = ODataUriConversionUtils.MakeJSONReadable(text);
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void MakeJSONreaderCompatibleWithDelimeterloadedStrings()
        {
            const string text = "('stringwith,comma', 'string with brace ]')";
            string expectedOutput = "['stringwith,comma', 'string with brace ]']";
            string actualOutput = ODataUriConversionUtils.MakeJSONReadable(text);
            Assert.Equal(expectedOutput, actualOutput);
        }
        #endregion
    }
}
