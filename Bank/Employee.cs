using BankBLL;
using BankDAL;
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
        private EmployeeBL employeeBL = new EmployeeBL();
        public Employee()
        {
            InitializeComponent();
            var clients = employeeBL.GetAllClients().ToList();
            List<EmployeeName> employees = new List<EmployeeName>();
            foreach (var client in clients)
            {
                EmployeeName employee = new EmployeeName();
                employee.Id = client.Id;
                employee.Name = client.Firstnme + " " + client.Lastname;
                employees.Add(employee);
            }
            listBox1.DataSource = employees;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EmployeeName selectedItem = listBox1.SelectedItem as EmployeeName;
            ClientData client = employeeBL.GetAllClients().Where(u => u.Id == selectedItem.Id).First();
            EmployeeData employeeData = new EmployeeData(client);
            employeeData.Show();
        }
    }
}
