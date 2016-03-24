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
    public partial class ReportView : Form
    {
        List<UserActionData> actions = new List<UserActionData>();
        public ReportView(List<UserActionData> actions )
        {
            InitializeComponent();
            this.actions = actions;
            InitializeList();
        }

        private void InitializeList()
        {
            List<string> datasource = new List<string>();
            foreach(var action in this.actions)
            {
                string desc = action.Timestamp.ToString() + " : " + action.Description;
                datasource.Add(desc);
            }

            listBox1.DataSource = datasource;
        }
    }
}
