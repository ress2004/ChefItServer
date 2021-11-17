using System;
using System.Collections.Generic;

#nullable disable

namespace ChefItServerBL.Models
{
    public partial class ResevationStatus
    {
        public ResevationStatus()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
