using System;
using System.Collections.Generic;

namespace API_Application.Models
{
    public partial class NewCust
    {
        public int? CustId { get; set; }
        public string? CustName { get; set; }
        public string? CustAddr { get; set; }
        public int? CustAge { get; set; }
    }
}
