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
            this.SuspendLayout();
            // 
            // MoneyCalc
            // 
            this.MoneyCalc.Location = new System.Drawing.Point(42, 199);
            this.MoneyCalc.Name = "MoneyCalc";
            this.MoneyCalc.Size = new System.Drawing.Size(126, 29);
            this.MoneyCalc.TabIndex = 0;
            this.MoneyCalc.Text = "Calculate money";
            this.MoneyCalc.UseVisualStyleBackColor = true;
            this.MoneyCalc.Click += new System.EventHandler(this.MoneyCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.MoneyCalc);
            this.Name = "Form1";
            this.Text = "Money";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button MoneyCalc;
    }
}

