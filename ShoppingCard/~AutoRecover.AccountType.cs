using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCard.Models
{
    public class AccountType
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
