using BankDAL;
using BankDAL.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBLL
{
    public class TypeBL
    {
        private TransactionScript ts = new TransactionScript();

        public TypeData GetTypeById(int id)
        {
            return ts.GetTypeById(id);
        }
    }
}
