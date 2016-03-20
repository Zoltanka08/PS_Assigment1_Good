using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDAL.Interfaces
{
    public interface IDataMapper
    {
        Object GetData(IDataReader reader);
        int GetRecordCount(IDataReader reader);
        void InsertData(string tableName, Dictionary<string, string> dataValues);
    }
}
