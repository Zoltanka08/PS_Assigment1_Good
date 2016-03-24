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

        public bool InsertAccount(AccountData account)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"INSERT INTO [Account](IBAN,Balance,Startdate,TypeId,ClientId) 
                                            VALUES(@iban,@bl,@data,@type,@client)";
            cmd.Parameters.AddWithValue("@iban", account.IBAN);
            cmd.Parameters.AddWithValue("@bl", account.Balance);
            cmd.Parameters.AddWithValue("@data", account.Startdate);
            cmd.Parameters.AddWithValue("@type", account.TyepId);
            cmd.Parameters.AddWithValue("@client", account.ClientId);

            try
            {
                connection.ExecuteNonQuery(cmd);
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }

        public bool UpdateAccount(AccountData account)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE [Account] SET IBAN = @iban, Balance = @bl, Startdate = @data, TypeId = @type, ClientId = @client WHERE Id = " + account.Id;
            cmd.Parameters.AddWithValue("@iban", account.IBAN);
            cmd.Parameters.AddWithValue("@bl", account.Balance);
            cmd.Parameters.AddWithValue("@data", account.Startdate);
            cmd.Parameters.AddWithValue("@type", account.TyepId);
            cmd.Parameters.AddWithValue("@client", account.ClientId);

            try
            {
                connection.ExecuteNonQuery(cmd);
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }

        public AccountData GetByIBAN(string iban)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Account] WHERE IBAN = '" + iban + "'");
            DataTable dt = connection.ExecuteReader(cmd);
            DataRow row = dt.Rows[0];
            AccountData account = new AccountData()
            {
                IBAN = row["IBAN"].ToString(),
                Balance = Convert.ToDouble(row["Balance"].ToString()),
                Startdate = DateTime.Parse(row["Startdate"].ToString()),
                Id = Convert.ToInt32(row["Id"].ToString()),
                ClientId = Convert.ToInt32(row["ClientId"].ToString()),
                TyepId = Convert.ToInt32(row["TypeId"].ToString())
            };

            return account;
        }

        public AccountData GetByIBAN(int clientid)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Account] WHERE ClientId = " + clientid);
            DataTable dt = connection.ExecuteReader(cmd);
            DataRow row = dt.Rows[0];
            AccountData account = new AccountData()
            {
                IBAN = row["IBAN"].ToString(),
                Balance = Convert.ToDouble(row["Balance"].ToString()),
                Startdate = DateTime.Parse(row["Startdate"].ToString()),
                Id = Convert.ToInt32(row["Id"].ToString()),
                ClientId = Convert.ToInt32(row["ClientId"].ToString()),
                TyepId = Convert.ToInt32(row["TypeId"].ToString())
            };

            return account;
        }

        public void DeleteAccount(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"DELETE FROM [Account] WHERE Id =" + id;
            connection.ExecuteNonQuery(cmd);
        }

    }
}
