using System;
using System.Collections.Generic;

#nullable disable

namespace ChefItServerBL.Models
{
    public partial class User
    {
        public User()
        {
            Chefs = new HashSet<Chef>();
            Customers = new HashSet<Customer>();
        }

        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Pswd { get; set; }
        public int TypeId { get; set; }

        public virtual UserType Type { get; set; }
        public virtual ICollection<Chef> Chefs { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
