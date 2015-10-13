using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationServices
{
    public class CalcServicesApi
    {
        #region FIELD
        const string INIT_STATEMENT = "";
        const string INIT_EDIT_NUMBER = "0";

        string statement = INIT_STATEMENT;
        string editNumber = INIT_EDIT_NUMBER;

        Parser.Parser parser = new Parser.Parser();
        Alphabets alphabets = new Alphabets();
        #endregion

        #region PROPERTY

        public string STATEMENT
        {
            get { return statement; }
        }
        public string EDIT
        {
            get { return editNumber; }
        }

        #endregion

        #region METHODS

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num">'0'-'9'</param>
        /// <returns></returns>
        public void inputNum(char num)
        {
            if(editNumber.Equals(INIT_EDIT_NUMBER))
            {
                editNumber = num.ToString();
            }
            else
            {
                editNumber += num.ToString();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="op"></param>
        public void inputOperator(char op)
        {
            statement += editNumber;
            statement += op.ToString();

            ClearEditNumber();

        }
        /// <summary>
        /// 
        /// </summary>
        public void inputEqual()
        {
            statement += editNumber;

            var r = parser.parse(statement);
            editNumber = r.Result.ToString();
            ClearStatement();
        }
        /// <summary>
        /// 
        /// </summary>
        public void inputReverseSign()
        {
            var edit = long.Parse(editNumber);
            edit = -1 * edit;
            editNumber = edit.ToString();
        }
        /// <summary>
        /// Delete last input number.
        /// </summary>
        public void inputBackSpace()
        {
            if(!editNumber.Equals(INIT_EDIT_NUMBER))
            {
                if (editNumber.Length == 1)
                {
                    ClearEditNumber();
                }
                else
                {
                    // Delete last character
                    editNumber = editNumber.Remove(editNumber.Length - 1);
                }
            }
        }
        /// <summary>
        /// Clear edit area.
        /// </summary>
        public void inputClearEdit()
        {
            ClearEditNumber();
        }
        /// <summary>
        /// Clear edit area and statement area.
        /// </summary>
        public void inputClearAll()
        {
            ClearStatement();
            ClearEditNumber();
        }
        /// <summary>
        /// Check if input value is alphabet for parser  or not.
        /// </summary>
        /// <param name="input">input value</param>
        /// <returns>true : input value is alphabet , false : input value is not alphabet.</returns>
        public bool isAlphabet(char input)
        {
            return alphabets.isAlphabet(input);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        public void inputAlphabet(char input)
        {
            
            if(alphabets.isOperator(input))
            {
                this.inputOperator(input);
            }
            else if(alphabets.isNumber(input))
            {
                this.inputNum(input);
            }
            else if(alphabets.isEqual(input))
            {
                this.inputEqual();
            }
            else if (alphabets.isMinusSign(input))
            {
                // Not supported.
            }
            else if (alphabets.isParenthesis(input))
            {
                // Not supported.
            }
            else if(alphabets.isBackSpace(input))
            {
                this.inputBackSpace();
            }
            
            

        }

        /// <summary>
        /// Clear statement area's string.
        /// </summary>
        private void ClearStatement()
        {
            statement = INIT_STATEMENT;
        }
        /// <summary>
        /// Clear editing area's string.
        /// </summary>
        private void ClearEditNumber()
        {
            editNumber = INIT_EDIT_NUMBER;
        }
        #endregion
    }
}
