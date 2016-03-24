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
    public class AccountBL
    {
        AccountMapper accountMapper = new AccountMapper();

        public bool InsertAccount(AccountData account)
        {
            bool valid = true;
            if(account != null)
            {
                if(account.IBAN == null)
                {
                    return false;
                }
                else
                {
                    valid = accountMapper.InsertAccount(account);
                }
            }
            else
            {
                return false;
            }

            return valid;
        }

        public bool UpdateAccount(AccountData account)
        {
            bool valid = true;
            if (account != null)
            {
                if (account.IBAN == null)
                {
                    return false;
                }
                else
                {
                    valid = accountMapper.UpdateAccount(account);
                }
            }
            else
            {
                return false;
            }

            return valid;
        }

        public AccountData GetByIBAN(string iban)
        {
            return accountMapper.GetByIBAN(iban);
        }

        public AccountData GetByClientId(int id)
        {
            return accountMapper.GetByClientId(id);
        }

        public void DeleteAccount(int id)
        {
            accountMapper.DeleteAccount(id);
        } 
    }
}
