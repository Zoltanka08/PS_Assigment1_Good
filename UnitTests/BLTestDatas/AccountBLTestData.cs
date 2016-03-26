using BankDAL.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.BLTestDatas
{
    public class AccountBLTestData
    {
        public AccountData balanceLessThanZero = new AccountData()
        {
            Balance = -1,
            ClientId = 1,
            IBAN = "RO1321234FNAKSK1245JLN",
            Startdate = DateTime.Now,
            TyepId = 1
        };

        public AccountData IBANLengthLessThan10 = new AccountData()
        {
            Balance = 10,
            ClientId = 1,
            IBAN = "RO132",
            Startdate = DateTime.Now,
            TyepId = 1
        };

        public AccountData nullIBAN = new AccountData()
        {
            Balance = 10,
            ClientId = 1,
            IBAN = "RO132",
            Startdate = DateTime.Now,
            TyepId = 1
        };
    }
}
