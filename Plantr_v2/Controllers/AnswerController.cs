using Plantr_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;

namespace Plantr_v2.Controllers
{
    public class AnswerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Answer
        public ActionResult Index()
        {
            return View(db.Answers.ToList());
        }

        // GET: Answer/Create
        public ActionResult SubmitAnswerOneCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitAnswerOneCreate([Bind(Include = "Id,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                answer.SoulId = soulId;
                answer.CourseId = 1;
                db.Answers.Add(answer);
                db.SaveChanges();
                return RedirectToAction("Details", "Soul", new { id = answer.SoulId });
            }

            return View(answer);
        }
    }
}