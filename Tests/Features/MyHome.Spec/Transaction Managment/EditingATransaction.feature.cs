﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MyHome.Spec.TransactionManagment
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class EditingATransactionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "EditingATransaction.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "EditingATransaction", "In order to keep track of my income and expenses\r\nGiven that I am human\r\nI need t" +
                    "o be able to edit transactions already in the program", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "EditingATransaction")))
            {
                MyHome.Spec.TransactionManagment.EditingATransactionFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        public virtual void EditingTheDateToADateInThePast(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing the date to a date in the past", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table1.AddRow(new string[] {
                        "Date",
                        "2015-06-06"});
            table1.AddRow(new string[] {
                        "Amount",
                        "20.5"});
            table1.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 8
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table1, "And ");
#line 13
 testRunner.When("I change the \'Date\' to \'2000-06-06\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("the new \'Date\' equals \'2000-06-06\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the date to a date in the past")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void EditingTheDateToADateInThePast_EditExpense()
        {
            this.EditingTheDateToADateInThePast("editExpense", "expense", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the date to a date in the past")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void EditingTheDateToADateInThePast_EditIncome()
        {
            this.EditingTheDateToADateInThePast("editIncome", "income", ((string[])(null)));
        }
        
        public virtual void EditingTheDateToADateInTheFuture(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing the date to a date in the future", exampleTags);
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table2.AddRow(new string[] {
                        "Date",
                        "3000-06-06"});
            table2.AddRow(new string[] {
                        "Amount",
                        "20.5"});
            table2.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 23
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table2, "And ");
#line 28
 testRunner.When("I change the \'Date\' to \'4000-06-06\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("the new \'Date\' equals \'4000-06-06\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the date to a date in the future")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void EditingTheDateToADateInTheFuture_EditExpense()
        {
            this.EditingTheDateToADateInTheFuture("editExpense", "expense", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the date to a date in the future")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void EditingTheDateToADateInTheFuture_EditIncome()
        {
            this.EditingTheDateToADateInTheFuture("editIncome", "income", ((string[])(null)));
        }
        
        public virtual void EditingTheDateToNone(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing the date to none", exampleTags);
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table3.AddRow(new string[] {
                        "Date",
                        ""});
            table3.AddRow(new string[] {
                        "Amount",
                        "20.5"});
            table3.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 38
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table3, "And ");
#line 43
 testRunner.When("I change the \'Date\' to \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("the new \'Date\' equals \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the date to none")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void EditingTheDateToNone_EditExpense()
        {
            this.EditingTheDateToNone("editExpense", "expense", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the date to none")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void EditingTheDateToNone_EditIncome()
        {
            this.EditingTheDateToNone("editIncome", "income", ((string[])(null)));
        }
        
        public virtual void EditingTheAmount(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing the amount", exampleTags);
#line 51
this.ScenarioSetup(scenarioInfo);
#line 52
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table4.AddRow(new string[] {
                        "Date",
                        "2015-06-06"});
            table4.AddRow(new string[] {
                        "Amount",
                        "0"});
            table4.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 53
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table4, "And ");
#line 58
 testRunner.When("I change the \'Amount\' to \'20\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("the new \'Amount\' equals \'20\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the amount")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void EditingTheAmount_EditExpense()
        {
            this.EditingTheAmount("editExpense", "expense", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the amount")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void EditingTheAmount_EditIncome()
        {
            this.EditingTheAmount("editIncome", "income", ((string[])(null)));
        }
        
        public virtual void EditingTheCommentToNothing(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing the comment to nothing", exampleTags);
#line 66
this.ScenarioSetup(scenarioInfo);
#line 67
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table5.AddRow(new string[] {
                        "Date",
                        "2015-06-06"});
            table5.AddRow(new string[] {
                        "Amount",
                        "0"});
            table5.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 68
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table5, "And ");
#line 73
 testRunner.When("I change the \'Comment\' to \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("the new \'Comment\' equals \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the comment to nothing")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void EditingTheCommentToNothing_EditExpense()
        {
            this.EditingTheCommentToNothing("editExpense", "expense", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the comment to nothing")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void EditingTheCommentToNothing_EditIncome()
        {
            this.EditingTheCommentToNothing("editIncome", "income", ((string[])(null)));
        }
        
        public virtual void EditingTheComment(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing the comment", exampleTags);
#line 81
this.ScenarioSetup(scenarioInfo);
#line 82
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table6.AddRow(new string[] {
                        "Date",
                        "2015-06-06"});
            table6.AddRow(new string[] {
                        "Amount",
                        "0"});
            table6.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 83
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table6, "And ");
#line 88
 testRunner.When("I change the \'Comment\' to \'something else\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
 testRunner.Then("the new \'Comment\' equals \'something else\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the comment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void EditingTheComment_EditExpense()
        {
            this.EditingTheComment("editExpense", "expense", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the comment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void EditingTheComment_EditIncome()
        {
            this.EditingTheComment("editIncome", "income", ((string[])(null)));
        }
        
        public virtual void EditingTheCategory(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing the category", exampleTags);
#line 96
this.ScenarioSetup(scenarioInfo);
#line 97
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table7.AddRow(new string[] {
                        "Date",
                        "2015-06-06"});
            table7.AddRow(new string[] {
                        "Amount",
                        "12"});
            table7.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 98
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table7, "And ");
#line 103
 testRunner.When("I change the \'Category\' to \'clothes\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.Then("the new \'Category\' equals \'clothes\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the category")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void EditingTheCategory_EditExpense()
        {
            this.EditingTheCategory("editExpense", "expense", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the category")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void EditingTheCategory_EditIncome()
        {
            this.EditingTheCategory("editIncome", "income", ((string[])(null)));
        }
        
        public virtual void EditingTheCategoryToNothing(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing the category to nothing", exampleTags);
#line 112
this.ScenarioSetup(scenarioInfo);
#line 113
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table8.AddRow(new string[] {
                        "Date",
                        "2015-06-06"});
            table8.AddRow(new string[] {
                        "Amount",
                        "12"});
            table8.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 114
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table8, "And ");
#line 119
 testRunner.When("I change the \'Category\' to \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.Then("the handler returns an error indicator - \'There must be a category selected\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the category to nothing")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void EditingTheCategoryToNothing_EditExpense()
        {
            this.EditingTheCategoryToNothing("editExpense", "expense", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the category to nothing")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void EditingTheCategoryToNothing_EditIncome()
        {
            this.EditingTheCategoryToNothing("editIncome", "income", ((string[])(null)));
        }
        
        public virtual void EditingThePaymentMethod(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing the payment method", exampleTags);
#line 127
this.ScenarioSetup(scenarioInfo);
#line 128
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table9.AddRow(new string[] {
                        "Date",
                        "2015-06-06"});
            table9.AddRow(new string[] {
                        "Amount",
                        "12"});
            table9.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 129
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table9, "And ");
#line 134
 testRunner.When("I change the \'Method\' to \'check\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.Then("the new \'Method\' equals \'check\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the payment method")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void EditingThePaymentMethod_EditExpense()
        {
            this.EditingThePaymentMethod("editExpense", "expense", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the payment method")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void EditingThePaymentMethod_EditIncome()
        {
            this.EditingThePaymentMethod("editIncome", "income", ((string[])(null)));
        }
        
        public virtual void EditingThePaymentMethodToNothing(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing the payment method to nothing", exampleTags);
#line 142
this.ScenarioSetup(scenarioInfo);
#line 143
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table10.AddRow(new string[] {
                        "Date",
                        "2015-06-06"});
            table10.AddRow(new string[] {
                        "Amount",
                        "12"});
            table10.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 144
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table10, "And ");
#line 149
 testRunner.When("I change the \'Method\' to \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 150
 testRunner.Then("the handler returns an error indicator - \'There must be a payment method selected" +
                    "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the payment method to nothing")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void EditingThePaymentMethodToNothing_EditExpense()
        {
            this.EditingThePaymentMethodToNothing("editExpense", "expense", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing the payment method to nothing")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "EditingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "editIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void EditingThePaymentMethodToNothing_EditIncome()
        {
            this.EditingThePaymentMethodToNothing("editIncome", "income", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
