using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBLL;
using BankDAL.DataObjects;

namespace UnitTests.BLTestDatas
{
    public class AdminBLTestData
    {
        public UserData noUppercaseInPassword = new UserData()
        {
            Username = "Wrong_Password",
            Password = "asd123_as",
            Mail = "wrong@wrong.com",
            Firstname = "Wrong",
            Lastname = "Wrong",
            RoleId = "2"
        };

        public UserData noNonAlphanumericInPassword = new UserData()
        {
            Username = "Wrong_Password",
            Password = "Asd123as",
            Mail = "wrong@wrong.com",
            Firstname = "Wrong",
            Lastname = "Wrong",
            RoleId = "2"
        };

        public UserData noNumberInPassword = new UserData()
        {
            Username = "Wrong_Password",
            Password = "Asd123as",
            Mail = "wrong@wrong.com",
            Firstname = "Wrong",
            Lastname = "Wrong",
            RoleId = "2"
        };

        public UserData noDomainInMail = new UserData()
        {
            Username = "Wrong_Password",
            Password = "Asd_123as",
            Mail = "wrong@wrong",
            Firstname = "Wrong",
            Lastname = "Wrong",
            RoleId = "2"
        };

        public UserData correctUserData = new UserData()
        {
            Username = "Wrong_Password",
            Password = "Asd_123as",
            Mail = "wrong@wrong.com",
            Firstname = "Wrong",
            Lastname = "Wrong",
            RoleId = "2"
        };
    }
}
