using BankDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data.SqlClient;
using BankDAL.DataObjects;

namespace BankDAL.DataMapper
{
    class GenericMapper : IDataMapper
    {
        public System.Type DtoType { get; set; }
        private bool _isInitialized = false;
        private List<PropertyOrdinalMap> PropertyOrdinalMappings;
        private DbConnection connection;


        public GenericMapper(System.Type type)
        {
            DtoType = type;
            if (connection == null)
                connection = new DbConnection();
        }


        private void InitializeMapper(IDataReader reader)
        {
            PopulatePropertyOrdinalMappings(reader);
            _isInitialized = true;
        }


        public void PopulatePropertyOrdinalMappings(IDataReader reader)
        {
            // Get the PropertyInfo objects for our DTO type and map them to 
            // the ordinals for the fields with the same names in our reader.  
            PropertyOrdinalMappings = new List<PropertyOrdinalMap>();
            PropertyInfo[] properties = DtoType.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                PropertyOrdinalMap map = new PropertyOrdinalMap();
                map.Property = property;
                try
                {
                    map.Ordinal = reader.GetOrdinal(property.Name);
                    PropertyOrdinalMappings.Add(map);
                }
                catch { }
            }
        }


        public Object GetData(IDataReader reader)
        {
            if (!_isInitialized) { InitializeMapper(reader); }
            object dto = Activator.CreateInstance(DtoType);
            foreach (PropertyOrdinalMap map in PropertyOrdinalMappings)
            {
                if (!reader.IsDBNull(map.Ordinal))
                {
                    map.Property.SetValue(dto, reader.GetValue(map.Ordinal), null);
                }
            }
            return dto;
        }

        public void InsertData(string tableName, Dictionary<string,string> dataValues)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection.GetConnection();
            command.CommandType = CommandType.Text;

            System.Func<string, string> key = p => String.Concat("@", p);
            var statement = string.Format(
                "INSERT INTO [" + tableName + "] ({1}) VALUES ({0})", 
                string.Join(",", dataValues.Values.Select(key).ToArray()),
                string.Join(",", dataValues.Keys.ToArray())
                );

            command.CommandText = statement;

            foreach(var p in dataValues)
            {
                var mykey = key(p.Key);
                command.Parameters.AddWithValue(key(p.Key), p.Value);
            }

            connection.ExecuteNonQuery(command);
        }



        public int GetRecordCount(IDataReader reader)
        {
            Object count = reader["RecordCount"];
            return count == null ? 0 : Convert.ToInt32(count);
        }


        private class PropertyOrdinalMap
        {
            public PropertyInfo Property { get; set; }
            public int Ordinal { get; set; }
        }

    }
}
