namespace Bank
{
    partial class EmployeeData
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
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.CNP = new System.Windows.Forms.TextBox();
            this.Mobile = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.Street = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.Account = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(157, 36);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(232, 22);
            this.Firstname.TabIndex = 0;
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(157, 79);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(232, 22);
            this.Lastname.TabIndex = 1;
            // 
            // CNP
            // 
            this.CNP.Location = new System.Drawing.Point(157, 126);
            this.CNP.Name = "CNP";
            this.CNP.Size = new System.Drawing.Size(232, 22);
            this.CNP.TabIndex = 2;
            // 
            // Mobile
            // 
            this.Mobile.Location = new System.Drawing.Point(157, 172);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(232, 22);
            this.Mobile.TabIndex = 3;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(157, 222);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(232, 22);
            this.City.TabIndex = 4;
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(157, 269);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(232, 22);
            this.Street.TabIndex = 5;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(157, 314);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(232, 22);
            this.Number.TabIndex = 6;
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(157, 361);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(232, 22);
            this.Account.TabIndex = 7;
            // 
            // EmployeeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 408);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.CNP);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Firstname);
            this.Name = "EmployeeData";
            this.Text = "EmployeeData";
            this.Load += new System.EventHandler(this.EmployeeData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.TextBox CNP;
        private System.Windows.Forms.TextBox Mobile;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox Account;
    }
}