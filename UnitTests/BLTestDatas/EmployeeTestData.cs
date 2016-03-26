using BankDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.BLTestDatas
{
    public class EmployeeTestData
    {
        public ClientData wrongMobileFormat = new ClientData()
        {
            Firstnme = "qdfasdf",
            Lastname = "afasdfad",
            Mobile = "12da3",
            CNP = "12323525",
            City = "afdfsdf",
            Street = "adsfasdf",
            Number = "adfs"
        };
    }
}
