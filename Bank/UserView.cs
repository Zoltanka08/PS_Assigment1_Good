using BankBLL;
using BankDAL.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class UserView : Form
    {
        private AdminBL adminBL = new AdminBL();

        private UserData user;
        public UserView(UserData user)
        {
            InitializeComponent();
            this.user = user;
            InitializeFields();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InitializeFields()
        {
            if(user != null)
            {
                this.Username.Text = user.Username;
                this.Firstname.Text = user.Firstname;
                this.Lastname.Text = user.Lastname;
                this.Mobile.Text = user.Mobile;
                this.Mail.Text = user.Mail;
                this.PassLabel.Hide();
                this.Password.Hide();
            }
        }

        private void Update_Insert_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if(user == null)
            {
                UserData userToInsert = new UserData()
                {
                    Firstname = this.Firstname.Text,
                    Lastname = this.Lastname.Text,
                    Mail = this.Mail.Text,
                    Mobile = this.Mobile.Text,
                    Password = this.Password.Text,
                    RoleId = "2",
                    Username = this.Username.Text
                };

                isValid = adminBL.InsertUser(userToInsert);
            }
            else
            {
                UserData userToUpdate = new UserData()
                {
                    Id = user.Id,
                    Firstname = this.Firstname.Text,
                    Lastname = this.Lastname.Text,
                    Mail = this.Mail.Text,
                    Mobile = this.Mobile.Text,
                    Password = this.user.Password,
                    RoleId = user.RoleId,
                    Username = this.Username.Text
                };
                isValid = adminBL.UpdateUser(userToUpdate);
            }

            if(isValid)
            {
                MessageBox.Show("Success!","Insert/Update done!",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Error!", "Insert/Update failed!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
