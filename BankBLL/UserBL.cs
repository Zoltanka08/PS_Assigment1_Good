using BankDAL.DataMapper;
using BankDAL.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBLL
{
    public class UserBL
    {
        private UserMapper userMapper = new UserMapper();

        public UserData GetUserByUsername(string username)
        {
            return userMapper.GetByUsername(username);
        }
    }
}
