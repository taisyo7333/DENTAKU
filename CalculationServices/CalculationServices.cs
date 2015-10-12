using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationServices
{
    public class CalcServicesApi
    {
        const string INIT_STATEMENT = "";
        const string INIT_EDIT_NUMBER = "0";

        string statement = INIT_STATEMENT;
        string editNumber = INIT_EDIT_NUMBER;

        Parser.Parser parser = new Parser.Parser();

        
        public string STATEMENT
        {
            get { return statement; }
        }
        public string EDIT
        {
            get { return editNumber; }
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public void inputNum(int num)
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
        /// <returns></returns>
        public void inputOperator(char op)
        {
            statement += editNumber;
            statement += op.ToString();

            ClearEditNumber();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// <returns></returns>
        public void inputReverseSign()
        {
            var edit = long.Parse(editNumber);
            edit = -1 * edit;
            editNumber = edit.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void inputBackSpace()
        {
            if( editNumber.Any())
            {
                // delete last alphabet
                editNumber.Remove(editNumber.Length - 1);
            }
            if (!editNumber.Any())
            {
                ClearEditNumber();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void inputClearEdit()
        {
            ClearEditNumber();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void inputClearAll()
        {
            ClearStatement();
            ClearEditNumber();
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

    }
}
