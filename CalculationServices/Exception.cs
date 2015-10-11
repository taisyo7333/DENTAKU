using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationServices.ParserExcepton
{
    /// <summary>
    /// Express syntax error.
    /// </summary>
    public class SyntaxException : System.Exception
    {
        #region FIELDS

        private int index = 0;

        #endregion

        #region PROPERTY

        public int INDEX
        {
            get { return index; }
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Default constructor
        /// </summary>
        public SyntaxException()
        {
        }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="message">Initializes a new instance of the SyntaxException class with a specified error message.</param>
        /// <param name="index">Syntax Error point.</param>
        public SyntaxException(string message, int index)
            : base(message)
        {
            this.index = index;
        }
        #endregion
    }
    /// <summary>
    /// Express overflow integer's limit when run parse.
    /// </summary>
    public class ParseOverflowException : System.OverflowException
    {
        #region FIELDS
        private int index = 0;
        private string number = null;
        #endregion

        #region PROPERTY
        public int INDEX
        {
            get { return index; }
        }
        public string EXCEPTION_DATA
        {
            get { return number; }
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Default constructor
        /// </summary>
        public ParseOverflowException()
        {
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message"></param>
        /// <param name="index">the point threw exception .</param>
        /// <param name="num">source data threw exception when run parse method.</param>
        public ParseOverflowException(string message, int index, string num)
            : base(message)
        {
            this.index = index;
            this.number = num;
        }
        #endregion
    }

}
