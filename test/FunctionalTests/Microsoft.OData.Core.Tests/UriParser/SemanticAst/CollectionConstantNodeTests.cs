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
            const string text = "(27811919BD-323C-44B0-A7FD-0081B730F829','8e3547a2-2f01-41d9-9948-66b9251dbeef')";
            var expectedType = new EdmCollectionTypeReference(new EdmCollectionType(EdmCoreModel.Instance.GetGuid(false)));
            object collection = ODataUriConversionUtils.ConvertFromCollectionValue("[27811919BD-323C-44B0-A7FD-0081B730F829,8e3547a2-2f01-41d9-9948-66b9251dbeef]", HardCodedTestModel.TestModel, expectedType);
            LiteralToken literalToken = new LiteralToken(collection, text, expectedType);

            CollectionConstantNode collectionConstantNode = new CollectionConstantNode(
                (literalToken.Value as ODataCollectionValue)?.Items, text, expectedType);

            var expectedList = new ConstantNode[] {
                new ConstantNode(new Guid("27811919BD-323C-44B0-A7FD-0081B730F829"), "27811919BD-323C-44B0-A7FD-0081B730F829", EdmCoreModel.Instance.GetGuid(false)),
               new ConstantNode(new Guid("8e3547a2-2f01-41d9-9948-66b9251dbeef"), "8e3547a2-2f01-41d9-9948-66b9251dbeef", EdmCoreModel.Instance.GetGuid(false)),
            };

            collectionConstantNode.Collection.ShouldBeEquivalentTo(expectedList);
        }

        [Fact]
        public void DateTimeColletionThroughLiteralTokenIsSetCorrectly()
        {
            const string text = "[2012-04-23T18:25:43.511Z,2012-04-23T18:25:43.511Z]";
            var expectedType = new EdmCollectionTypeReference(new EdmCollectionType(EdmCoreModel.Instance.GetDateTimeOffset(false)));
            object collection = ODataUriConversionUtils.ConvertFromCollectionValue("[2012-04-23T18:25:43.511Z,2012-04-23T18:25:43.511Z]", HardCodedTestModel.TestModel, expectedType);
            LiteralToken literalToken = new LiteralToken(collection, text, expectedType);

          //  CollectionConstantNode collectionConstantNode = new CollectionConstantNode(
            //    (literalToken.Value as ODataCollectionValue)?.Items, text, expectedType);

            var expectedList = new ConstantNode[] {
                new ConstantNode(new Guid("27811919BD-323C-44B0-A7FD-0081B730F829"), "27811919BD-323C-44B0-A7FD-0081B730F829", EdmCoreModel.Instance.GetGuid(false)),
               new ConstantNode(new Guid("8e3547a2-2f01-41d9-9948-66b9251dbeef"), "8e3547a2-2f01-41d9-9948-66b9251dbeef", EdmCoreModel.Instance.GetGuid(false)),
            };

            //collectionConstantNode.Collection.ShouldBeEquivalentTo(expectedList);
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
    }
}
