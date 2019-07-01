using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCard.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int AccountTypeID { get; set; }
        public double Balance { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }       
        

    }
}
