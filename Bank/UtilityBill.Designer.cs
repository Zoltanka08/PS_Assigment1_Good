namespace Bank
{
    partial class UtilityBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IBAN = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IBAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transfered amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // IBAN
            // 
            this.IBAN.AutoSize = true;
            this.IBAN.Location = new System.Drawing.Point(117, 42);
            this.IBAN.Name = "IBAN";
            this.IBAN.Size = new System.Drawing.Size(46, 17);
            this.IBAN.TabIndex = 4;
            this.IBAN.Text = "label5";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(142, 101);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(46, 17);
            this.Balance.TabIndex = 5;
            this.Balance.Text = "label5";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(201, 157);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(46, 17);
            this.Amount.TabIndex = 6;
            this.Amount.Text = "label5";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(117, 222);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(46, 17);
            this.Data.TabIndex = 7;
            this.Data.Text = "label5";
            // 
            // UtilityBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 297);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.IBAN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UtilityBill";
            this.Text = "UtilityBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IBAN;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label Data;
    }
}