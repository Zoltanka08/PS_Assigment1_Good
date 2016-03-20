using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDAL
{
    class TransactionScript
    {
        private DbConnection db = new DbConnection();

        public DataTable GetAllClient()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Client");
            
            return db.ExecuteReader(cmd);
        }

        public ClientData GetClientById(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Client WHERE Id = " + id);
            DataTable dt = db.ExecuteReader(cmd);
            DataRow row = dt.Rows[0];
            ClientData client = new ClientData() 
            {
                Id = Convert.ToInt32(row["Id"]), 
                Firstnme = row["Firstnme"].ToString(), 
                Lastname = row["Lastname"].ToString(),
                Mobile = row["Mobile"].ToString(),
                CNP = row["CNP"].ToString(),
                Street = row["Street"].ToString(),
                City = row["City"].ToString(),
                Number = row["Number"].ToString()
            };

            return client;
        }

        public void InsertClient(ClientData client)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"INSERT INTO Client(Firstnme,Lastname,CNP,Mobile,City,Street,Number) 
                                            VALUES(@fn,@ln,@cnp,@mob,@city,@str,@nr)";
            cmd.Parameters.AddWithValue("@fn",client.Firstnme);
            cmd.Parameters.AddWithValue("@ln",client.Lastname);
            cmd.Parameters.AddWithValue("@cnp",client.CNP);
            cmd.Parameters.AddWithValue("@mob",client.Mobile);
            cmd.Parameters.AddWithValue("@city",client.City);
            cmd.Parameters.AddWithValue("@str",client.Street);
            cmd.Parameters.AddWithValue("@nr",client.Number);

            db.ExecuteNonQuery(cmd);
        }

        public void UpdateClient(ClientData client, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE Client SET Firstnme = @fn, Lastname = @ln, CNP = @cnp, Mobile = @mob, City = @city, Street = @str, Number = @nr
                                                WHERE Id = " + id;
            cmd.Parameters.AddWithValue("@fn", client.Firstnme);
            cmd.Parameters.AddWithValue("@ln", client.Lastname);
            cmd.Parameters.AddWithValue("@cnp", client.CNP);
            cmd.Parameters.AddWithValue("@mob", client.Mobile);
            cmd.Parameters.AddWithValue("@city", client.City);
            cmd.Parameters.AddWithValue("@str", client.Street);
            cmd.Parameters.AddWithValue("@nr", client.Number);

            db.ExecuteNonQuery(cmd);
        }

        public void DeleteClient(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"DELETE FROM Client WHERE Id =" + id;

            db.ExecuteNonQuery(cmd);
        }
    }
}
