﻿//---------------------------------------------------------------------
// <copyright file="ODataJsonLightErrorDeserializerTests.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

using System.IO;
using System.Linq;
using Microsoft.OData.JsonLight;
using Microsoft.OData.Edm;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;

namespace Microsoft.OData.Tests.JsonLight
{
    public class ODataJsonLightErrorDeserializerTests
    {
        [Fact]
        public void ReadTopLevelError_Works()
        {
            // Arrange
            const string payload =
                @"{""error"":{""code"":"""",""message"":"""",""target"":""any target"","
                + @"""details"":[{""code"":""500"",""target"":""another target"",""message"":""any msg""}]}}";
            var context = GetInputContext(payload);
            var deserializer = new ODataJsonLightErrorDeserializer(context);

            // Act
            var error = deserializer.ReadTopLevelError();
            
            // Assert
            Assert.Equal("any target", error.Target);
            Assert.Equal(1, error.Details.Count);
            var detail = error.Details.Single();
            Assert.Equal("500", detail.ErrorCode);
            Assert.Equal("another target", detail.Target);
            Assert.Equal("any msg", detail.Message);
        }

        [Fact]
        public void ReadTopLevelErrorAsync_Works()
        {
            // Arrange
            const string payload =
                @"{""error"":{""code"":"""",""message"":"""",""target"":""any target"","
                + @"""details"":[{""code"":""500"",""target"":""another target"",""message"":""any msg""}]}}";
            var context = GetInputContext(payload);
            var deserializer = new ODataJsonLightErrorDeserializer(context);

            // Act
            var error = deserializer.ReadTopLevelErrorAsync().Result;

            // Assert
            Assert.Equal("any target", error.Target);
            Assert.Equal(1, error.Details.Count);
            var detail = error.Details.Single();
            Assert.Equal("500", detail.ErrorCode);
            Assert.Equal("another target", detail.Target);
            Assert.Equal("any msg", detail.Message);
        }

        [Fact]
        public void ReadTopLevelErrorWithResourceValueInstanceAnnotation_Works()
        {
            // Arrange
            const string payload =
                @"{""error"":{""code"":"""",""message"":"""","
                + @"""@sample.error"":{""@odata.type"":""#NS.Entity"",""Sample"":""sample value""}}}";
            var context = GetInputContext(payload, GetEdmModel());
            var deserializer = new ODataJsonLightErrorDeserializer(context);

            // Act
            var error = deserializer.ReadTopLevelError();

            // Assert
            Assert.NotNull(error.InstanceAnnotations);
            var annotation = Assert.Single(error.InstanceAnnotations);
            Assert.Equal("sample.error", annotation.Name);
            Assert.NotNull(annotation.Value);
            var value = Assert.IsType<ODataResourceValue>(annotation.Value);
            Assert.Equal("NS.Entity", value.TypeName);
            Assert.NotNull(value.Properties);
            var property = Assert.Single(value.Properties);
            Assert.Equal("Sample", property.Name);
            Assert.Equal("sample value", property.Value);
        }

        [Fact]
        public void ReadTopLevelErrorWithCollectionResourceValueInstanceAnnotation_Works()
        {
            // Arrange
            const string payload =
                @"{""error"":{""code"":"""",""message"":"""","
                + @"""sample.error@odata.type"":""Collection(NS.Entity)"",""@sample.error"":[{""@odata.type"":""#NS.Entity"",""Sample"":""sample value""}]}}";
            var context = GetInputContext(payload, GetEdmModel());
            var deserializer = new ODataJsonLightErrorDeserializer(context);

            // Act
            var error = deserializer.ReadTopLevelError();

            // Assert
            Assert.NotNull(error.InstanceAnnotations);
            var annotation = Assert.Single(error.InstanceAnnotations);
            Assert.Equal("sample.error", annotation.Name);
            Assert.NotNull(annotation.Value);
            var collection = Assert.IsType<ODataCollectionValue>(annotation.Value);
            Assert.Equal("Collection(NS.Entity)", collection.TypeName);
            Assert.NotNull(collection.Items);
            var item = Assert.Single(collection.Items);
            var value = Assert.IsType<ODataResourceValue>(item);
            Assert.Equal("NS.Entity", value.TypeName);
            Assert.NotNull(value.Properties);
            var property = Assert.Single(value.Properties);
            Assert.Equal("Sample", property.Name);
            Assert.Equal("sample value", property.Value);
        }

        [Fact]
        public void ReadExtendedInnerError()
        {
            // Arrange
            const string payload =
                    "{\"error\":{" +
                        "\"code\":\"\",\"message\":\"\"," +
                        "\"target\":\"any target\"," +
                        "\"details\":[{\"code\":\"500\",\"target\":\"any target\",\"message\":\"any msg\"}]," +
                        "\"innererror\":{" +
                            "\"stacktrace\":\"NormalString\"," +
                            "\"message\":\"\"," +
                            "\"type\":\"\"," +
                            "\"innererror\":{" +
                                    "\"stacktrace\":\"InnerError\"," +
                                    "\"MyNewObject\":{" +
                                        "\"StringProperty\":\"newProperty\"," +
                                        "\"IntProperty\": 1," +
                                        "\"BooleanProperty\": true," +
                                        "\"type\":\"\"," +
                                        "\"NestedNull\":null" + 
                                     "}" +
                                 "}" +
                            "}" +
                       "}}";
                    
            var context = GetInputContext(payload, GetEdmModel());
            var deserializer = new ODataJsonLightErrorDeserializer(context);

            // Act
            var error = deserializer.ReadTopLevelError();

            // Assert Top Level properties
            Assert.Equal("any target", error.Target);
            Assert.Equal(1, error.Details.Count);
            var detail = error.Details.Single();
            Assert.Equal("500", detail.ErrorCode);
            Assert.Equal("any target", detail.Target);
            Assert.Equal("any msg", detail.Message);

            //Assert Inner Error properties
            Assert.NotNull(error.InnerError);
            Assert.True(error.InnerError.Properties.ContainsKey("innererror"));
            Assert.NotNull(error.InnerError.Properties["innererror"].As<ODataResourceValue>().Properties.FirstOrDefault(p =>p.Name == "MyNewObject").ODataValue.As<ODataResourceValue>());
            ODataResourceValue nestedInnerObject = error.InnerError.Properties["innererror"] as ODataResourceValue;
            ODataResourceValue nestedMyNewObject    = nestedInnerObject.Properties.FirstOrDefault(p => p.Name == "MyNewObject").ODataValue as ODataResourceValue;

            Assert.Equal(nestedMyNewObject.Properties.Count(), 5);
            Assert.Equal(nestedMyNewObject.Properties.ElementAt(0).Name, "StringProperty");
            Assert.Equal(nestedMyNewObject.Properties.ElementAt(0).Value, "newProperty");

            Assert.Equal(nestedMyNewObject.Properties.ElementAt(1).Name, "IntProperty");
            Assert.Equal(nestedMyNewObject.Properties.ElementAt(1).Value, 1);

            Assert.Equal(nestedMyNewObject.Properties.ElementAt(2).Name, "BooleanProperty");
            Assert.Equal(nestedMyNewObject.Properties.ElementAt(2).Value, true);

            Assert.Equal(nestedMyNewObject.Properties.ElementAt(3).Name, "type");
            Assert.Equal(nestedMyNewObject.Properties.ElementAt(3).Value, "");

            Assert.Equal(nestedMyNewObject.Properties.ElementAt(4).Name, "NestedNull");
            Assert.Equal(nestedMyNewObject.Properties.ElementAt(4).Value, null);
        }

        [Fact]
        public void ReadErrorWithCollectionInInnerError()
        {
            // Arrange
            const string payload = "{\"error\":{\"code\":\"\",\"message\":\"\",\"target\":\"any target\",\"details\":[{\"code\":\"500\",\"target\":\"any target\",\"message\":\"any msg\"}],\"innererror\":{\"message\":\"\",\"type\":\"\",\"stacktrace\":\"\",\"ResourceValue\":{\"PropertyName\":\"PropertyValue\",\"NullProperty\":null},\"NullProperty\":null,\"CollectionValue\":[null,\"CollectionValue\",1]}}}";

            var context = GetInputContext(payload, GetEdmModel());
            var deserializer = new ODataJsonLightErrorDeserializer(context);

            // Act
            var error = deserializer.ReadTopLevelError();

            //Assert Inner Error properties
            Assert.NotNull(error.InnerError);
            Assert.True(error.InnerError.Properties.ContainsKey("CollectionValue"));
            Assert.Equal(3, error.InnerError.Properties["CollectionValue"].As<ODataCollectionValue>().Items.Count());
        }

        private ODataJsonLightInputContext GetInputContext(string payload, IEdmModel model = null)
        {
            var messageInfo = new ODataMessageInfo
            {
                IsResponse = true,
                MediaType = JsonLightUtils.JsonLightStreamingMediaType,
                IsAsync = false,
                Model = model ?? new EdmModel(),
            };

            return new ODataJsonLightInputContext(
                new StringReader(payload),
                messageInfo,
                new ODataMessageReaderSettings());
        }

        private static IEdmModel GetEdmModel()
        {
            EdmModel model = new EdmModel();
            var complexType = new EdmComplexType("NS", "Entity");
            var property = new EdmStructuralProperty(complexType, "Sample", EdmCoreModel.Instance.GetString(false));
            complexType.AddProperty(property);
            model.AddElement(complexType);
            return model;
        }
    }
}
