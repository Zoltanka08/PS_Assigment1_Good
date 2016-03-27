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
    public class UserMapper
    {
        private DbConnection connection;
        
        public UserMapper()
        {
            if (this.connection == null)
                this.connection = new DbConnection();
        }

        public bool InsertUser(UserData user)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = @"INSERT INTO [User](Username,Password,Firstname,Lastname,Mobile,Mail,RoleId) 
                                            VALUES(@usn,@pass,@fn,@ln,@mob,@mail,@role)";
            command.Parameters.AddWithValue("@usn", user.Username);
            command.Parameters.AddWithValue("@pass", user.Password);
            command.Parameters.AddWithValue("@fn", user.Firstname);
            command.Parameters.AddWithValue("@ln", user.Lastname);
            command.Parameters.AddWithValue("@mob", user.Mobile);
            command.Parameters.AddWithValue("@mail", user.Mail);
            command.Parameters.AddWithValue("@role", user.RoleId);

            try
            {
                connection.ExecuteNonQuery(command);
            }
            catch(SqlException)
            {
                return false;
            }
            return true;
        }

        public bool UpdateUser(UserData user)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = @"UPDATE [User] SET Firstname = @fn, Lastname = @ln, Username = @usn, Mobile = @mob, Mail = @mail, Password = @pass, RoleId = @role
                                                WHERE Id = " + user.Id;
            command.Parameters.AddWithValue("@usn", user.Username);
            command.Parameters.AddWithValue("@pass", user.Password);
            command.Parameters.AddWithValue("@fn", user.Firstname);
            command.Parameters.AddWithValue("@ln", user.Lastname);
            command.Parameters.AddWithValue("@mob", user.Mobile);
            command.Parameters.AddWithValue("@mail", user.Mail);
            command.Parameters.AddWithValue("@role", user.RoleId);

            try
            {
                connection.ExecuteNonQuery(command);
            }
            catch(SqlException)
            {
                return false;
            }

            return true;
        }

       public IEnumerable<UserData> GetAll()
        {
            List<UserData> users = new List<UserData>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [User]");

            DataTable dt = connection.ExecuteReader(cmd);
            foreach (DataRow row in dt.Rows) 
            {
                UserData user = new UserData()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Username = row["Username"].ToString(),
                    Password = row["Password"].ToString(),
                    Firstname = row["Firstname"].ToString(),
                    Lastname = row["Lastname"].ToString(),
                    Mobile = row["Mobile"].ToString(),
                    Mail = row["Mail"].ToString(),
                    RoleId = row["RoleId"].ToString()
                };

                users.Add(user);
            }

            return users;
        }

       public UserData GetById(int id)
       {
           List<UserData> users = new List<UserData>();
           SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE Id = " + id);
           DataTable dt = connection.ExecuteReader(cmd);
           DataRow row = dt.Rows[0];
           UserData user = new UserData()
           {
               Id = Convert.ToInt32(row["Id"]),
               Username = row["Username"].ToString(),
               Password = row["Password"].ToString(),
               Firstname = row["Firstname"].ToString(),
               Lastname = row["Lastname"].ToString(),
               Mobile = row["Mobile"].ToString(),
               Mail = row["Mail"].ToString(),
               RoleId = row["RoleId"].ToString()
           };

           return user;
       }

       public UserData GetByUsername(string username)
       {
           List<UserData> users = new List<UserData>();
           SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE [Username] = '" + username + "'");
           DataTable dt = connection.ExecuteReader(cmd);

           if (dt.Rows.Count == 0)
               return null;

           DataRow row = dt.Rows[0];
           UserData user = new UserData()
           {
               Id = Convert.ToInt32(row["Id"]),
               Username = row["Username"].ToString(),
               Password = row["Password"].ToString(),
               Firstname = row["Firstname"].ToString(),
               Lastname = row["Lastname"].ToString(),
               Mobile = row["Mobile"].ToString(),
               Mail = row["Mail"].ToString(),
               RoleId = row["RoleId"].ToString()
           };

           return user;
       }

       public void DeleteUser(int id)
       {
           SqlCommand command = new SqlCommand();
           command.CommandType = CommandType.Text;

           command.CommandText = @"DELETE FROM [User] WHERE Id = " + id;

           connection.ExecuteNonQuery(command);
       }
    }
}
