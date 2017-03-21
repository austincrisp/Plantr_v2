using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plantr_v2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AvgCompTime { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}