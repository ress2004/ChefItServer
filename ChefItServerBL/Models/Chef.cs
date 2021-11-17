using System;
using System.Collections.Generic;

#nullable disable

namespace ChefItServerBL.Models
{
    public partial class Chef
    {
        public Chef()
        {
            Reservations = new HashSet<Reservation>();
            Reviews = new HashSet<Review>();
        }

        public int ChefId { get; set; }
        public int ExpertiseId { get; set; }
        public string Username { get; set; }
        public string DescriptionText { get; set; }
        public string GalleryUrl { get; set; }

        public virtual ExpertiseType Expertise { get; set; }
        public virtual User UsernameNavigation { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
