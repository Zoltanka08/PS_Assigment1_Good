using BankDAL.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDAL.DataMapper
{
    public class AccountMapper
    {
        private DbConnection connection;

        public AccountMapper()
        {
            if (this.connection == null)
                this.connection = new DbConnection();
        }
        public AccountData GetByClientId(int clientId)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Account] WHERE ClientId = " + clientId);
            DataTable dt = connection.ExecuteReader(cmd);
            AccountData account = null;
            try {
                DataRow row = dt.Rows[0];
                account = new AccountData()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    IBAN = row["IBAN"].ToString(),
                    Balance = Convert.ToDouble(row["Balance"]),
                    Startdate = DateTime.Parse(row["Startdate"].ToString()),
                    TyepId = Convert.ToInt32(row["TypeId"].ToString()),
                    ClientId = Convert.ToInt32(row["ClientId"].ToString())
                };
            }catch(Exception ex)
            {
                account = null;
            }
            
            return account;
        }
    }
}
