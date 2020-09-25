﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.4.0.0
//      SpecFlow Generator Version:3.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Kandziuba_SpecFlow.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("FormTesting")]
    public partial class FormTestingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "FormTesting.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "FormTesting", "\tIn order to share news with the BBC\r\n\tAs a guest\r\n\tI want to type a story and fi" +
                    "ll the personal data form", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
#line 7
 testRunner.Given("the website is opened on the main page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.And("I click on the News tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 9
 testRunner.And("I close emerged Sign-in popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 10
 testRunner.And("I click on the Coronavirus tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 11
 testRunner.And("I click on Your Coronavirus Story tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify that user can\'t submit a story to BBC without filling the Name field")]
        [NUnit.Framework.CategoryAttribute("critical_path")]
        [NUnit.Framework.TestCaseAttribute("Test", "", "vasya@gmail.com", "0987654321", "Kyiv", "press", "press", "press", null)]
        [NUnit.Framework.TestCaseAttribute("", "Vasya", "vasya@gmail.com", "0987654321", "Kyiv", "press", "press", "press", null)]
        [NUnit.Framework.TestCaseAttribute("Test", "", "vasya@gmail.com", "0987654321", "Kyiv", "press", "press", "", null)]
        public virtual void VerifyThatUserCantSubmitAStoryToBBCWithoutFillingTheNameField(string tellUsYourStory_, string name, string emailAddress, string contactNumber, string location, string checkbox_1, string checkbox_2, string checkbox_3, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "critical_path"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Tell us your story.", tellUsYourStory_);
            argumentsOfScenario.Add("Name", name);
            argumentsOfScenario.Add("Email address", emailAddress);
            argumentsOfScenario.Add("Contact number", contactNumber);
            argumentsOfScenario.Add("Location", location);
            argumentsOfScenario.Add("Checkbox_1", checkbox_1);
            argumentsOfScenario.Add("Checkbox_2", checkbox_2);
            argumentsOfScenario.Add("Checkbox_3", checkbox_3);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that user can\'t submit a story to BBC without filling the Name field", null, tagsOfScenario, argumentsOfScenario);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 15
 testRunner.Given("I click on Have Your Say tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table1.AddRow(new string[] {
                            "\'Tell us your story. \'",
                            string.Format("{0}", tellUsYourStory_)});
                table1.AddRow(new string[] {
                            "\'Name\'",
                            string.Format("{0}", name)});
                table1.AddRow(new string[] {
                            "\'Email address\'",
                            string.Format("{0}", emailAddress)});
                table1.AddRow(new string[] {
                            "\'Contact number \'",
                            string.Format("{0}", contactNumber)});
                table1.AddRow(new string[] {
                            "\'Location \'",
                            string.Format("{0}", location)});
                table1.AddRow(new string[] {
                            "Checkbox_1",
                            string.Format("{0}", checkbox_1)});
                table1.AddRow(new string[] {
                            "Checkbox_2",
                            string.Format("{0}", checkbox_2)});
                table1.AddRow(new string[] {
                            "Checkbox_3",
                            string.Format("{0}", checkbox_3)});
#line 16
 testRunner.When("I fill the form and checkboxes", ((string)(null)), table1, "When ");
#line hidden
#line 26
 testRunner.And("I press Submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.Then("error occures", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
