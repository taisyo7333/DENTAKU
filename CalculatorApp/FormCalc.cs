using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CalculationServices;

namespace CalculatorApp
{
    /// <summary>
    /// Calculation App's form.(GUI)
    /// </summary>
    public partial class FormCalcApp : Form
    {
        private CalcServicesApi api = new CalcServicesApi();
        /// <summary>
        /// Constructor.
        /// </summary>
        public FormCalcApp()
        {
            InitializeComponent();

           this.KeyPreview = true;
           this.KeyPress +=
               new KeyPressEventHandler(FormCalcApp_KeyPress);
        }
        /// <summary>
        /// Load this form event hanlder 
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void FormCalcApp_Load(object sender, EventArgs e)
        {
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// 0(zero) button clicked event handler.
        /// Input 0.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInput0_Click(object sender, EventArgs e)
        {
            api.inputNum('0');
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// 1(One) button clicked event handler.
        /// Input 1.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInput1_Click(object sender, EventArgs e)
        {
            api.inputNum('1');
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// 2(Two) button clicked event handler.
        /// Input 2.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInput2_Click(object sender, EventArgs e)
        {
            api.inputNum('2');
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// 3(Three) button clicked event handler.
        /// Input 3.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInput3_Click(object sender, EventArgs e)
        {
            api.inputNum('3');
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// 4(Four) button clicked event handler.
        /// Input 4.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInput4_Click(object sender, EventArgs e)
        {
            api.inputNum('4');
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// 5(Five) button clicked event handler.
        /// Input 5.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInput5_Click(object sender, EventArgs e)
        {
            api.inputNum('5');
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// 6(Six) button clicked event handler.
        /// Input 6.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInput6_Click(object sender, EventArgs e)
        {
            api.inputNum('6');
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// 7(Seven) button clicked event handler.
        /// Input 7.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInput7_Click(object sender, EventArgs e)
        {
            api.inputNum('7');
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// 8(Eight) button clicked event handler.
        /// Input 8.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInput8_Click(object sender, EventArgs e)
        {
            api.inputNum('8');
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// 9(Nine) button clicked event handler.
        /// Input 9.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInput9_Click(object sender, EventArgs e)
        {
            api.inputNum('9');
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// ←(BackSpace) button clicked event handler.
        /// Remove the number last input.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            api.inputBackSpace();
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// CE(ClearEdit) button clicked event handler.
        /// Clear edit area's numbers and then set 0.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonClearEdit_Click(object sender, EventArgs e)
        {
            api.inputClearEdit();
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// C(Clear) button clicked event handler.
        /// Clear edit area's numbers and expression , and then set 0 on edit area .
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonAllClear_Click(object sender, EventArgs e)
        {
            api.inputClearAll();
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// ±(Plus,Minus sign) button clicked event handler.
        /// Modify minus number or plus number , but '+' is not showed.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInputSign_Click(object sender, EventArgs e)
        {
            api.inputReverseSign();
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// /(Division) button clicked event handler.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInputDiv_Click(object sender, EventArgs e)
        {
            api.inputOperator('/');
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// *(Multiplication) button clicked event handler.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInputMul_Click(object sender, EventArgs e)
        {
            api.inputOperator('*');
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// *(Multiplication) button clicked event handler.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInputSub_Click(object sender, EventArgs e)
        {
            api.inputOperator('-');
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// +(Adding) button clicked event handler.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonInputAdd_Click(object sender, EventArgs e)
        {
            api.inputOperator('+');
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// =(Equal) button clicked event handler.
        /// Start calculation expression what user input , and then display result.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            var msg = api.inputEqual();
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;

            ShowMessageBox(msg);
        }
        /// <summary>
        /// .(Point) button clicked event handler.
        /// '.' is separator between integer part and fractional part.
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e">NotUsed</param>
        private void buttonPoint_Click(object sender, EventArgs e)
        {
            // Not Supported
        }
        /// <summary>
        /// KeyPress Event Handler
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e"></param>
        /// <see cref="https://msdn.microsoft.com/ja-jp/library/ms171538(v=vs.110).aspx"/>
        /// <remarks>Delete key pressing will not call this method.</remarks>
        private void FormCalcApp_KeyPress(object sender, KeyPressEventArgs e)
        {
            string msg = null;
            switch(e.KeyChar)
            {
                case (char)Keys.Escape: // ESC key
                    api.inputClearAll();
                    break;
                case (char)Keys.Back:
                    api.inputBackSpace();   // Backspace
                    break;
                case '=':
                    msg = api.inputEqual();
                    break;
                default:
                    api.inputAlphabet(e.KeyChar);
                    break;
            }
          
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;

            ShowMessageBox(msg);

            e.Handled = true;
        }
        /// <summary>
        /// KeyDown Event Handler
        /// </summary>
        /// <param name="sender">NotUsed</param>
        /// <param name="e"></param>
        private void FormCalcApp_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete: // DELETE key
                    api.inputClearEdit();
                    break;
            }
            textBoxDispNumber.Text = api.EDIT;
            textBoxDisplayExpr.Text = api.STATEMENT;
        }
        /// <summary>
        /// Show MessageBox When error occurs.
        /// </summary>
        /// <param name="msg">message that is expected to show.</param>
        private void ShowMessageBox(string msg)
        {
            if (msg != null)
            {
                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
