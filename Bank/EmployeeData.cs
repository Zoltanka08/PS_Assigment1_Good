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
        private AccountMapper accountMapper = new AccountMapper();
        public EmployeeData(ClientData client)
        {
            InitializeComponent();
            this.client = client;
            this.Firstname.Text = client.Firstnme;
            this.Lastname.Text = client.Lastname;
            this.CNP.Text = client.CNP;
            this.Mobile.Text = client.Mobile;
            this.City.Text = client.City;
            this.Street.Text = client.Street;
            this.Number.Text = client.Number;
            this.Account.Text = accountMapper.GetByClientId(client.Id).IBAN;
        }

        private void EmployeeData_Load(object sender, EventArgs e)
        {

        }
    }
}
