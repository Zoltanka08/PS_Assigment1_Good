using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data;

namespace BankDAL
{
    class DbConnection
    {
        private string conncetionString = @"data source=ZOLTAN\SQLMANAGER;initial catalog=BankData;integrated security=True;";
        private SqlConnection conncetion = new SqlConnection();

        public SqlConnection GetConnection()
        {
            if(conncetion.State == ConnectionState.Closed)
            {
                conncetion.ConnectionString = conncetionString;
                conncetion.Open();
            }

            return conncetion;
        }

        public int ExecuteNonQuery(SqlCommand cmd)
        {
            cmd.Connection = GetConnection();
            int affectedRows = -1;
            affectedRows = cmd.ExecuteNonQuery();
            conncetion.Close();
            
            return affectedRows;
        }

        public object ExecuteScalar(SqlCommand cmd)
        {
            cmd.Connection = GetConnection();
            object obj = cmd.ExecuteScalar();
            conncetion.Close();

            return obj;
        }

        public DataTable ExecuteReader(SqlCommand cmd)
        {
            cmd.Connection = GetConnection();
            SqlDataReader sdr;
            DataTable dt = new DataTable();

            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            sdr.Close();
            conncetion.Close();

            return dt;
        }

    }
}
