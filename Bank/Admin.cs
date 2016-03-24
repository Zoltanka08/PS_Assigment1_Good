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
    public partial class Admin : Form
    {
        private AdminBL adminBL = new AdminBL();
        private UserActionBL userActionBL = new UserActionBL();

        public Admin()
        {
            InitializeComponent();
            InitializeListBox();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            EmployeeName selectedItem = listBox1.SelectedItem as EmployeeName;
            UserData user = adminBL.GetUserById(selectedItem.Id);

            switch (MessageBox.Show(this, "Are you sure?", "Do you still want to delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Stay on this form
                case DialogResult.Yes:
                    adminBL.DeleteUser(user.Id);
                    InitializeListBox();
                    break;
                case DialogResult.No:
                    return;
                    break;
                default:
                    break;
            }
            
        }

        private void InitializeListBox()
        {
            var users = adminBL.GetAllUsers().ToList();
            List<EmployeeName> employees = new List<EmployeeName>();
            foreach (var user in users)
            {
                EmployeeName employee = new EmployeeName();
                employee.Id = user.Id;
                employee.Name = user.Firstname + " " + user.Lastname;
                employees.Add(employee);
            }
            listBox1.DataSource = employees;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            InitializeListBox();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            EmployeeName selectedItem = listBox1.SelectedItem as EmployeeName;
            UserData user = adminBL.GetUserById(selectedItem.Id);
            ReportView report = new ReportView(userActionBL.GetByUserId(user.Id).ToList());
            report.Show();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            EmployeeName selectedItem = listBox1.SelectedItem as EmployeeName;
            UserData user = adminBL.GetUserById(selectedItem.Id);
            UserView userView = new UserView(user);
            userView.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UserView userView = new UserView(null);
            userView.Show();
        }
    }
}
