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
        TransactionScript ts = new TransactionScript();
        public IEnumerable<ClientData> GetAllClients()
        {
            ClientMapper clientMapper = new ClientMapper();
            IEnumerable<ClientData> clients = clientMapper.GetAll();

            return clients;
        }

        public ClientData GetClientById(int id)
        {
            return GetAllClients().First(c => c.Id == id);
        }

        public ClientData GetClientByCNP(string cnp)
        {
            return ts.GetClientByCNP(cnp);
        }

        public bool UpdateClient(ClientData client)
        {
            bool valid = true;

            if(client!=null)
            {
                if(string.IsNullOrWhiteSpace(client.Firstnme) || 
                   string.IsNullOrWhiteSpace(client.Lastname) || 
                   string.IsNullOrWhiteSpace(client.Mobile) || 
                   string.IsNullOrWhiteSpace(client.CNP))
                { 
                    return false;
                }
                else
                {
                   valid = ts.UpdateClient(client);
                }
            }
            else
            {
                return false;
            }

            return valid;
        }

        public bool InserClient(ClientData client)
        {
            bool valid = true;

            if (client != null)
            {
                if (string.IsNullOrWhiteSpace(client.Firstnme) ||
                   string.IsNullOrWhiteSpace(client.Lastname) ||
                   string.IsNullOrWhiteSpace(client.Mobile) ||
                   string.IsNullOrWhiteSpace(client.CNP))
                {
                    return false;
                }
                else
                {
                    valid = ts.InsertClient(client);
                }
            }
            else
            {
                return false;
            }

            return valid;
        }

        public bool DeleteClient(int id)
        {
            return ts.DeleteClient(id);
        }
    }
}
