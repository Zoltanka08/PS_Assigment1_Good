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
    public class RoleMapper
    {
        private DbConnection connection;

        public RoleMapper()
        {
            if (this.connection == null)
                this.connection = new DbConnection();
        }

        public RoleData GetById(int id)
        {
            List<RoleData> users = new List<RoleData>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Role] WHERE Id = " + id);
            DataTable dt = connection.ExecuteReader(cmd);
            DataRow row = dt.Rows[0];
            RoleData role = new RoleData()
            {
                Id = Convert.ToInt32(row["Id"]),
                Name = row["Name"].ToString()         
            };

            return role;
        }
    }
}
