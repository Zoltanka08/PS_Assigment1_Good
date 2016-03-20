using BankDAL;
using BankDAL.DataMapper;
using BankDAL.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBLL
{
    public class EmployeeBL
    {
        public IEnumerable<ClientData> GetAllClients()
        {
            ClientMapper clientMapper = new ClientMapper();
            IEnumerable<ClientData> clients = clientMapper.GetAll();

            return clients;
        }
    }
}
