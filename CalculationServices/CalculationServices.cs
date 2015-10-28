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
        Token token = new Token();
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
        /// behaviour when input numeric character.
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
        /// behaviour when input operation character
        /// </summary>
        /// <param name="op"></param>
        public void inputOperator(char op)
        {
            statement += editNumber;
            statement += op.ToString();

            ClearEditNumber();

        }
        /// <summary>
        /// behaviour when input '=' . 
        /// </summary>
        public string inputEqual()
        {
            statement += editNumber;

            var r = parser.parse(statement);
            editNumber = r.Result.ToString();
            ClearStatement();

            if (r.Message.Any())
                return r.Message;
            else
                return null;
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
        /// Check if input value is token for parser  or not.
        /// </summary>
        /// <param name="input">input value</param>
        /// <returns>true : input value is token , false : input value is not token.</returns>
        public bool isToken(char input)
        {
            return token.isToken(input);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        public void inputCharacter(char input)
        {
            if(token.isOperator(input))
            {
                this.inputOperator(input);
            }
            else if(token.isNumber(input))
            {
                this.inputNum(input);
            }
            else if (token.isMinusSign(input))
            {
                // Not supported.
            }
            else if (token.isParenthesis(input))
            {
                // Not supported.
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
