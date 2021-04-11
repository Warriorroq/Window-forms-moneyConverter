
namespace WinFormsApp1
{
    partial class MoneyCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.moneyName = new System.Windows.Forms.TextBox();
            this.amountPreOne = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.newMoneyName = new System.Windows.Forms.Label();
            this.pricePerOnePaperText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Location = new System.Drawing.Point(12, 104);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(101, 24);
            this.mainMenuBtn.TabIndex = 0;
            this.mainMenuBtn.Text = "main menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // moneyName
            // 
            this.moneyName.Location = new System.Drawing.Point(13, 37);
            this.moneyName.Name = "moneyName";
            this.moneyName.Size = new System.Drawing.Size(100, 22);
            this.moneyName.TabIndex = 1;
            // 
            // amountPreOne
            // 
            this.amountPreOne.Location = new System.Drawing.Point(147, 37);
            this.amountPreOne.Name = "amountPreOne";
            this.amountPreOne.Size = new System.Drawing.Size(100, 22);
            this.amountPreOne.TabIndex = 2;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(154, 104);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(93, 24);
            this.CreateBtn.TabIndex = 3;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // newMoneyName
            // 
            this.newMoneyName.AutoSize = true;
            this.newMoneyName.Location = new System.Drawing.Point(12, 16);
            this.newMoneyName.Name = "newMoneyName";
            this.newMoneyName.Size = new System.Drawing.Size(77, 14);
            this.newMoneyName.TabIndex = 4;
            this.newMoneyName.Text = "New money:";
            // 
            // pricePerOnePaperText
            // 
            this.pricePerOnePaperText.AutoSize = true;
            this.pricePerOnePaperText.Location = new System.Drawing.Point(147, 16);
            this.pricePerOnePaperText.Name = "pricePerOnePaperText";
            this.pricePerOnePaperText.Size = new System.Drawing.Size(105, 14);
            this.pricePerOnePaperText.TabIndex = 5;
            this.pricePerOnePaperText.Text = "price per one ";
            // 
            // MoneyCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(259, 141);
            this.Controls.Add(this.pricePerOnePaperText);
            this.Controls.Add(this.newMoneyName);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.amountPreOne);
            this.Controls.Add(this.moneyName);
            this.Controls.Add(this.mainMenuBtn);
            this.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "MoneyCreator";
            this.Text = "MoneyCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.TextBox moneyName;
        private System.Windows.Forms.TextBox amountPreOne;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label newMoneyName;
        private System.Windows.Forms.Label pricePerOnePaperText;
    }
}