using BankBLL;
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
    public partial class LogIn : Form
    {
        private ValidateCredentials validator;
        private UserBL userBL = new UserBL();
        public LogIn()
        {
            validator = new ValidateCredentials();
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = this.Username.Text;
            string password = this.Password.Text;
            string role = this.validator.GetRole(username, password);

            if (role.Equals("admin"))
            {
                //this.Hide();
                Admin adminView = new Admin();
                adminView.Show();
            }
            else if (role.Equals("employee"))
            {
                //this.Hide();
                Employee employeeView = new Employee(userBL.GetUserByUsername(username));
                employeeView.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");   
            }
        }
    }
}
