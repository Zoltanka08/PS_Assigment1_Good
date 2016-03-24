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
    public partial class EmployeeData : Form
    {
        private ClientData client;
        private UserData user;
        private EmployeeBL employeeBL = new EmployeeBL();
        private AccountBL accountBL = new AccountBL();
        private UserActionBL userActionBL = new UserActionBL();
        public EmployeeData(ClientData client, UserData user)
        {
            InitializeComponent();
            InitializeFields(client);
            this.user = user;
        }

        private void EmployeeData_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (this.client == null)
            {
                ClientData clientToInsert = new ClientData()
                {
                    Firstnme = this.Firstname.Text,
                    Lastname = this.Lastname.Text,
                    CNP = this.CNP.Text,
                    Mobile = this.Mobile.Text,
                    Number = this.Number.Text,
                    City = this.City.Text,
                    Street = this.Street.Text
                };

                valid = employeeBL.InserClient(clientToInsert);

                if (valid)
                {
                    ClientData newUser = employeeBL.GetClientByCNP(clientToInsert.CNP);

                    AccountData account = new AccountData()
                    {
                        Balance = 0.0,
                        IBAN = this.Account.Text,
                        Startdate = DateTime.Now,
                        TyepId = 1,
                        ClientId = newUser.Id
                    };

                    valid = accountBL.InsertAccount(account);

                    if(!valid)
                    {
                        employeeBL.DeleteClient(newUser.Id);
                    }
                }
            }
            else
            {
                ClientData clientToUpdate = new ClientData()
                {
                    Id = client.Id,
                    Firstnme = this.Firstname.Text,
                    Lastname = this.Lastname.Text,
                    CNP = this.CNP.Text,
                    Mobile = this.Mobile.Text,
                    Number = this.Number.Text,
                    City = this.City.Text,
                    Street = this.Street.Text
                };

                AccountData account = accountBL.GetByClientId(client.Id);
                account.IBAN = Account.Text;

                valid = employeeBL.UpdateClient(clientToUpdate);
                valid = accountBL.UpdateAccount(account);

            }

            if (!valid)
            {
                MessageBox.Show(
                    "Error", "Client data cannot be updated!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1
                    );
            }
            else
            {
                MessageBox.Show(
                    "Success", "Client data has been updated!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                    );

                UserActionData action = new UserActionData()
                {
                    Description = "Insert/Update a user",
                    Timestamp = DateTime.Now,
                    UserId = this.user.Id
                };

                userActionBL.InsertUserAction(action);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InitializeFields(ClientData client)
        {
            if (client != null)
            {
                this.client = client;
                this.Firstname.Text = client.Firstnme;
                this.Lastname.Text = client.Lastname;
                this.CNP.Text = client.CNP;
                this.Mobile.Text = client.Mobile;
                this.City.Text = client.City;
                this.Street.Text = client.Street;
                this.Number.Text = client.Number;
                this.Account.Text = accountBL.GetByClientId(client.Id).IBAN;
            }
        }
    }
}
