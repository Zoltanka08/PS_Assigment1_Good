using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDAL.DataMapper
{
    public class ClientMapper
    {
         private DbConnection connection;

         public ClientMapper()
        {
            if (this.connection == null)
                this.connection = new DbConnection();
        }

        public void InsertUser(ClientData client)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = @"INSERT INTO [Client](Firstnme,Lastname,Mobile,CNP,City,Street,Number) 
                                            VALUES(@usn,@pass,@fn,@ln,@mob,@cnp,@city,@str,@nr)";
            command.Parameters.AddWithValue("@fn", client.Firstnme);
            command.Parameters.AddWithValue("@ln", client.Lastname);
            command.Parameters.AddWithValue("@mob", client.Mobile);
            command.Parameters.AddWithValue("@cnp", client.CNP);
            command.Parameters.AddWithValue("@city", client.City);
            command.Parameters.AddWithValue("@str", client.Street);
            command.Parameters.AddWithValue("@nr", client.Number);

            connection.ExecuteNonQuery(command);
        }

       public IEnumerable<ClientData> GetAll()
        {
            List<ClientData> clients = new List<ClientData>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Client]");

            DataTable dt = connection.ExecuteReader(cmd);
            foreach (DataRow row in dt.Rows) 
            {
                ClientData client = new ClientData()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Firstnme = row["Firstnme"].ToString(),
                    Lastname = row["Lastname"].ToString(),
                    Mobile = row["Mobile"].ToString(),
                    CNP = row["CNP"].ToString(),
                    City = row["City"].ToString(),
                    Street = row["Street"].ToString(),
                    Number = row["Number"].ToString()
                };

                clients.Add(client);
            }

            return clients;
        }

       public ClientData GetById(int id)
       {
           List<ClientData> clients = new List<ClientData>();
           SqlCommand cmd = new SqlCommand("SELECT * FROM [Client] WHERE Id = " + id);
           DataTable dt = connection.ExecuteReader(cmd);
           DataRow row = dt.Rows[0];
           ClientData client = new ClientData()
           {
               Id = Convert.ToInt32(row["Id"]),
               Firstnme = row["Firstnme"].ToString(),
               Lastname = row["Lastname"].ToString(),
               Mobile = row["Mobile"].ToString(),
               CNP = row["CNP"].ToString(),
               City = row["City"].ToString(),
               Street = row["Street"].ToString(),
               Number = row["Number"].ToString()
           };

           return client;
       }
    }
}
