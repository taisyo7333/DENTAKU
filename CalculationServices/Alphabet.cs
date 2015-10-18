using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms; // Keys
namespace CalculationServices
{
    public class Alphabets
    {
        /// <summary>
        /// Check if input character is able to accept for parser.
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns>true :acceptable , false :not acceptable</returns>
        public bool isAlphabet(char alphabet)
        {
            if (isNumber(alphabet))
                return true;
            if (isMinusSign(alphabet))
                return true;
            if (isOperator(alphabet))
                return true;
            if (isParenthesis(alphabet))
                return true;
            return false;
        }
        /// <summary>
        /// Check if input character is operator's sign.
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        public bool isOperator(char alphabet)
        {
            switch (alphabet)
            {
                case Operator.ADD:
                case Operator.SUB:
                case Operator.MUL:
                case Operator.DIV:
                    return true;
                default:
                    return false;
            }
        }
        /// <summary>
        /// Check if input character is parenthesis.
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns>true:parenthesis , false:not parenthesis</returns>
        public bool isParenthesis(char alphabet)
        {
            switch (alphabet)
            {
                case Parenthesis.BEGIN:
                case Parenthesis.END:
                    return true;
                default:
                    return false;
            }
        }
        /// <summary>
        /// Check if argument's value is number or not.
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns>true : number , false : not number</returns>
        public bool isNumber(char alphabet)
        {
            switch (alphabet)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return true;
                default:
                    return false;
            }
        }
        /// <summary>
        /// Check if input character is minus sign or not.
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns>true : minus sign , false : not minus sign</returns>
        public bool isMinusSign(char alphabet)
        {
            if (alphabet == Num.MINUS)
                return true;
            else
                return false;

        }
        /// <summary>
        /// Check if input character is equal sign or not.
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        public bool isEqual(char alphabet)
        {
            if (alphabet == EQUAL)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Check if input character is 'backspace' key or not.
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        /// <remarks>backspace key is not alphabet.</remarks>
        public bool isBackSpace(char alphabet)
        {
            if (alphabet == (char)Keys.Back)
                return true;
            else
                return false;
        }
        
        /// <summary>
        /// Operator's sign.
        /// </summary>
        public class Operator
        {
            public const char ADD = '+';    // Adding
            public const char SUB = '-';    // Subtraction
            public const char MUL = '*';    // Multi
            public const char DIV = '/';    // Division

        }
        /// <summary>
        /// Express numbers.
        /// </summary>
        public class Num
        {

            public const char MINUS = '-';
            public const char ZERO = '0';
            public const char ONE = '1';
            public const char TWO = '2';
            public const char THREE = '3';
            public const char FOUR = '4';
            public const char FIVE = '5';
            public const char SIX = '6';
            public const char SEVEN = '7';
            public const char EIGHT= '8';
            public const char NINE = '9';
        }
        /// <summary>
        /// Parenthesis '(' , ')'
        /// </summary>
        public class Parenthesis
        {
            public const char BEGIN = '(';
            public const char END = ')';
        }
        /// <summary>
        /// Express '='
        /// </summary>
        public const char EQUAL = '=';

    }
}
