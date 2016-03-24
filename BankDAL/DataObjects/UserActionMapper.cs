using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDAL.DataObjects
{
    public class UserActionMapper
    {
        private DbConnection connection;

        public UserActionMapper()
        {
            if (this.connection == null)
                this.connection = new DbConnection();
        }

        public bool InsertUserAction(UserActionData userAction)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = @"INSERT INTO [UserAction](Timestamp,Description,UserId) 
                                            VALUES(@ts,@des,@usr)";
            command.Parameters.AddWithValue("@ts", userAction.Timestamp);
            command.Parameters.AddWithValue("@des", userAction.Description);
            command.Parameters.AddWithValue("@usr", userAction.UserId);

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

        public IEnumerable<UserActionData> GetByUserId(int id)
        {
            IList<UserActionData> actions = new List<UserActionData>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [UserAction] WHERE UserId = " + id);
            DataTable dt = connection.ExecuteReader(cmd);

            foreach (DataRow row in dt.Rows)
            {
                UserActionData action = new UserActionData()
                {
                    Description = row["Description"].ToString(),
                    Id = Convert.ToInt32(row["Id"]),
                    Timestamp = DateTime.Parse(row["Timestamp"].ToString()),
                    UserId = Convert.ToInt32(row["UserId"])
                };

                actions.Add(action);
            }

            return actions;
        }
    }
}
