using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CalculationServices.Parser;
using CalculationServices.ParserExcepton;

using System.Diagnostics;

namespace UnitTest
{
    [TestClass]
    public class UnitTestParser
    {
        /// <summary>
        /// Test if statement is null.
        /// </summary>
        [TestMethod]
        public void TestMethod_Null()
        {
            Parser p = new Parser();

            var result = p.parse(null);
            Assert.AreEqual(true, result.Message.Equals(Messages.MSG_NULL));
            Assert.AreEqual(0, result.Result);
        }
        /// <summary>
        /// Test if statement is empty. 
        /// </summary>
        [TestMethod]
        public void TestMethod_EmptyString()
        {
            Parser parser = new Parser();

            var result = parser.parse("");
            Assert.AreEqual(true, result.Message.Equals(Messages.MSG_EMPTY));
            Assert.AreEqual( 0 ,result.Result );
        }
        /// <summary>
        /// Test if statement is just numbers.
        /// </summary>
        [TestMethod]
        public void TestMethod_Number()
        {
            Parser p = new Parser();

            string[] statements = new string[]{
                "0",
                "1",
                "12",
                "123",
                "1234",
                "12345",
                "123456",
                "1234567",
                "12345678",
                "123456789",
                "1234567890",
                "9223372036854775807", // MAX signed 64bit integer.
            };

            foreach( var s in statements)
            {
                Trace.WriteLine(s);

                var r = p.parse(s);

                var expected =  long.Parse(s);

                Assert.AreEqual(expected, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));           
            }
        }
        /// <summary>
        /// Test if statement is just minus numbers.
        /// </summary>
        [TestMethod]
        public void TestMethod_MinusNumber()
        {
            Parser p = new Parser();

            string[] statements = new string[]{
                "-0",
                "-1",
                "-12",
                "-123",
                "-1234",
                "-12345",
                "-123456",
                "-1234567",
                "-12345678",
                "-123456789",
                "-1234567890",
                "-9223372036854775808", // Min signed 64bit integer
            };

            foreach( var s in statements)
            {
                var r = p.parse(s);
                var expected = long.Parse(s);
                Assert.AreEqual(expected, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }

        }
        /// <summary>
        /// Test if statement is simply adding expression.
        /// </summary>
        [TestMethod]
        public void TestMethod_Add()
        {
            Parser p = new Parser();

            {
                var r = p.parse("10+11");
                Assert.AreEqual(21, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("11+10");
                Assert.AreEqual(21, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("11+10+9");
                Assert.AreEqual(30, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
        }
        /// <summary>
        /// Test if statement is simply subtraction's expression.
        /// </summary>
        [TestMethod]
        public void TestMethod_Sub()
        {
            Parser p = new Parser();

            {
                var r = p.parse("11-123");
                Assert.AreEqual(-112, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("123-11");
                Assert.AreEqual(112, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("100-10-9-8");
                Assert.AreEqual(73, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }

        }
        /// <summary>
        /// Test if statement is simply multiplication's expression.
        /// </summary>
        [TestMethod]
        public void TestMethod_Mul()
        {
            Parser p = new Parser();
            {
                var r = p.parse("17*91");
                Assert.AreEqual(1547, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("91*17");
                Assert.AreEqual(1547, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("2*3*4*5");
                Assert.AreEqual(120, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("5*4*3*2");
                Assert.AreEqual(120, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
        }
        /// <summary>
        /// Test if statement is simply division's expression.
        /// </summary>
        [TestMethod]
        public void TestMethod_Div()
        {
            Parser p = new Parser();
            {
                var r = p.parse("91/17");
                Assert.AreEqual(5, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("91/17/2");
                Assert.AreEqual(2, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
        }
        /// <summary>
        /// Test complex statement.
        /// </summary>
        [TestMethod]
        public void TestMethod_Combination()
        {
            Parser p = new Parser();
            {
                var r = p.parse("3+4*5");
                Assert.AreEqual(23, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("5*4+3");
                Assert.AreEqual(23, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("5*4/2");
                Assert.AreEqual(10, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("2+5*4-2");
                Assert.AreEqual(20, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
        }
        /// <summary>
        /// Test when statement includes parenthesis.
        /// </summary>
        [TestMethod]
        public void TestMethod_Paren()
        {
            Parser p = new Parser();
            {
                var r = p.parse("(3)");
                Assert.AreEqual(3, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("(-3)");
                Assert.AreEqual(-3, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("(3+4)");
                Assert.AreEqual(7, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("(3+4)*5");
                Assert.AreEqual(35, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("5*(3+4)");
                Assert.AreEqual(35, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("5*(3+4)*2");
                Assert.AreEqual(70, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("5*(3+4)/5");
                Assert.AreEqual(7, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("(5*(3+4))/5");
                Assert.AreEqual(7, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
            {
                var r = p.parse("5*((3+4)/5)");
                Assert.AreEqual(5, r.Result);
                Assert.AreEqual(true, r.Message.Equals(Messages.MSG_SUCCESS));
            }
        }
        /// <summary>
        /// Test Exception , syntax error.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SyntaxException))]
        public void TestMethod_Exception_ParenBegin()
        {
            Parser p = new Parser();

            var obj = new PrivateObject(p);
            obj.Invoke("parse_exec", "(");
        }
        /// <summary>
        /// Test Exception , syntax error.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SyntaxException))]
        public void TestMethod_Exception_ParenEnd()
        {
            Parser p = new Parser();

            var obj = new PrivateObject(p);
            obj.Invoke("parse_exec", ")");
        }
        /// <summary>
        /// Test Exception , syntax error.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SyntaxException))]
        public void TestMethod_Exception_ParenBeginEnd()
        {
            Parser p = new Parser();

            var obj = new PrivateObject(p);
            obj.Invoke("parse_exec", "()");
        }
        /// <summary>
        /// Test Exception , syntax error. 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SyntaxException))]
        public void TestMethod_Exception_Paren_ForgetEnd()
        {
            Parser p = new Parser();

            var obj = new PrivateObject(p);
            obj.Invoke("parse_exec", "(3+4");
        }
        /// <summary>
        /// Test Exception Only Integer.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SyntaxException))]
        public void TestMethod_Exception_NotInteger()
        {
            Parser p = new Parser();

            var obj = new PrivateObject(p);
            obj.Invoke("parse_exec", "1.2");
        }
        /// <summary>
        /// Test Exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SyntaxException))]
        public void TestMethod_Exception_NotToken()
        {
            Parser p = new Parser();

            var obj = new PrivateObject(p);
            obj.Invoke("parse_exec", "a");
        }
        /// <summary>
        /// Test Exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SyntaxException))]
        public void TestMethod_Exception_NotToken2()
        {
            Parser p = new Parser();

            var obj = new PrivateObject(p);
            obj.Invoke("parse_exec", "1+a+3");
        }
        [TestMethod]
        [ExpectedException(typeof(ParseOverflowException))]
        public void TestMethod_ParseOverflowExceptionMax()
        {
            Parser p = new Parser();

            var obj = new PrivateObject(p);
            obj.Invoke("parse_exec", "9223372036854775808");
        }
        [TestMethod]
        [ExpectedException(typeof(ParseOverflowException))]
        public void TestMethod_ParseOverflowExceptionMin()
        {
            Parser p = new Parser();

            var obj = new PrivateObject(p);
            obj.Invoke("parse_exec", "-9223372036854775809");
        }        

    }
}
