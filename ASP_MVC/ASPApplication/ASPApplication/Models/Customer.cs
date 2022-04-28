using System;
using System.Collections.Generic;

namespace ASPApplication.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustId { get; set; }
        public string CustName { get; set; } = null!;
        public string CustAddr { get; set; } = null!;
        public int? CustAge { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
