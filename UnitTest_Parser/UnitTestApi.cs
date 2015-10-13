using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculationServices;

namespace UnitTest_Parser
{
    [TestClass]
    public class UnitTestApi
    {
        [TestMethod]
        public void TestMethod_Init()
        {
            CalcServicesApi api = new CalcServicesApi();

            Assert.IsTrue( api.STATEMENT.Equals(""));
            Assert.IsTrue( api.EDIT.Equals("0"));
        }
        [TestMethod]
        public void TestMethod_ClearStatement()
        {
            CalcServicesApi api = new CalcServicesApi();
            var obj = new PrivateObject(api);

            obj.SetField("statement", "11+22-");
            obj.SetField("editNumber", "120");

            obj.Invoke("ClearStatement");

            Assert.IsTrue(api.STATEMENT.Equals(""));
            Assert.IsTrue(api.EDIT.Equals("120"));
        }
        [TestMethod]
        public void TestMethod_ClearEditNumber()
        {
            CalcServicesApi api = new CalcServicesApi();
            var obj = new PrivateObject(api);

            obj.SetField("statement", "11+22-");
            obj.SetField("editNumber", "120");

            obj.Invoke("ClearEditNumber");

            Assert.IsTrue(api.STATEMENT.Equals("11+22-"));
            Assert.IsTrue(api.EDIT.Equals("0"));
        } 
        [TestMethod]
        public void TestMethod_InputNum()
        {
            CalcServicesApi api = new CalcServicesApi();

            api.inputNum('0');
            Assert.IsTrue(api.STATEMENT.Equals(""));
            Assert.IsTrue(api.EDIT.Equals("0"));
            
            api.inputNum('1');
            Assert.IsTrue(api.STATEMENT.Equals(""));
            Assert.IsTrue(api.EDIT.Equals("1"));

            api.inputNum('2');
            Assert.IsTrue(api.STATEMENT.Equals(""));
            Assert.IsTrue(api.EDIT.Equals("12"));

            api.inputNum('3');
            Assert.IsTrue(api.STATEMENT.Equals(""));
            Assert.IsTrue(api.EDIT.Equals("123"));

            api.inputNum('4');
            Assert.IsTrue(api.STATEMENT.Equals(""));
            Assert.IsTrue(api.EDIT.Equals("1234"));
 
            api.inputNum('5');
            Assert.IsTrue(api.STATEMENT.Equals(""));
            Assert.IsTrue(api.EDIT.Equals("12345"));
        }
        [TestMethod]
        public void TestMethod_InputOperator()
        {
            CalcServicesApi api = new CalcServicesApi();

            api.inputOperator('+');

            Assert.IsTrue(api.STATEMENT.Equals("0+"));
            Assert.IsTrue(api.EDIT.Equals("0"));

            api.inputNum('1');
            Assert.IsTrue(api.STATEMENT.Equals("0+"));
            Assert.IsTrue(api.EDIT.Equals("1"));

            api.inputOperator('*');
            Assert.IsTrue(api.STATEMENT.Equals("0+1*"));
            Assert.IsTrue(api.EDIT.Equals("0"));
        }
        [TestMethod]
        public void TestMethod_inputReverseSign()
        {
            CalcServicesApi api = new CalcServicesApi();
            var obj = new PrivateObject(api);

            obj.SetField("statement", "");
            obj.SetField("editNumber", "120");

            api.inputReverseSign();

            Assert.IsTrue(api.STATEMENT.Equals(""));
            Assert.IsTrue(api.EDIT.Equals("-120"));
        }
        [TestMethod]
        public void TestMethod_inputBackSpace()
        {
            CalcServicesApi api = new CalcServicesApi();
            var obj = new PrivateObject(api);

            api.inputBackSpace();
            Assert.IsTrue(api.STATEMENT.Equals(""));
            Assert.IsTrue(api.EDIT.Equals("0"));

            obj.SetField("statement", "");
            obj.SetField("editNumber", "120");

            api.inputBackSpace();
            Assert.IsTrue(api.STATEMENT.Equals(""));
            Assert.IsTrue(api.EDIT.Equals("12"));

            api.inputBackSpace();
            Assert.IsTrue(api.STATEMENT.Equals(""));
            Assert.IsTrue(api.EDIT.Equals("1"));
 
            api.inputBackSpace();
            Assert.IsTrue(api.STATEMENT.Equals(""));
            Assert.IsTrue(api.EDIT.Equals("0"));

        }
        [TestMethod]
        public void TestMethod_inputClearEdit()
        {
            CalcServicesApi api = new CalcServicesApi();
            var obj = new PrivateObject(api);

            obj.SetField("statement","120+");
            obj.SetField("editNumber", "100");

            api.inputClearEdit();

            Assert.IsTrue(api.STATEMENT.Equals("120+"));
            Assert.IsTrue(api.EDIT.Equals("0"));
        }
        [TestMethod]
        public void TestMethod_inputClearAll()
        {
            CalcServicesApi api = new CalcServicesApi();
            var obj = new PrivateObject(api);

            obj.SetField("statement", "120+");
            obj.SetField("editNumber", "100");

            api.inputClearAll();

            Assert.IsTrue(api.STATEMENT.Equals(""));
            Assert.IsTrue(api.EDIT.Equals("0"));
        }
    }
}
