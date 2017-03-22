using Plantr_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plantr_v2.ViewModels
{
    public class SoulAnswer
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public Soul Soul { get; set; }

        public Course Course { get; set; }
        public Answer Answer { get; set; }

        public SoulAnswer(Soul soul, Course courseNumber)
        {
            Soul = soul;
            Course = courseNumber;
            Answer = db.Answers.SingleOrDefault(a => a.SoulId == Soul.Id && a.CourseId == Course.Id);
        }
    }
}