using System;
using System.Collections.Generic;

#nullable disable

namespace ChefItServerBL.Models
{
    public partial class ExpertiseType
    {
        public ExpertiseType()
        {
            Chefs = new HashSet<Chef>();
        }

        public int Id { get; set; }
        public string Ename { get; set; }

        public virtual ICollection<Chef> Chefs { get; set; }
    }
}
