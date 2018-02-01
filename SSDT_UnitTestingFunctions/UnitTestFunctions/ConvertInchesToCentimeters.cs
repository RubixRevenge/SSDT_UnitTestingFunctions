using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFunctions
{
    [TestClass()]
    public class ConvertInchesToCentimeters : SqlDatabaseTestClass
    {

        public ConvertInchesToCentimeters()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction If_Given_0_Inches_Return_0_Centimeters_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertInchesToCentimeters));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction If_Given_1_Inch_Return_2_54_Centimeters_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction If_Given_Negative_1_Inch_Return_Negative_2_54_Centimeters_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition3;
            this.If_Given_0_Inches_Return_0_CentimetersData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.If_Given_1_Inch_Return_2_54_CentimetersData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.If_Given_Negative_1_Inch_Return_Negative_2_54_CentimetersData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            If_Given_0_Inches_Return_0_Centimeters_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            If_Given_1_Inch_Return_2_54_Centimeters_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            If_Given_Negative_1_Inch_Return_Negative_2_54_Centimeters_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // If_Given_0_Inches_Return_0_Centimeters_TestAction
            // 
            If_Given_0_Inches_Return_0_Centimeters_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(If_Given_0_Inches_Return_0_Centimeters_TestAction, "If_Given_0_Inches_Return_0_Centimeters_TestAction");
            // 
            // If_Given_0_Inches_Return_0_CentimetersData
            // 
            this.If_Given_0_Inches_Return_0_CentimetersData.PosttestAction = null;
            this.If_Given_0_Inches_Return_0_CentimetersData.PretestAction = null;
            this.If_Given_0_Inches_Return_0_CentimetersData.TestAction = If_Given_0_Inches_Return_0_Centimeters_TestAction;
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "0";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // If_Given_1_Inch_Return_2_54_CentimetersData
            // 
            this.If_Given_1_Inch_Return_2_54_CentimetersData.PosttestAction = null;
            this.If_Given_1_Inch_Return_2_54_CentimetersData.PretestAction = null;
            this.If_Given_1_Inch_Return_2_54_CentimetersData.TestAction = If_Given_1_Inch_Return_2_54_Centimeters_TestAction;
            // 
            // If_Given_1_Inch_Return_2_54_Centimeters_TestAction
            // 
            If_Given_1_Inch_Return_2_54_Centimeters_TestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(If_Given_1_Inch_Return_2_54_Centimeters_TestAction, "If_Given_1_Inch_Return_2_54_Centimeters_TestAction");
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 1;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "2.54";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 1;
            // 
            // If_Given_Negative_1_Inch_Return_Negative_2_54_CentimetersData
            // 
            this.If_Given_Negative_1_Inch_Return_Negative_2_54_CentimetersData.PosttestAction = null;
            this.If_Given_Negative_1_Inch_Return_Negative_2_54_CentimetersData.PretestAction = null;
            this.If_Given_Negative_1_Inch_Return_Negative_2_54_CentimetersData.TestAction = If_Given_Negative_1_Inch_Return_Negative_2_54_Centimeters_TestAction;
            // 
            // If_Given_Negative_1_Inch_Return_Negative_2_54_Centimeters_TestAction
            // 
            If_Given_Negative_1_Inch_Return_Negative_2_54_Centimeters_TestAction.Conditions.Add(scalarValueCondition3);
            resources.ApplyResources(If_Given_Negative_1_Inch_Return_Negative_2_54_Centimeters_TestAction, "If_Given_Negative_1_Inch_Return_Negative_2_54_Centimeters_TestAction");
            // 
            // scalarValueCondition3
            // 
            scalarValueCondition3.ColumnNumber = 1;
            scalarValueCondition3.Enabled = true;
            scalarValueCondition3.ExpectedValue = "-2.54";
            scalarValueCondition3.Name = "scalarValueCondition3";
            scalarValueCondition3.NullExpected = false;
            scalarValueCondition3.ResultSet = 1;
            scalarValueCondition3.RowNumber = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void If_Given_0_Inches_Return_0_Centimeters()
        {
            SqlDatabaseTestActions testActions = this.If_Given_0_Inches_Return_0_CentimetersData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void If_Given_1_Inch_Return_2_54_Centimeters()
        {
            SqlDatabaseTestActions testActions = this.If_Given_1_Inch_Return_2_54_CentimetersData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void If_Given_Negative_1_Inch_Return_Negative_2_54_Centimeters()
        {
            SqlDatabaseTestActions testActions = this.If_Given_Negative_1_Inch_Return_Negative_2_54_CentimetersData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }


        private SqlDatabaseTestActions If_Given_0_Inches_Return_0_CentimetersData;
        private SqlDatabaseTestActions If_Given_1_Inch_Return_2_54_CentimetersData;
        private SqlDatabaseTestActions If_Given_Negative_1_Inch_Return_Negative_2_54_CentimetersData;
    }
}
