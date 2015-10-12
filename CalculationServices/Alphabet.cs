using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationServices
{
    public class Alphabets
    {
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
        public bool isMinusSign(char alphabet)
        {
            if (alphabet == Num.MINUS)
                return true;
            else
                return false;

        }
        

        public class Operator
        {
            public const char ADD = '+';    // Adding
            public const char SUB = '-';    // Subtraction
            public const char MUL = '*';    // Multi
            public const char DIV = '/';    // Division

        }
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
        public class Parenthesis
        {
            public const char BEGIN = '(';
            public const char END = ')';
        }
        public const char EQUAL = '=';

    }
}
