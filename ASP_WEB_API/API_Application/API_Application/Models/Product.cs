using System;
using System.Collections.Generic;

namespace API_Application.Models
{
    public partial class Product
    {
        public int PId { get; set; }
        public string PrdName { get; set; } = null!;
        public int Price { get; set; }
        public int? OId { get; set; }

        public virtual Order? OIdNavigation { get; set; }
    }
}
