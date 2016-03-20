using BankDAL.DataMapper;
using BankDAL.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDAL
{
    class Program
    {
        public static void Main(string[] args)
        {
            DbConnection db = new DbConnection();
            TransactionScript ts = new TransactionScript();
            DataTable dt = new DataTable();
            ClientData clientToInsert = new ClientData()
            {
                Firstnme = "new2",
                Lastname = "new2",
                CNP = "142141114",
                Mobile = "25322366",
                City = "new",
                Street = "new",
                Number = "1"
            };

            UserData userToInsert = new UserData()
            {
                Username = "New",
                Password = "newpass",
                Firstname = "NewF",
                Lastname = "NewL",
                Mail = "newcom",
                Mobile = "n1451125",
                RoleId = "2"
            };

            DataMapperFactory mapperFactory = new DataMapperFactory();
            var userMapper = mapperFactory.GetMapper(typeof(UserData));

            Dictionary<string, string> userData = new Dictionary<string, string>()
                { { "Username", userToInsert.Username },
                    { "Password",userToInsert.Password },
                    { "Firstname",userToInsert.Firstname },
                    { "Lastname" ,userToInsert.Lastname },
                    { "Mail",userToInsert.Mail},
                    { "Mobile",userToInsert.Mobile}
                };

            var simpleUserMapper = new UserMapper();
         //   simpleUserMapper.InsertUser(userToInsert);
          //  simpleUserMapper.GetData();

            var user = simpleUserMapper.GetById(1);

          //  userMapper.InsertData("User", userData);
/*
            dt = ts.GetAllClient();

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row["Lastname"].ToString());
            }
 * */
  //          ClientData client = ts.GetClientById(1);

 //           ts.UpdateClient(clientToInsert,3);

 //           ts.DeleteClient(3);

        }
    }
}
