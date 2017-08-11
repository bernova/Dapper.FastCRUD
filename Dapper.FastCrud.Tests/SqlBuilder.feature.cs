﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Dapper.FastCrud.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SQL Builder")]
    public partial class SQLBuilderFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SqlBuilder.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SQL Builder", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Select all columns")]
        [NUnit.Framework.CategoryAttribute("InMemoryDatabase")]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "workstation", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "workstation", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "workstation", null)]
        [NUnit.Framework.TestCaseAttribute("SqLite", "workstation", null)]
        public virtual void SelectAllColumns(string databaseType, string entityType, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "InMemoryDatabase"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Select all columns", @__tags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given(string.Format("I extract the SQL builder for {0} and {1}", databaseType, entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When("I construct the select column enumeration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.Then("I should get a valid select column enumeration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Manual query")]
        [NUnit.Framework.CategoryAttribute("InMemoryDatabase")]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "workstation", "individual identifier resolvers", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "workstation", "individual identifier resolvers", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "workstation", "individual identifier resolvers", null)]
        [NUnit.Framework.TestCaseAttribute("SqLite", "workstation", "individual identifier resolvers", null)]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "workstation", "combined table and column identifier resolvers", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "workstation", "combined table and column identifier resolvers", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "workstation", "combined table and column identifier resolvers", null)]
        [NUnit.Framework.TestCaseAttribute("SqLite", "workstation", "combined table and column identifier resolvers", null)]
        public virtual void ManualQuery(string databaseType, string entityType, string sqlQueryBuilderMethod, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "InMemoryDatabase"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Manual query", @__tags);
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
 testRunner.Given(string.Format("I extract the SQL builder for {0} and {1}", databaseType, entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
 testRunner.When(string.Format("I construct a complex join query for {0} using {1}", entityType, sqlQueryBuilderMethod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then(string.Format("I should get a valid join query statement for {0}", entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
