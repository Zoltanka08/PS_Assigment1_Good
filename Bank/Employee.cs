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
    public partial class Employee : Form
    {
        private UserData user;
        private EmployeeBL employeeBL = new EmployeeBL();
        private TransferBL transferBL = new TransferBL();
        private AccountBL accountBL = new AccountBL();
        private UserActionBL userActionBL = new UserActionBL();

        public Employee(UserData user)
        {
            InitializeComponent();
            InitializeList();
            this.user = user;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EmployeeName selectedItem = listBox1.SelectedItem as EmployeeName;
            ClientData client = employeeBL.GetAllClients().Where(u => u.Id == selectedItem.Id).First();
            EmployeeData employeeData = new EmployeeData(client,user);
            employeeData.Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            InitializeList();
        }

        private void InitializeList()
        {
            var clients1 = employeeBL.GetAllClients().ToList();
            List<EmployeeName> employees1 = new List<EmployeeName>();
            foreach (var client in clients1)
            {
                EmployeeName employee = new EmployeeName();
                employee.Id = client.Id;
                employee.Name = client.Firstnme + " " + client.Lastname;
                employees1.Add(employee);
            }
            listBox1.DataSource = employees1;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";

            var clients2 = employeeBL.GetAllClients().ToList();
            List<EmployeeName> employees2 = new List<EmployeeName>();
            foreach (var client in clients2)
            {
                EmployeeName employee = new EmployeeName();
                employee.Id = client.Id;
                employee.Name = client.Firstnme + " " + client.Lastname;
                employees2.Add(employee);
            }

            listBox2.DataSource = employees2;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "Id";
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                // Assume that X has been clicked and act accordingly.
                // Confirm user wants to close
                switch (MessageBox.Show(this, "Are you sure?", "Do you still want to close ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Stay on this form
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        Application.Exit();
                        break;
                    default:
                        break;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            EmployeeName selectedItem = listBox1.SelectedItem as EmployeeName;
            AccountData account = accountBL.GetByClientId(selectedItem.Id);
            accountBL.DeleteAccount(account.Id); 
            bool valid = employeeBL.DeleteClient(selectedItem.Id);
            if(valid)
            {
                InitializeList();
                UserActionData action = new UserActionData()
                {
                    Description = "Deleted a user",
                    Timestamp = DateTime.Now,
                    UserId = this.user.Id
                };

                userActionBL.InsertUserAction(action);
            }
            else
            {
                MessageBox.Show("Error", 
                    "Delete has been failed!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information, 
                    MessageBoxDefaultButton.Button1
                    );
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            EmployeeData employeeData = new EmployeeData(null,user);
            employeeData.Show();
        }

        private void ViewAccountButton_Click(object sender, EventArgs e)
        {
            EmployeeName selectedItem = listBox1.SelectedItem as EmployeeName;
            AccountData account = accountBL.GetByClientId(selectedItem.Id);
            AccountView accountView = new AccountView(account);
            accountView.Show();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Are you sure?", "Do you still want to make the transfer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Stay on this form
                case DialogResult.No:
                    return;
                default:
                    break;
            }

            double amount = 0.0;
            try
            {
                amount = Convert.ToDouble(this.Transfer.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Error","Wrong amount format",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }

            EmployeeName selectedItem1 = listBox1.SelectedItem as EmployeeName;
            ClientData fromClient = employeeBL.GetClientById(selectedItem1.Id);

            EmployeeName selectedItem2 = listBox2.SelectedItem as EmployeeName;
            ClientData toClient = employeeBL.GetClientById(selectedItem2.Id);

            bool isValid = transferBL.MakeTransfer(fromClient, toClient, amount);

            if(isValid)
            {
                MessageBox.Show("Success", "Transfer succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                UserActionData action = new UserActionData()
                {
                    Description = "transfer between accounts",
                    Timestamp = DateTime.Now,
                    UserId = this.user.Id
                };

                userActionBL.InsertUserAction(action);

                switch (MessageBox.Show(this, "Utility bill!", "Do you want to create a utility bill?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Stay on this form
                    case DialogResult.Yes:
                        new UtilityBill(accountBL.GetByClientId(fromClient.Id),amount,DateTime.Now).Show();
                        break;
                    case DialogResult.No:
                        return;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error", "Insuficient money wrong destination!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
        }
    }
}
