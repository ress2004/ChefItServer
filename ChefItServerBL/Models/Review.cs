using System;
using System.Collections.Generic;

#nullable disable

namespace ChefItServerBL.Models
{
    public partial class Review
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ChefId { get; set; }
        public int Rate { get; set; }

        public virtual Chef Chef { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
