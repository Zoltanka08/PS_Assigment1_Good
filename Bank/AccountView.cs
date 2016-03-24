using BankBLL;
using BankDAL;
using BankDAL.DataMapper;
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
    public partial class AccountView : Form
    {
        private AccountData account;
        private TypeBL typeBL = new TypeBL();
        private AccountBL accountBL = new AccountBL();
        public AccountView(AccountData account)
        {
            InitializeComponent();
            this.account = account;
            this.IBAN.Text = account.IBAN;
            this.Balance.Text = account.Balance.ToString();
            this.Startdate.Text = account.Startdate.ToString();
            this.Type.Text = typeBL.GetTypeById(account.TyepId).Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateButtton_Click(object sender, EventArgs e)
        {
            try
            {
                this.account.Balance = Convert.ToDouble(this.Balance.Text);
            }
            catch(Exception)
            {
                MessageBox.Show(
                    "Error", "Balance format error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1
                    );
            }
            this.account.IBAN = this.IBAN.Text;
            try
            {
                this.account.Startdate = DateTime.Parse(this.Startdate.Text);
            }
            catch(Exception)
            {
                MessageBox.Show(
                    "Error", "Startdate format error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1
                    );
            }

            bool valid = accountBL.UpdateAccount(account);

            if(valid)
            {
                MessageBox.Show(
                    "Success", "Account data has been updated!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                    );
            }
            else
            {
                MessageBox.Show(
                    "Error", "Update failed!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1
                    );
            }
        }
    }
}
