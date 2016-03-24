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
    public partial class UtilityBill : Form
    {
        private AccountData account = new AccountData();
        private double amount;
        private DateTime timestamp;
        public UtilityBill(AccountData account, double amount, DateTime time)
        {
            InitializeComponent();
            this.account = account;
            this.timestamp = time;
            this.amount = amount;
            this.IBAN.Text = account.IBAN;
            this.Balance.Text = account.Balance.ToString();
            this.Amount.Text = this.amount.ToString();
            this.Data.Text = this.timestamp.ToString();
        }
    }
}
