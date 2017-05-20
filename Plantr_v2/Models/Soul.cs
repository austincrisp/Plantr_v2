using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Plantr_v2.Models
{
    public class Soul
    {
        public int Id { get; set; }

        // Name
        [Required(ErrorMessage = "A First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "A Last Name is Required")]
        public string LastName { get; set; }

        // Address Info
        [Required(ErrorMessage = "An Address is Required")]
        public string Address { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string AptNumber { get; set; }

        [Required(ErrorMessage = "A City is Required")]
        public string City { get; set; }

        [Required(ErrorMessage = "A Zip Code is Required")]
        public int Zip { get; set; }

        public string Phone { get; set; }
    }
}