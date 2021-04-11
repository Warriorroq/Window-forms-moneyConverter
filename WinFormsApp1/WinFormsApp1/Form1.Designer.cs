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
            this.SuspendLayout();
            // 
            // MoneyCalc
            // 
            this.MoneyCalc.Location = new System.Drawing.Point(9, 9);
            this.MoneyCalc.Margin = new System.Windows.Forms.Padding(0);
            this.MoneyCalc.Name = "MoneyCalc";
            this.MoneyCalc.Size = new System.Drawing.Size(137, 28);
            this.MoneyCalc.TabIndex = 0;
            this.MoneyCalc.Text = "Calculate money";
            this.MoneyCalc.UseVisualStyleBackColor = true;
            this.MoneyCalc.Click += new System.EventHandler(this.MoneyCalc_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(624, 228);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(51, 24);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MoneyCalc);
            this.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Money";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button MoneyCalc;
        private System.Windows.Forms.Button ExitBtn;
    }
}

