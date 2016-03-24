using BankDAL.DataMapper;
using BankDAL.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBLL
{
    public class AdminBL
    {
        private UserMapper userMapper = new UserMapper();

        public IEnumerable<UserData> GetAllUsers()
        {
            return userMapper.GetAll();
        }

        public UserData GetUserById(int id)
        {
            return userMapper.GetById(id);
        }

        public UserData GetUserByUsername(string username)
        {
            return userMapper.GetByUsername(username);
        }

        public void DeleteUser(int id)
        {
            userMapper.DeleteUser(id);
        }

        public bool UpdateUser(UserData user)
        {
            return userMapper.UpdateUser(user);
        }

        public bool InsertUser(UserData user)
        {
            return this.userMapper.InsertUser(user);
        }
     }
}
