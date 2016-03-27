using BankDAL.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBLL
{
    public class UserActionBL
    {
        private UserActionMapper userActionMapper = new UserActionMapper();

        public IEnumerable<UserActionData> GetByUserId(int id, DateTime startDate)
        {
            return userActionMapper.GetByUserId(id).Where(a => a.Timestamp > startDate);
        }

        public bool InsertUserAction(UserActionData action)
        {
            bool valid = true;
            if (action != null)
            {
                if (!string.IsNullOrWhiteSpace(action.Description) && action.Id != null)
                {
                    valid = userActionMapper.InsertUserAction(action);
                }
                else
                    return false;
            }
            else
                return false;

            return valid;
        }
    }
}
