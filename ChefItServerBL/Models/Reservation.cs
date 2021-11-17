using System;
using System.Collections.Generic;

#nullable disable

namespace ChefItServerBL.Models
{
    public partial class Reservation
    {
        public int ReservationId { get; set; }
        public int ChefId { get; set; }
        public int CustomerId { get; set; }
        public int StatusId { get; set; }
        public DateTime Rdate { get; set; }
        public int NumOfGuests { get; set; }
        public int Price { get; set; }

        public virtual Chef Chef { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ResevationStatus Status { get; set; }
    }
}
