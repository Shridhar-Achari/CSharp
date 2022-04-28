using System;
using System.Collections.Generic;

namespace API_Application.Models
{
    public partial class Order
    {
        public Order()
        {
            Products = new HashSet<Product>();
        }

        public int OrdId { get; set; }
        public DateTime OrdDate { get; set; }
        public int? CId { get; set; }

        public virtual Customer? CIdNavigation { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
