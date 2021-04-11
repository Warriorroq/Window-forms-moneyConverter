namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.MoneyCalc = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MoneyTypeUpperText = new System.Windows.Forms.Label();
            this.startTypeMoney = new System.Windows.Forms.ComboBox();
            this.endTypeMoney = new System.Windows.Forms.ComboBox();
            this.textEndType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MoneyCalc
            // 
            this.MoneyCalc.Location = new System.Drawing.Point(26, 205);
            this.MoneyCalc.Margin = new System.Windows.Forms.Padding(0);
            this.MoneyCalc.Name = "MoneyCalc";
            this.MoneyCalc.Size = new System.Drawing.Size(144, 28);
            this.MoneyCalc.TabIndex = 0;
            this.MoneyCalc.Text = " Claculate money";
            this.MoneyCalc.UseVisualStyleBackColor = true;
            this.MoneyCalc.Click += new System.EventHandler(this.MoneyCalc_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(422, 228);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(51, 24);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MoneyTypeUpperText
            // 
            this.MoneyTypeUpperText.AutoSize = true;
            this.MoneyTypeUpperText.Location = new System.Drawing.Point(40, 21);
            this.MoneyTypeUpperText.Name = "MoneyTypeUpperText";
            this.MoneyTypeUpperText.Size = new System.Drawing.Size(42, 14);
            this.MoneyTypeUpperText.TabIndex = 3;
            this.MoneyTypeUpperText.Text = "Money";
            // 
            // startTypeMoney
            // 
            this.startTypeMoney.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.startTypeMoney.FormattingEnabled = true;
            this.startTypeMoney.Location = new System.Drawing.Point(40, 38);
            this.startTypeMoney.Name = "startTypeMoney";
            this.startTypeMoney.Size = new System.Drawing.Size(121, 22);
            this.startTypeMoney.TabIndex = 4;
            this.startTypeMoney.DropDown += new System.EventHandler(this.moneyTypes_DropDown);
            this.startTypeMoney.SelectedIndexChanged += new System.EventHandler(this.startType_SelectBox);
            // 
            // endTypeMoney
            // 
            this.endTypeMoney.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.endTypeMoney.FormattingEnabled = true;
            this.endTypeMoney.Location = new System.Drawing.Point(191, 38);
            this.endTypeMoney.Name = "endTypeMoney";
            this.endTypeMoney.Size = new System.Drawing.Size(121, 22);
            this.endTypeMoney.TabIndex = 5;
            this.endTypeMoney.DropDown += new System.EventHandler(this.moneyTypes_DropDown);
            this.endTypeMoney.SelectedIndexChanged += new System.EventHandler(this.endType_SelectBox);
            // 
            // textEndType
            // 
            this.textEndType.AutoSize = true;
            this.textEndType.Location = new System.Drawing.Point(191, 21);
            this.textEndType.Name = "textEndType";
            this.textEndType.Size = new System.Drawing.Size(84, 14);
            this.textEndType.TabIndex = 6;
            this.textEndType.Text = "convert to:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(486, 261);
            this.Controls.Add(this.textEndType);
            this.Controls.Add(this.endTypeMoney);
            this.Controls.Add(this.startTypeMoney);
            this.Controls.Add(this.MoneyTypeUpperText);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MoneyCalc);
            this.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Money";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button MoneyCalc;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label MoneyTypeUpperText;
        private System.Windows.Forms.ComboBox startTypeMoney;
        private System.Windows.Forms.ComboBox endTypeMoney;
        private System.Windows.Forms.Label textEndType;
    }
}

