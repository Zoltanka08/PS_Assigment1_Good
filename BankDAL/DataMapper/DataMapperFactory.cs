using BankDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDAL.DataMapper
{
    public class DataMapperFactory
    {       
        public IDataMapper GetMapper(System.Type dtoType)
        {    
            return new GenericMapper(dtoType);
        }
    }
}
