using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCard.Models
{
    public class TransactionType
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
