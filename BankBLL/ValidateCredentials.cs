using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDAL.DataMapper;
using BankDAL.DataObjects;

namespace BankBLL
{
    public class ValidateCredentials
    {

        public string GetRole(string username, string password)
        {
            string roleName;
            RoleData role;
            UserMapper userMapper = new UserMapper();
            RoleMapper roleMapper = new RoleMapper();

            UserData user = userMapper.GetByUsername(username);

            if (user != null && user.Password.Equals(password))
            {
                role = roleMapper.GetById(Convert.ToInt32(user.RoleId));
                roleName = role.Name;
            }
            else
                roleName = "Unauthorized";

            return roleName;
        }
    }
}
