﻿//---------------------------------------------------------------------
// <copyright file="ExpandAndSelectPathExtractingTests.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.OData.UriParser;
using Microsoft.OData.Edm;
using Xunit;

namespace Microsoft.OData.Tests.ScenarioTests.UriParser
{
    public class ExpandAndSelectPathExtractingTests
    {
        private readonly EdmModel model;
        private readonly EdmEntityType baseType;
        private readonly EdmEntityType derivedType;
        private readonly EdmEntitySet entitySet;

        public ExpandAndSelectPathExtractingTests()
        {
            this.baseType = new EdmEntityType("FQ.NS", "Base");
            this.baseType.AddKeys(this.baseType.AddStructuralProperty("Id", EdmPrimitiveTypeKind.Int32));
            var baseNavigation1 = this.baseType.AddUnidirectionalNavigation(new EdmNavigationPropertyInfo { Name = "Navigation1", Target = this.baseType, TargetMultiplicity = EdmMultiplicity.ZeroOrOne });
            var baseNavigation2 = this.baseType.AddUnidirectionalNavigation(new EdmNavigationPropertyInfo { Name = "Navigation2", Target = this.baseType, TargetMultiplicity = EdmMultiplicity.ZeroOrOne });

            var addressType = new EdmComplexType("FQ.NS", "Address");
            addressType.AddStructuralProperty("City", EdmPrimitiveTypeKind.String);
            addressType.AddStructuralProperty("Region", EdmPrimitiveTypeKind.String);
            addressType.AddStructuralProperty("NearestAirports", new EdmCollectionTypeReference(new EdmCollectionType(new EdmComplexTypeReference(addressType, false))));
            addressType.AddUnidirectionalNavigation(new EdmNavigationPropertyInfo { Name = "Residents", Target = this.baseType, TargetMultiplicity = EdmMultiplicity.Many });

            this.baseType.AddStructuralProperty("Address", new EdmComplexTypeReference(addressType, false));

            this.derivedType = new EdmEntityType("FQ.NS", "Derived", this.baseType);
            this.derivedType.AddStructuralProperty("Derived", EdmPrimitiveTypeKind.Int32);
            var derivedNavigation = this.derivedType.AddUnidirectionalNavigation(new EdmNavigationPropertyInfo { Name = "DerivedNavigation", Target = this.derivedType, TargetMultiplicity = EdmMultiplicity.ZeroOrOne });

            var container = new EdmEntityContainer("FQ.NS", "Container");
            this.entitySet = container.AddEntitySet("Entities", this.baseType);
            this.entitySet.AddNavigationTarget(baseNavigation1, this.entitySet);
            this.entitySet.AddNavigationTarget(baseNavigation2, this.entitySet);
            this.entitySet.AddNavigationTarget(derivedNavigation, this.entitySet);

            this.model = new EdmModel();
            this.model.AddElement(this.baseType);
            this.model.AddElement(this.derivedType);
            this.model.AddElement(container);
        }

        [Fact]
        public void EmptyExpand()
        {
            this.ParseAndExtract(string.Empty, null);
        }

        [Fact]
        public void EmptyExpandWithSelect()
        {
            this.ParseAndExtract(string.Empty, "Id");
        }

        [Fact]
        public void WideExpand()
        {
            const string expandClauseText = "Navigation1,Navigation2";
            const string expectedSelect = "";
            this.ParseAndExtract(expandClauseText, expectedSelectClauseFromOM: expectedSelect);
        }

        [Fact]
        public void DeepExpand()
        {
            const string expandClauseText = "Navigation1($expand=Navigation2($expand=Navigation1))";
            const string expectedSelectClause = "";
            this.ParseAndExtract(expandClauseText, null, expandClauseText, expectedSelectClause);
        }

        [Fact]
        public void MultiLevelExpand()
        {
            const string expandClauseText = "Navigation1,Navigation2($expand=Navigation1)";
            const string expectedSelectClause = "";
            this.ParseAndExtract(expandClauseText, expectedExpandClauseFromOM: expandClauseText, expectedSelectClauseFromOM: expectedSelectClause);
        }

        [Fact]
        public void DeepThenWideExpand()
        {
            // Note that the SelectExpandClause.GetV3SelectExpandPaths() will always put the paths in a different order than the original clause.
            const string expandClauseText = "Navigation1($expand=Navigation1($expand=Navigation1)), Navigation1($expand=Navigation2($expand=Navigation1)), Navigation1($expand=Navigation2($expand=Navigation2))";
            const string expectedExpandClauseText = "Navigation1($expand=Navigation2($expand=Navigation1,Navigation2),Navigation1($expand=Navigation1))";
            const string expectedSelectClauseText = "";
            this.ParseAndExtract(expandClauseText, expectedExpandClauseFromOM: expectedExpandClauseText, expectedSelectClauseFromOM: expectedSelectClauseText);
        }

        [Fact]
        public void ExpandAtAllLevelsOfDeepPathShouldBeCollapsed()
        {
            const string expandClauseText = "Navigation1,Navigation1($expand=Navigation2),Navigation1($expand=Navigation2($expand=Navigation1))";
            const string expectedExpand = "Navigation1($expand=Navigation2($expand=Navigation1))";
            const string expectedSelect = "";
            this.ParseAndExtract(expandClauseText, expectedExpandClauseFromOM: expectedExpand, expectedSelectClauseFromOM: expectedSelect);
        }

        [Fact]
        public void ExpandWithTypeSegment()
        {
            const string expandClauseText = "FQ.NS.Derived/Navigation1";
            this.ParseAndExtract(expandClauseText, expectedSelectClauseFromOM: "");
        }

        [Fact]
        public void DeepExpandWithTypeSegment()
        {
            const string expandClauseText = "Navigation1($expand=FQ.NS.Derived/Navigation2)";
            const string expectedSelectClause = "";
            this.ParseAndExtract(expandClauseText, null, expandClauseText, expectedSelectClause);
        }

        [Fact]
        public void EmptySelect()
        {
            this.ParseAndExtract(null, string.Empty);
        }

        [Fact]
        public void EmptySelectWithExpand()
        {
            const string expectedSelect = "";
            this.ParseAndExtract("Navigation1", string.Empty, null, expectedSelect);
        }

        [Fact]
        public void SelectSingleProperty()
        {
            const string selectClauseText = "Id";
            this.ParseAndExtract(selectClauseText: selectClauseText);
        }

        [Fact]
        public void SelectSinglePropertyWithTypeSegment()
        {
            const string selectClauseText = "FQ.NS.Derived/Id";
            this.ParseAndExtract(selectClauseText: selectClauseText);
        }

        [Fact]
        public void SelectNavigationProperty()
        {
            const string selectClauseText = "Navigation1";
            this.ParseAndExtract(selectClauseText: selectClauseText);
        }

        [Fact]
        public void SelectNavigationPropertyWithTypeSegment()
        {
            const string selectClauseText = "FQ.NS.Derived/Navigation1";
            this.ParseAndExtract(selectClauseText: selectClauseText);
        }

        [Fact]
        public void SelectNavigationPropertiesThatAreAlsoExpanded()
        {
            const string expandClauseText = "Navigation1($expand=Navigation1($select=Navigation2))";
            const string expectedSelectClauseText = "";
            this.ParseAndExtract(expandClauseText: expandClauseText, expectedExpandClauseFromOM: expandClauseText, expectedSelectClauseFromOM: expectedSelectClauseText);
        }

        [Fact]
        public void SelectPrimitiveAndNavigationPropertyThatIsAlsoExpanded()
        {
            const string selectClauseText = "Id,Navigation1";
            this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: "Navigation1", expectedSelectClauseFromOM: selectClauseText);
        }

        [Fact]
        public void SelectDuplicatePropertySucceeds()
        {
            const string selectClauseText = "Address,Address";
            const string expectedSelectClauseText = "Address";
            this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: null, expectedSelectClauseFromOM: expectedSelectClauseText, expectedExpandClauseFromOM: null);
        }

        [Fact]
        public void SelectAndExpandOnComplexIncludesBoth()
        {
            const string selectClauseText = "Address/City";
            const string expandClauseText = "Address/Residents";
            this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: expandClauseText, expectedSelectClauseFromOM: selectClauseText, expectedExpandClauseFromOM: expandClauseText);
        }


        [Fact]
        public void MultipleSelectPathsSucceed()
        {
            const string selectClauseText = "Address/City,Address/Region";
            this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: null, expectedSelectClauseFromOM: selectClauseText, expectedExpandClauseFromOM: null);
        }

        [Fact]
        public void SelectDuplicatePropertyWithOptionsFails()
        {
            const string selectClauseText = "Address($select=City),Address($select=Region)";
            System.Action test = () => this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: null, expectedSelectClauseFromOM: null, expectedExpandClauseFromOM: null);
            test.Throws<ODataException>("Found multiple select terms with same select path 'Address' at one $select, please combine them together.");
        }

        [Fact]
        public void DifferentPathsToSamePropertyFails()
        {
            const string selectClauseText = "Address($select=NearestAirports),Address/NearestAirports";
            System.Action test = () => this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: null, expectedSelectClauseFromOM: null, expectedExpandClauseFromOM: null);
            test.Throws<ODataException>("Found multiple select terms with same select path 'Address/NearestAirports' at one $select, please combine them together.");
        }

        [Fact]
        public void DifferentPathsToSamePropertyWithOptionsFails()
        {
            const string selectClauseText = "Address($select=NearestAirports($top=2)),Address/NearestAirports";
            System.Action test = () => this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: null, expectedSelectClauseFromOM: null, expectedExpandClauseFromOM: null);
            test.Throws<ODataException>("Found multiple select terms with same select path 'Address/NearestAirports' at one $select, please combine them together.");
        }

        [Fact]
        public void DifferentPathsToSamePropertyWithOptionsOnBothFails()
        {
            const string selectClauseText = "Address($select=NearestAirports($top=2)),Address/NearestAirports($skip=2)";
            System.Action test = () => this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: null, expectedSelectClauseFromOM: null, expectedExpandClauseFromOM: null);
            test.Throws<ODataException>("Found multiple select terms with same select path 'Address/NearestAirports' at one $select, please combine them together.");
        }

        [Fact]
        public void DifferentPathsToSamePropertyWithSubselectsOnBothFails()
        {
            const string selectClauseText = "Address($select=NearestAirports($select=City)),Address/NearestAirports($select=Region)";
            System.Action test = () => this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: null, expectedSelectClauseFromOM: null, expectedExpandClauseFromOM: null);
            test.Throws<ODataException>("Found multiple select terms with same select path 'Address/NearestAirports' at one $select, please combine them together.");
        }

        [Fact]
        public void SelectDuplicatePropertyWithOptionsFirstFails()
        {
            const string selectClauseText = "Address($select=City),Address";
            System.Action test = () => this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: null, expectedSelectClauseFromOM: null, expectedExpandClauseFromOM: null);
            test.Throws<ODataException>("Found multiple select terms with same select path 'Address' at one $select, please combine them together.");
        }

        [Fact]
        public void SelectDuplicatePropertyWithOptionsLastFails()
        {
            const string selectClauseText = "Address,Address($select=City)";
            System.Action test = () => this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: null, expectedSelectClauseFromOM: null, expectedExpandClauseFromOM: null);
            test.Throws<ODataException>("Found multiple select terms with same select path 'Address' at one $select, please combine them together.");
        }

        [Fact]
        public void SelectDuplicatePropertyWithSubselectAndOptionsFails()
        {
            const string selectClauseText = "Address/NearestAirports($select=City),Address/NearestAirports($top=2)";
            System.Action test = () => this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: null, expectedSelectClauseFromOM: null, expectedExpandClauseFromOM: null);
            test.Throws<ODataException>("Found multiple select terms with same select path 'Address/NearestAirports' at one $select, please combine them together.");
        }

        [Fact]
        public void SelectDuplicatePropertyWithTopFails()
        {
            const string selectClauseText = "Address/NearestAirports($top=2),Address/NearestAirports";
            System.Action test = () => this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: null, expectedSelectClauseFromOM: null, expectedExpandClauseFromOM: null);
            test.Throws<ODataException>("Found multiple select terms with same select path 'Address/NearestAirports' at one $select, please combine them together.");
        }

        [Fact]
        public void DuplicateDeepSelectOptionsFails()
        {
            const string selectClauseText = "Address($select=NearestAirports($select=City),NearestAirports($select=Region))";
            System.Action test = () => this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: null, expectedSelectClauseFromOM: null, expectedExpandClauseFromOM: null);
            test.Throws<ODataException>("Found multiple select terms with same select path 'NearestAirports' at one $select, please combine them together.");
        }

        [Fact]
        public void SelectPrimitiveAndNavigationPropertyThatIsNotExpanded()
        {
            const string selectClauseText = "Id,Navigation1";
            this.ParseAndExtract(selectClauseText: selectClauseText);
        }

        [Fact]
        public void SelectWildcardUnderNavigation()
        {
            const string expandClauseText = "Navigation1($select=*)";
            const string expectedSelectText = "";
            this.ParseAndExtract(expandClauseText: expandClauseText, expectedExpandClauseFromOM: expandClauseText, expectedSelectClauseFromOM: expectedSelectText);
        }

        [Fact]
        public void SelectAndExpandWithTypeSegments()
        {
            const string navClauseText = "FQ.NS.Derived/Navigation1";
            this.ParseAndExtract(selectClauseText: navClauseText, expandClauseText: navClauseText, expectedSelectClauseFromOM: navClauseText,  expectedExpandClauseFromOM: navClauseText);
            this.ParseAndExtract(selectClauseText: navClauseText, expandClauseText: "", expectedSelectClauseFromOM: navClauseText);
            this.ParseAndExtract(selectClauseText: "", expandClauseText: navClauseText, expectedExpandClauseFromOM: navClauseText);
        }

        [Fact]
        public void SelectAndExpandWithTypeSegments2()
        {
            const string expandClauseText = "FQ.NS.Derived/Navigation1($select=FQ.NS.Derived/Derived,FQ.NS.Derived/Navigation2)";
            const string expectedSelectText = "";
            this.ParseAndExtract(expandClauseText, expectedExpandClauseFromOM: expandClauseText, expectedSelectClauseFromOM: expectedSelectText);
        }

        [Fact]
        public void NestedExpandWithDuplicteSelectTest()
        {
            const string expandClauseText = "Navigation1($select=Id),Navigation1($select=Id)";
            const string expectedExpandText = "Navigation1($select=Id)";
            const string expectedSelectText = "";
            this.ParseAndExtract(expandClauseText, expectedExpandClauseFromOM: expectedExpandText, expectedSelectClauseFromOM: expectedSelectText);
        }

        [Fact]
        public void ExpandNavigationThatIsNotSelectedAutomaticallySelectsLink()
        {
            const string selectClauseText = "Navigation2";
            const string expandClauseText = "Navigation1";
            this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: expandClauseText, expectedSelectClauseFromOM: selectClauseText, expectedExpandClauseFromOM: expandClauseText);
        }

        [Fact]
        public void ExpandNavigationThatIsNotSelectedInNonTopLevelAutomaticallySelectsLink()
        {
            const string expandClauseText = "Navigation1($select=Navigation1;$expand=Navigation2)";
            this.ParseAndExtract(selectClauseText: null, expandClauseText: expandClauseText, expectedSelectClauseFromOM: null, expectedExpandClauseFromOM: expandClauseText);
        }

        [Fact]
        public void SelectPropertiesDefinedOnDerivedTypesWithoutRepeatingTypeSegments()
        {
            const string expandClauseText = "FQ.NS.Derived/DerivedNavigation($expand=DerivedNavigation($select=Derived))";
            const string expectedSelect = "";
            this.ParseAndExtract(expandClauseText: expandClauseText, expectedExpandClauseFromOM: expandClauseText, expectedSelectClauseFromOM: expectedSelect);
        }

        [Fact]
        public void ExpandPropertiesWithTypeSegmentWithDuplicteSelectTestWithRefOperation()
        {
            const string expandClauseText = "FQ.NS.Derived/Navigation1/$ref,FQ.NS.Derived/Navigation1/$ref";
            const string expectedExpandClause = "FQ.NS.Derived/Navigation1/$ref";
            this.ParseAndExtract(expandClauseText: expandClauseText, expectedExpandClauseFromOM: expectedExpandClause);
        }

        [Fact]
        public void ExpandNavigationThatIsNotSelectedAutomaticallySelectsLinkWithRefOperation()
        {
            const string selectClauseText = "FQ.NS.Derived/Navigation2";
            const string expandClauseText = "FQ.NS.Derived/Navigation1/$ref";
            const string expectedSelectClause = "FQ.NS.Derived/Navigation2,FQ.NS.Derived/Navigation1";
            this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: expandClauseText, expectedSelectClauseFromOM: expectedSelectClause, expectedExpandClauseFromOM: expandClauseText);
        }

        [Fact]
        public void ExpandNavigationThatIsSelectedButAlsoInExpandWithRefOperation()
        {
            const string selectClauseText = "FQ.NS.Derived/Navigation1,FQ.NS.Derived/Navigation2";
            const string expandClauseText = "FQ.NS.Derived/Navigation1/$ref";
            this.ParseAndExtract(selectClauseText: selectClauseText, expandClauseText: expandClauseText, expectedSelectClauseFromOM: selectClauseText, expectedExpandClauseFromOM: expandClauseText);
        }

        private void ParseAndExtract(string expandClauseText = null, string selectClauseText = null, string expectedExpandClauseFromOM = null, string expectedSelectClauseFromOM = null)
        {
            foreach (ODataVersion version in new ODataVersion[]{ ODataVersion.V4, ODataVersion.V401})
            {
                var expandClause = new ODataQueryOptionParser(this.model, this.baseType, this.entitySet, new Dictionary<string, string> { { "$expand", expandClauseText }, { "$select", selectClauseText } }).ParseSelectAndExpand();

                // Verify that the extension method gets the same result as the path extractor.
                string selectTextFromOM, expandTextFromOM;
                expandClause.GetSelectExpandPaths(version, out selectTextFromOM, out expandTextFromOM);
                Assert.Equal(expectedSelectClauseFromOM ?? selectClauseText ?? string.Empty, selectTextFromOM);
                Assert.Equal(expectedExpandClauseFromOM ?? expandClauseText ?? string.Empty, expandTextFromOM);
            }
        }
    }
}