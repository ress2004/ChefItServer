using System;
using System.Collections.Generic;

#nullable disable

namespace ChefItServerBL.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Reservations = new HashSet<Reservation>();
            Reviews = new HashSet<Review>();
        }

        public int CustomerId { get; set; }
        public bool HasStove { get; set; }
        public string Username { get; set; }
        public string AddressLocation { get; set; }

        public virtual User UsernameNavigation { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
