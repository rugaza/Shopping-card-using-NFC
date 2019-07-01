using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCard.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Fisrtname { get; set; }
        public String Lastname { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Address { get; set; }
        public String Usertype { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
