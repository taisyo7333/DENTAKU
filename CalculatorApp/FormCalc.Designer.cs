namespace CalculatorApp
{
    partial class FormCalcApp
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalcApp));
            this.buttonBackSpace = new System.Windows.Forms.Button();
            this.buttonClearEdit = new System.Windows.Forms.Button();
            this.buttonAllClear = new System.Windows.Forms.Button();
            this.buttonInputSign = new System.Windows.Forms.Button();
            this.buttonInput7 = new System.Windows.Forms.Button();
            this.buttonInput8 = new System.Windows.Forms.Button();
            this.buttonInput9 = new System.Windows.Forms.Button();
            this.buttonInputDiv = new System.Windows.Forms.Button();
            this.buttonInput4 = new System.Windows.Forms.Button();
            this.buttonInput5 = new System.Windows.Forms.Button();
            this.buttonInput6 = new System.Windows.Forms.Button();
            this.buttonInput1 = new System.Windows.Forms.Button();
            this.buttonInput2 = new System.Windows.Forms.Button();
            this.buttonInput3 = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonInputMul = new System.Windows.Forms.Button();
            this.buttonInputSub = new System.Windows.Forms.Button();
            this.buttonInputAdd = new System.Windows.Forms.Button();
            this.buttonInput0 = new System.Windows.Forms.Button();
            this.textBoxDisplayExpr = new System.Windows.Forms.TextBox();
            this.textBoxDispNumber = new System.Windows.Forms.TextBox();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelInputButtons = new System.Windows.Forms.Panel();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.panelOutput.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelInputButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBackSpace
            // 
            this.buttonBackSpace.Location = new System.Drawing.Point(3, 3);
            this.buttonBackSpace.Name = "buttonBackSpace";
            this.buttonBackSpace.Size = new System.Drawing.Size(54, 37);
            this.buttonBackSpace.TabIndex = 0;
            this.buttonBackSpace.Text = "←";
            this.buttonBackSpace.UseVisualStyleBackColor = true;
            this.buttonBackSpace.Click += new System.EventHandler(this.buttonBackSpace_Click);
            // 
            // buttonClearEdit
            // 
            this.buttonClearEdit.Location = new System.Drawing.Point(63, 3);
            this.buttonClearEdit.Name = "buttonClearEdit";
            this.buttonClearEdit.Size = new System.Drawing.Size(54, 37);
            this.buttonClearEdit.TabIndex = 1;
            this.buttonClearEdit.Text = "CE";
            this.buttonClearEdit.UseVisualStyleBackColor = true;
            this.buttonClearEdit.Click += new System.EventHandler(this.buttonClearEdit_Click);
            // 
            // buttonAllClear
            // 
            this.buttonAllClear.Location = new System.Drawing.Point(123, 3);
            this.buttonAllClear.Name = "buttonAllClear";
            this.buttonAllClear.Size = new System.Drawing.Size(54, 37);
            this.buttonAllClear.TabIndex = 2;
            this.buttonAllClear.Text = "C";
            this.buttonAllClear.UseVisualStyleBackColor = true;
            this.buttonAllClear.Click += new System.EventHandler(this.buttonAllClear_Click);
            // 
            // buttonInputSign
            // 
            this.buttonInputSign.Location = new System.Drawing.Point(183, 3);
            this.buttonInputSign.Name = "buttonInputSign";
            this.buttonInputSign.Size = new System.Drawing.Size(54, 37);
            this.buttonInputSign.TabIndex = 3;
            this.buttonInputSign.Text = "±";
            this.buttonInputSign.UseVisualStyleBackColor = true;
            this.buttonInputSign.Click += new System.EventHandler(this.buttonInputSign_Click);
            // 
            // buttonInput7
            // 
            this.buttonInput7.Location = new System.Drawing.Point(3, 46);
            this.buttonInput7.Name = "buttonInput7";
            this.buttonInput7.Size = new System.Drawing.Size(54, 37);
            this.buttonInput7.TabIndex = 4;
            this.buttonInput7.Text = "７";
            this.buttonInput7.UseVisualStyleBackColor = true;
            this.buttonInput7.Click += new System.EventHandler(this.buttonInput7_Click);
            // 
            // buttonInput8
            // 
            this.buttonInput8.Location = new System.Drawing.Point(63, 46);
            this.buttonInput8.Name = "buttonInput8";
            this.buttonInput8.Size = new System.Drawing.Size(54, 37);
            this.buttonInput8.TabIndex = 5;
            this.buttonInput8.Text = "８";
            this.buttonInput8.UseVisualStyleBackColor = true;
            this.buttonInput8.Click += new System.EventHandler(this.buttonInput8_Click);
            // 
            // buttonInput9
            // 
            this.buttonInput9.Location = new System.Drawing.Point(123, 46);
            this.buttonInput9.Name = "buttonInput9";
            this.buttonInput9.Size = new System.Drawing.Size(54, 37);
            this.buttonInput9.TabIndex = 6;
            this.buttonInput9.Text = "９";
            this.buttonInput9.UseVisualStyleBackColor = true;
            this.buttonInput9.Click += new System.EventHandler(this.buttonInput9_Click);
            // 
            // buttonInputDiv
            // 
            this.buttonInputDiv.Location = new System.Drawing.Point(183, 46);
            this.buttonInputDiv.Name = "buttonInputDiv";
            this.buttonInputDiv.Size = new System.Drawing.Size(54, 37);
            this.buttonInputDiv.TabIndex = 7;
            this.buttonInputDiv.Text = "／";
            this.buttonInputDiv.UseVisualStyleBackColor = true;
            this.buttonInputDiv.Click += new System.EventHandler(this.buttonInputDiv_Click);
            // 
            // buttonInput4
            // 
            this.buttonInput4.Location = new System.Drawing.Point(3, 89);
            this.buttonInput4.Name = "buttonInput4";
            this.buttonInput4.Size = new System.Drawing.Size(54, 37);
            this.buttonInput4.TabIndex = 8;
            this.buttonInput4.Text = "４";
            this.buttonInput4.UseVisualStyleBackColor = true;
            this.buttonInput4.Click += new System.EventHandler(this.buttonInput4_Click);
            // 
            // buttonInput5
            // 
            this.buttonInput5.Location = new System.Drawing.Point(63, 89);
            this.buttonInput5.Name = "buttonInput5";
            this.buttonInput5.Size = new System.Drawing.Size(54, 37);
            this.buttonInput5.TabIndex = 9;
            this.buttonInput5.Text = "５";
            this.buttonInput5.UseVisualStyleBackColor = true;
            this.buttonInput5.Click += new System.EventHandler(this.buttonInput5_Click);
            // 
            // buttonInput6
            // 
            this.buttonInput6.Location = new System.Drawing.Point(123, 89);
            this.buttonInput6.Name = "buttonInput6";
            this.buttonInput6.Size = new System.Drawing.Size(54, 37);
            this.buttonInput6.TabIndex = 10;
            this.buttonInput6.Text = "６";
            this.buttonInput6.UseVisualStyleBackColor = true;
            this.buttonInput6.Click += new System.EventHandler(this.buttonInput6_Click);
            // 
            // buttonInput1
            // 
            this.buttonInput1.Location = new System.Drawing.Point(3, 132);
            this.buttonInput1.Name = "buttonInput1";
            this.buttonInput1.Size = new System.Drawing.Size(54, 37);
            this.buttonInput1.TabIndex = 11;
            this.buttonInput1.Text = "１";
            this.buttonInput1.UseVisualStyleBackColor = true;
            this.buttonInput1.Click += new System.EventHandler(this.buttonInput1_Click);
            // 
            // buttonInput2
            // 
            this.buttonInput2.Location = new System.Drawing.Point(63, 132);
            this.buttonInput2.Name = "buttonInput2";
            this.buttonInput2.Size = new System.Drawing.Size(54, 37);
            this.buttonInput2.TabIndex = 12;
            this.buttonInput2.Text = "２";
            this.buttonInput2.UseVisualStyleBackColor = true;
            this.buttonInput2.Click += new System.EventHandler(this.buttonInput2_Click);
            // 
            // buttonInput3
            // 
            this.buttonInput3.Location = new System.Drawing.Point(123, 132);
            this.buttonInput3.Name = "buttonInput3";
            this.buttonInput3.Size = new System.Drawing.Size(54, 37);
            this.buttonInput3.TabIndex = 13;
            this.buttonInput3.Text = "３";
            this.buttonInput3.UseVisualStyleBackColor = true;
            this.buttonInput3.Click += new System.EventHandler(this.buttonInput3_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(123, 175);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(54, 37);
            this.buttonPoint.TabIndex = 14;
            this.buttonPoint.Text = "．";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Visible = false;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // buttonInputMul
            // 
            this.buttonInputMul.Location = new System.Drawing.Point(183, 89);
            this.buttonInputMul.Name = "buttonInputMul";
            this.buttonInputMul.Size = new System.Drawing.Size(54, 37);
            this.buttonInputMul.TabIndex = 15;
            this.buttonInputMul.Text = "＊";
            this.buttonInputMul.UseVisualStyleBackColor = true;
            this.buttonInputMul.Click += new System.EventHandler(this.buttonInputMul_Click);
            // 
            // buttonInputSub
            // 
            this.buttonInputSub.Location = new System.Drawing.Point(183, 132);
            this.buttonInputSub.Name = "buttonInputSub";
            this.buttonInputSub.Size = new System.Drawing.Size(54, 37);
            this.buttonInputSub.TabIndex = 16;
            this.buttonInputSub.Text = "-";
            this.buttonInputSub.UseVisualStyleBackColor = true;
            this.buttonInputSub.Click += new System.EventHandler(this.buttonInputSub_Click);
            // 
            // buttonInputAdd
            // 
            this.buttonInputAdd.Location = new System.Drawing.Point(183, 175);
            this.buttonInputAdd.Name = "buttonInputAdd";
            this.buttonInputAdd.Size = new System.Drawing.Size(54, 37);
            this.buttonInputAdd.TabIndex = 17;
            this.buttonInputAdd.Text = "+";
            this.buttonInputAdd.UseVisualStyleBackColor = true;
            this.buttonInputAdd.Click += new System.EventHandler(this.buttonInputAdd_Click);
            // 
            // buttonInput0
            // 
            this.buttonInput0.Location = new System.Drawing.Point(3, 175);
            this.buttonInput0.Name = "buttonInput0";
            this.buttonInput0.Size = new System.Drawing.Size(114, 37);
            this.buttonInput0.TabIndex = 18;
            this.buttonInput0.Text = "0";
            this.buttonInput0.UseVisualStyleBackColor = true;
            this.buttonInput0.Click += new System.EventHandler(this.buttonInput0_Click);
            // 
            // textBoxDisplayExpr
            // 
            this.textBoxDisplayExpr.Enabled = false;
            this.textBoxDisplayExpr.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDisplayExpr.Location = new System.Drawing.Point(3, 4);
            this.textBoxDisplayExpr.Name = "textBoxDisplayExpr";
            this.textBoxDisplayExpr.ReadOnly = true;
            this.textBoxDisplayExpr.Size = new System.Drawing.Size(288, 27);
            this.textBoxDisplayExpr.TabIndex = 19;
            this.textBoxDisplayExpr.TabStop = false;
            this.textBoxDisplayExpr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDisplayExpr.WordWrap = false;
            // 
            // textBoxDispNumber
            // 
            this.textBoxDispNumber.Enabled = false;
            this.textBoxDispNumber.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDispNumber.Location = new System.Drawing.Point(3, 34);
            this.textBoxDispNumber.Name = "textBoxDispNumber";
            this.textBoxDispNumber.ReadOnly = true;
            this.textBoxDispNumber.Size = new System.Drawing.Size(288, 41);
            this.textBoxDispNumber.TabIndex = 20;
            this.textBoxDispNumber.TabStop = false;
            this.textBoxDispNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelOutput
            // 
            this.panelOutput.Controls.Add(this.textBoxDisplayExpr);
            this.panelOutput.Controls.Add(this.textBoxDispNumber);
            this.panelOutput.Location = new System.Drawing.Point(3, 3);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(294, 80);
            this.panelOutput.TabIndex = 21;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.22222F));
            this.tableLayoutPanel.Controls.Add(this.panelInputButtons, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.panelOutput, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.85185F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.14815F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(305, 324);
            this.tableLayoutPanel.TabIndex = 22;
            // 
            // panelInputButtons
            // 
            this.panelInputButtons.Controls.Add(this.buttonCalc);
            this.panelInputButtons.Controls.Add(this.buttonBackSpace);
            this.panelInputButtons.Controls.Add(this.buttonClearEdit);
            this.panelInputButtons.Controls.Add(this.buttonInput0);
            this.panelInputButtons.Controls.Add(this.buttonAllClear);
            this.panelInputButtons.Controls.Add(this.buttonInputAdd);
            this.panelInputButtons.Controls.Add(this.buttonInputSign);
            this.panelInputButtons.Controls.Add(this.buttonInputSub);
            this.panelInputButtons.Controls.Add(this.buttonInput7);
            this.panelInputButtons.Controls.Add(this.buttonInputMul);
            this.panelInputButtons.Controls.Add(this.buttonInput8);
            this.panelInputButtons.Controls.Add(this.buttonPoint);
            this.panelInputButtons.Controls.Add(this.buttonInput9);
            this.panelInputButtons.Controls.Add(this.buttonInput3);
            this.panelInputButtons.Controls.Add(this.buttonInputDiv);
            this.panelInputButtons.Controls.Add(this.buttonInput2);
            this.panelInputButtons.Controls.Add(this.buttonInput4);
            this.panelInputButtons.Controls.Add(this.buttonInput1);
            this.panelInputButtons.Controls.Add(this.buttonInput5);
            this.panelInputButtons.Controls.Add(this.buttonInput6);
            this.panelInputButtons.Location = new System.Drawing.Point(3, 89);
            this.panelInputButtons.Name = "panelInputButtons";
            this.panelInputButtons.Size = new System.Drawing.Size(297, 220);
            this.panelInputButtons.TabIndex = 22;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(243, 132);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(54, 80);
            this.buttonCalc.TabIndex = 19;
            this.buttonCalc.Text = "＝";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // FormCalcApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 344);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(343, 391);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(343, 391);
            this.Name = "FormCalcApp";
            this.Text = "DENTAKU.";
            this.Load += new System.EventHandler(this.FormCalcApp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCalcApp_KeyDown);
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelInputButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackSpace;
        private System.Windows.Forms.Button buttonClearEdit;
        private System.Windows.Forms.Button buttonAllClear;
        private System.Windows.Forms.Button buttonInputSign;
        private System.Windows.Forms.Button buttonInput7;
        private System.Windows.Forms.Button buttonInput8;
        private System.Windows.Forms.Button buttonInput9;
        private System.Windows.Forms.Button buttonInputDiv;
        private System.Windows.Forms.Button buttonInput4;
        private System.Windows.Forms.Button buttonInput5;
        private System.Windows.Forms.Button buttonInput6;
        private System.Windows.Forms.Button buttonInput1;
        private System.Windows.Forms.Button buttonInput2;
        private System.Windows.Forms.Button buttonInput3;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonInputMul;
        private System.Windows.Forms.Button buttonInputSub;
        private System.Windows.Forms.Button buttonInputAdd;
        private System.Windows.Forms.Button buttonInput0;
        private System.Windows.Forms.TextBox textBoxDisplayExpr;
        private System.Windows.Forms.TextBox textBoxDispNumber;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelInputButtons;
        private System.Windows.Forms.Button buttonCalc;
    }
}

