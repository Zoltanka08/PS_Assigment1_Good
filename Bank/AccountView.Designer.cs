namespace Bank
{
    partial class AccountView
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
            this.IBAN = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.TextBox();
            this.Startdate = new System.Windows.Forms.TextBox();
            this.UpdateButtton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IBAN
            // 
            this.IBAN.Location = new System.Drawing.Point(128, 42);
            this.IBAN.Name = "IBAN";
            this.IBAN.Size = new System.Drawing.Size(249, 22);
            this.IBAN.TabIndex = 0;
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(128, 92);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(249, 22);
            this.Balance.TabIndex = 1;
            // 
            // Startdate
            // 
            this.Startdate.Location = new System.Drawing.Point(128, 140);
            this.Startdate.Name = "Startdate";
            this.Startdate.Size = new System.Drawing.Size(249, 22);
            this.Startdate.TabIndex = 2;
            // 
            // UpdateButtton
            // 
            this.UpdateButtton.Location = new System.Drawing.Point(241, 306);
            this.UpdateButtton.Name = "UpdateButtton";
            this.UpdateButtton.Size = new System.Drawing.Size(101, 31);
            this.UpdateButtton.TabIndex = 4;
            this.UpdateButtton.Text = "Update";
            this.UpdateButtton.UseVisualStyleBackColor = true;
            this.UpdateButtton.Click += new System.EventHandler(this.UpdateButtton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(71, 306);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 31);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(208, 199);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(46, 17);
            this.Type.TabIndex = 6;
            this.Type.Text = "label1";
            this.Type.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "IBAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Startdate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type";
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 380);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.UpdateButtton);
            this.Controls.Add(this.Startdate);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.IBAN);
            this.Name = "AccountView";
            this.Text = "AccountData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IBAN;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.TextBox Startdate;
        private System.Windows.Forms.Button UpdateButtton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}