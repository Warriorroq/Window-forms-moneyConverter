namespace WinFormsApp1
{
    partial class MainForm
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
            this.moneyAmount = new System.Windows.Forms.TextBox();
            this.MoneyCount = new System.Windows.Forms.Label();
            this.AddMoney = new System.Windows.Forms.Button();
            this.globalBankBtn = new System.Windows.Forms.Button();
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
            // moneyAmount
            // 
            this.moneyAmount.Location = new System.Drawing.Point(40, 87);
            this.moneyAmount.Name = "moneyAmount";
            this.moneyAmount.Size = new System.Drawing.Size(100, 22);
            this.moneyAmount.TabIndex = 7;
            this.moneyAmount.Text = "1";
            // 
            // MoneyCount
            // 
            this.MoneyCount.AutoSize = true;
            this.MoneyCount.Location = new System.Drawing.Point(40, 70);
            this.MoneyCount.Name = "MoneyCount";
            this.MoneyCount.Size = new System.Drawing.Size(49, 14);
            this.MoneyCount.TabIndex = 8;
            this.MoneyCount.Text = "Amount";
            // 
            // AddMoney
            // 
            this.AddMoney.Location = new System.Drawing.Point(199, 205);
            this.AddMoney.Name = "AddMoney";
            this.AddMoney.Size = new System.Drawing.Size(130, 28);
            this.AddMoney.TabIndex = 9;
            this.AddMoney.Text = "Add new money";
            this.AddMoney.UseVisualStyleBackColor = true;
            this.AddMoney.Click += new System.EventHandler(this.AddMoney_Click);
            // 
            // globalBankBtn
            // 
            this.globalBankBtn.Location = new System.Drawing.Point(26, 176);
            this.globalBankBtn.Name = "globalBankBtn";
            this.globalBankBtn.Size = new System.Drawing.Size(303, 23);
            this.globalBankBtn.TabIndex = 10;
            this.globalBankBtn.Text = "Get global bank money";
            this.globalBankBtn.UseVisualStyleBackColor = true;
            this.globalBankBtn.Click += new System.EventHandler(this.globalBankBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(486, 261);
            this.Controls.Add(this.globalBankBtn);
            this.Controls.Add(this.AddMoney);
            this.Controls.Add(this.MoneyCount);
            this.Controls.Add(this.moneyAmount);
            this.Controls.Add(this.textEndType);
            this.Controls.Add(this.endTypeMoney);
            this.Controls.Add(this.startTypeMoney);
            this.Controls.Add(this.MoneyTypeUpperText);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MoneyCalc);
            this.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
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
        private System.Windows.Forms.TextBox moneyAmount;
        private System.Windows.Forms.Label MoneyCount;
        private System.Windows.Forms.Button AddMoney;
        private System.Windows.Forms.Button globalBankBtn;
    }
}

