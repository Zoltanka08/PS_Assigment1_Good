using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDAL.DataObjects
{
    public class AccountData
    {
        public int Id { get; set; }
        public string IBAN { get; set; }
        public double Balance { get; set; }
        public DateTime Startdate { get; set; }
        public int TyepId { get; set; }
        public int ClientId { get; set; }
    }
}
