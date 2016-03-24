namespace Bank
{
    partial class UserView
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
            this.Username = new System.Windows.Forms.TextBox();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.Mobile = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.Update_Insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(141, 35);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(238, 22);
            this.Username.TabIndex = 0;
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(141, 86);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(238, 22);
            this.Firstname.TabIndex = 1;
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(141, 138);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(238, 22);
            this.Lastname.TabIndex = 2;
            // 
            // Mobile
            // 
            this.Mobile.Location = new System.Drawing.Point(141, 190);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(238, 22);
            this.Mobile.TabIndex = 3;
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(141, 242);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(238, 22);
            this.Mail.TabIndex = 4;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(69, 339);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(112, 33);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // Update_Insert
            // 
            this.Update_Insert.Location = new System.Drawing.Point(226, 339);
            this.Update_Insert.Name = "Update_Insert";
            this.Update_Insert.Size = new System.Drawing.Size(119, 33);
            this.Update_Insert.TabIndex = 6;
            this.Update_Insert.Text = "Update/Insert";
            this.Update_Insert.UseVisualStyleBackColor = true;
            this.Update_Insert.Click += new System.EventHandler(this.Update_Insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mail";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(141, 292);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(238, 22);
            this.Password.TabIndex = 12;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(25, 297);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(69, 17);
            this.PassLabel.TabIndex = 13;
            this.PassLabel.Text = "Password";
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 384);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update_Insert);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.Username);
            this.Name = "UserView";
            this.Text = "User Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.TextBox Mobile;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button Update_Insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label PassLabel;
    }
}