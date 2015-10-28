using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculationServices;
using System.Windows.Forms; // key

namespace UnitTest_Parser
{
    [TestClass]
    public class UnitTestToken
    {
        [TestMethod]
        public void TestMethod_isOperator()
        {
            Assert.AreEqual(true, Token.isOperator('+'));
            Assert.AreEqual(true, Token.isOperator('-'));
            Assert.AreEqual(true, Token.isOperator('*'));
            Assert.AreEqual(true, Token.isOperator('/'));
        }
        [TestMethod]
        public void TestMethod_isParenthesis()
        {
            Assert.AreEqual(true, Token.isParenthesis('('));
            Assert.AreEqual(true, Token.isParenthesis(')'));
        }
        [TestMethod]
        public void TestMethod_isNumber()
        {
            Assert.AreEqual(true, Token.isNumber('0'));
            Assert.AreEqual(true, Token.isNumber('1'));
            Assert.AreEqual(true, Token.isNumber('2'));
            Assert.AreEqual(true, Token.isNumber('3'));
            Assert.AreEqual(true, Token.isNumber('4'));
            Assert.AreEqual(true, Token.isNumber('5'));
            Assert.AreEqual(true, Token.isNumber('6'));
            Assert.AreEqual(true, Token.isNumber('7'));
            Assert.AreEqual(true, Token.isNumber('8'));
            Assert.AreEqual(true, Token.isNumber('9'));
            Assert.AreEqual(false, Token.isNumber('a'));
            Assert.AreEqual(false, Token.isNumber('b'));
            Assert.AreEqual(false, Token.isNumber('c'));
            Assert.AreEqual(false, Token.isNumber('d'));
            Assert.AreEqual(false, Token.isNumber('e'));
            Assert.AreEqual(false, Token.isNumber('f'));
        }
        [TestMethod]
        public void TestMethod_isMinusSign()
        {
            Assert.AreEqual(true, Token.isMinusSign('-'));
            Assert.AreEqual(false, Token.isMinusSign('+'));
        }
        [TestMethod]
        public void TestMethod_isEqual()
        {
            Assert.AreEqual(true, Token.isEqual('='));
        }
        [TestMethod]
        public void TestMethod_isBackSpace()
        {
            Assert.AreEqual(true, Token.isBackSpace((char)Keys.Back));
        }
        [TestMethod]
        public void TestMethod_isToken()
        {
            char[] tokens = new char[]{
                '0','1','2','3','4','5','6','7','8','9',
                '+','-','*','/',
                '(',')',
            };
            foreach(var v in tokens)
            {
                Assert.AreEqual(true,Token.isToken(v));
            }
            Assert.AreEqual(false, Token.isToken('='));
        }

    }
}
