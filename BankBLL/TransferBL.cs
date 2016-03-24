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
    public class TransferBL
    {
        private AccountMapper accountMapper = new AccountMapper();

        public bool MakeTransfer(ClientData fromClient, ClientData toClient, double amount)
        {
            if (fromClient.Id == toClient.Id)
                return false;

            AccountData fromAccount = accountMapper.GetByClientId(fromClient.Id);
            AccountData toAccount = accountMapper.GetByClientId(toClient.Id);

            if (fromAccount.Balance < amount || amount < 0.0)
                return false;

            fromAccount.Balance -= amount;
            toAccount.Balance += amount;
            bool valid = accountMapper.UpdateAccount(fromAccount);
            valid = accountMapper.UpdateAccount(toAccount);

            return valid;
        }
    }
}
