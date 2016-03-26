using BankDAL.DataMapper;
using BankDAL.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (!IsValid(user))
                return false;

            return userMapper.UpdateUser(user);
        }

        public bool InsertUser(UserData user)
        {
            if (!IsValid(user))
                return false;

            return this.userMapper.InsertUser(user);
        }

        public bool IsValid(UserData user)
        {
            string passwordPattern = @"^(?=.*[a-z])(?=.*[0-9])(?=.*[_.!?$#]).{6,15}$";
            string emailPattern = @"^([0-9a-zA-Z]" + //Start with a digit or alphabetical
                                    @"([\+\-_\.][0-9a-zA-Z]+)*" + // No continuous or ending +-_. chars in email
                                    @")+" +
                                    @"@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$";
            string numberPattern = "^[0-9]+$";


            if (userMapper.GetByUsername(user.Username) != null)
                return false;

            if (user.Password != null)
                if (!Regex.IsMatch(user.Password, passwordPattern))
                    return false;

            if (user.Mail != null)
                if (!Regex.IsMatch(user.Mail, emailPattern))
                    return false;

            if (user.Mobile != null)
                if (!Regex.IsMatch(user.Mobile, numberPattern))
                    return false;

            return true;
        }

     }
}
