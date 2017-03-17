using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plantr_v2.Models
{
    public class Soul
    {
        public int Id { get; set; }

        // Name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Address Info
        public string Address { get; set; }
        public int? AptNumber { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public string Phone { get; set; }

        // Additional Comments
        public string Comments { get; set; }
    }
}