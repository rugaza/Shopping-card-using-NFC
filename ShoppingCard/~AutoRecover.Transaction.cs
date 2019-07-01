using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCard.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int TransactionTypeID { get; set; }
        public int UserId { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public string Receiver { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}
