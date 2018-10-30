﻿//---------------------------------------------------------------------
// <copyright file="ValidationVocabularyTests.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using Microsoft.OData.Edm.Csdl;
using Microsoft.OData.Edm.Validation;
using Microsoft.OData.Edm.Vocabularies.V1;
using Xunit;

namespace Microsoft.OData.Edm.Tests.Vocabularies
{
    /// <summary>
    /// Test validation vocabulary
    /// </summary>
    public class ValidationVocabularyTests
    {
        private readonly IEdmModel _validationModel = ValidationVocabularyModel.Instance;

        [Fact]
        public void TestValidationVocabularyModel()
        {
            const string expectedText = @"<?xml version=""1.0"" encoding=""utf-16""?>
<Schema Namespace=""Org.OData.Validation.V1"" Alias=""Validation"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
  <ComplexType Name=""AllowedValue"">
    <Property Name=""Value"" Type=""Edm.PrimitiveType"">
      <Annotation Term=""Core.Description"" String=""An allowed value for the property, parameter, or type definition"" />
    </Property>
  </ComplexType>
  <ComplexType Name=""ConstraintType"">
    <Property Name=""FailureMessage"" Type=""Edm.String"">
      <Annotation Term=""Core.IsLanguageDependent"" Bool=""true"" />
      <Annotation Term=""Core.Description"" String=""Human-readable message that can be shown to end users if the constraint is not fulfilled"" />
    </Property>
    <Property Name=""Condition"" Type=""Edm.Boolean"" Nullable=""false"">
      <Annotation Term=""Core.Description"" String=""Value MUST be a dynamic expression that evaluates to true if and only if the constraint is fulfilled"" />
    </Property>
  </ComplexType>
  <ComplexType Name=""ItemsOfType"">
    <Property Name=""path"" Type=""Edm.NavigationPropertyPath"" Nullable=""false"">
      <Annotation Term=""Core.Description"" String=""A path to a single- or collection-valued navigation property"" />
    </Property>
    <Property Name=""target"" Type=""Edm.NavigationPropertyPath"" Nullable=""false"">
      <Annotation Term=""Core.Description"" String=""A path to a collection-valued navigation property"" />
    </Property>
    <Annotation Term=""Core.Description"" String=""Entities related via the single- or collection-valued navigation property identified by `path` are also related via the collection-valued navigation property identified by `target`."" />
  </ComplexType>
  <Term Name=""Pattern"" Type=""Edm.String"" AppliesTo=""Property Parameter Term"">
    <Annotation Term=""Core.Description"" String=""The pattern that a string property, parameter, or term must match. This SHOULD be a valid regular expression, according to the ECMA 262 regular expression dialect."" />
    <Annotation Term=""Core.RequiresType"" String=""Edm.String"" />
  </Term>
  <Term Name=""Minimum"" Type=""Edm.Decimal"" AppliesTo=""Property Parameter Term"" Scale=""Variable"">
    <Annotation Term=""Core.Description"" String=""Minimum value that a property, parameter, or term can have."" />
  </Term>
  <Term Name=""Maximum"" Type=""Edm.Decimal"" AppliesTo=""Property Parameter Term"" Scale=""Variable"">
    <Annotation Term=""Core.Description"" String=""Maximum value that a property, parameter, or term can have."" />
  </Term>
  <Term Name=""Exclusive"" Type=""Core.Tag"" DefaultValue=""true"" AppliesTo=""Annotation"">
    <Annotation Term=""Core.Description"" String=""Tags a Minimum or Maximum as exclusive, i.e. an open interval boundary."" />
  </Term>
  <Term Name=""AllowedValues"" Type=""Collection(Validation.AllowedValue)"" AppliesTo=""Property Parameter TypeDefinition"" Nullable=""false"">
    <Annotation Term=""Core.Description"" String=""A collection of valid values for the annotated property, parameter, or type definition"" />
  </Term>
  <Term Name=""MultipleOf"" Type=""Edm.Decimal"" AppliesTo=""Property Parameter Term"" Scale=""Variable"">
    <Annotation Term=""Core.Description"" String=""The value of the annotated property, parameter, or term must be an integer multiple of this positive value. For temporal types, the value is measured in seconds."" />
  </Term>
  <Term Name=""Constraint"" Type=""Validation.ConstraintType"" AppliesTo=""Property EntityType ComplexType"">
    <Annotation Term=""Core.Description"" String=""Condition that the annotation target has to fulfill"" />
  </Term>
  <Term Name=""ItemsOf"" Type=""Collection(Validation.ItemsOfType)"" AppliesTo=""EntityType ComplexType"" Nullable=""false"">
    <Annotation Term=""Core.Description"" String=""A list of constraints describing that entities related via one navigation property MUST also be related via another, collection-valued navigation property. The same `path` value MUST NOT occur more than once."" />
    <Annotation Term=""Core.LongDescription"" String=""Example: entity type `Customer` has navigation properties `AllOrders`, `OpenOrders`, and `ClosedOrders`. &#xA;The term allows to express that items of `OpenOrders` and `ClosedOrders` are also items of the `AllOrders` navigation property,&#xA;even though they are defined in an `Orders` entity set."" />
  </Term>
  <Term Name=""OpenPropertyTypeConstraint"" Type=""Collection(Core.QualifiedTypeName)"" AppliesTo=""ComplexType EntityType"" Nullable=""false"">
    <Annotation Term=""Core.Description"" String=""Dynamic properties added to the annotated open structured type are restricted to the listed types"" />
  </Term>
  <Term Name=""DerivedTypeConstraint"" Type=""Collection(Core.QualifiedTypeName)"" AppliesTo=""EntitySet Singleton NavigationProperty Property TypeDefinition Action Function Parameter"" Nullable=""false"">
    <Annotation Term=""Core.Description"" String=""Values are restricted to types that are both identical to or derived from the declared type and a type listed in this collection."" />
    <Annotation Term=""Core.LongDescription"" String=""This allows restricting values to certain sub-trees of an inheritance hierarchy. Types listed in this collection that are not derived from the declared type of the annotated model element are ignored."" />
  </Term>
</Schema>";

            StringWriter sw = new StringWriter();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = System.Text.Encoding.UTF8;

            IEnumerable<EdmError> errors;
            XmlWriter xw = XmlWriter.Create(sw, settings);
            this._validationModel.TryWriteSchema(xw, out errors);
            xw.Flush();
#if NETCOREAPP1_0
            xw.Dispose();
#else
            xw.Close();
#endif
            string output = sw.ToString();

            Assert.True(!errors.Any(), "No Errors");
            Assert.Equal(expectedText, output);
        }

        [Fact]
        public void TestValidationVocabularyOpenPropertyTypeConstraintTerm()
        {
            var term = this._validationModel.FindDeclaredTerm("Org.OData.Validation.V1.OpenPropertyTypeConstraint");
            Assert.NotNull(term);

            Assert.NotNull(term.Type);
            Assert.Equal(EdmTypeKind.Collection, term.Type.Definition.TypeKind);
            Assert.Equal("Collection(Core.QualifiedTypeName)", term.Type.Definition.FullTypeName());

            Assert.Equal("ComplexType EntityType", term.AppliesTo);
        }

        [Fact]
        public void TestValidationVocabularyDerivedTypeConstraintTerm()
        {
            var term = this._validationModel.FindDeclaredTerm("Org.OData.Validation.V1.DerivedTypeConstraint");
            Assert.NotNull(term);

            Assert.NotNull(term.Type);
            Assert.Equal(EdmTypeKind.Collection, term.Type.Definition.TypeKind);
            Assert.Equal("Collection(Core.QualifiedTypeName)", term.Type.Definition.FullTypeName());

            Assert.Equal("EntitySet Singleton NavigationProperty Property TypeDefinition Action Function Parameter", term.AppliesTo);
        }
        
        [Theory]
        [InlineData("AllowedValue", "Value")]
        [InlineData("ConstraintType", "FailureMessage|Condition")]
        [InlineData("ItemsOfType", "path|target")]
        public void TestValidationVocabularyComplexType(string typeName, string properties)
        {
            var schemaType = this._validationModel.FindDeclaredType("Org.OData.Validation.V1." + typeName);
            Assert.NotNull(schemaType);

            Assert.Equal(EdmTypeKind.Complex, schemaType.TypeKind);
            IEdmComplexType complex = (IEdmComplexType)(schemaType);

            Assert.False(complex.IsAbstract);
            Assert.False(complex.IsOpen);
            Assert.Null(complex.BaseType);

            Assert.NotEmpty(complex.DeclaredProperties);
            Assert.Equal(properties, string.Join("|", complex.DeclaredProperties.Select(e => e.Name)));
            Assert.Empty(complex.DeclaredNavigationProperties());
        }
    }
}
