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
        public ActionResult ViewAnswerOneIndex()
        {
            return View(db.Answers.Where(a => a.CourseId == 1).ToList());
        }

        // GET: Answer/Create
        public ActionResult SubmitAnswerOneCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitAnswerOneCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                answer.SoulId = (int)TempData["SoulId"];
                answer.CourseId = 1;
                db.Answers.Add(answer);
                db.SaveChanges();
                return RedirectToAction("Details", "Soul", new { id = answer.SoulId });
            }

            return View(answer);
        }

        // GET: Answer
        public ActionResult ViewAnswerTwoIndex()
        {
            return View(db.Answers.Where(a => a.CourseId == 2).ToList());
        }

        // GET: Answer/Create
        public ActionResult SubmitAnswerTwoCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitAnswerTwoCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                answer.SoulId = (int)TempData["SoulId"];
                answer.CourseId = 2;
                db.Answers.Add(answer);
                db.SaveChanges();
                return RedirectToAction("Details", "Soul", new { id = answer.SoulId });
            }

            return View(answer);
        }

        // GET: Answer
        public ActionResult ViewAnswerThreeIndex()
        {
            return View(db.Answers.Where(a => a.CourseId == 3).ToList());
        }

        // GET: Answer/Create
        public ActionResult SubmitAnswerThreeCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitAnswerThreeCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                answer.SoulId = (int)TempData["SoulId"];
                answer.CourseId = 3;
                db.Answers.Add(answer);
                db.SaveChanges();
                return RedirectToAction("Details", "Soul", new { id = answer.SoulId });
            }

            return View(answer);
        }

        // GET: Answer
        public ActionResult ViewAnswerFourIndex()
        {
            return View(db.Answers.Where(a => a.CourseId == 4).ToList());
        }

        // GET: Answer/Create
        public ActionResult SubmitAnswerFourCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitAnswerFourCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                answer.SoulId = (int)TempData["SoulId"];
                answer.CourseId = 4;
                db.Answers.Add(answer);
                db.SaveChanges();
                return RedirectToAction("Details", "Soul", new { id = answer.SoulId });
            }

            return View(answer);
        }

        // GET: Answer
        public ActionResult ViewAnswerFivendex()
        {
            return View(db.Answers.Where(a => a.CourseId == 5).ToList());
        }

        // GET: Answer/Create
        public ActionResult SubmitAnswerFiveCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitAnswerFiveCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                answer.SoulId = (int)TempData["SoulId"];
                answer.CourseId = 5;
                db.Answers.Add(answer);
                db.SaveChanges();
                return RedirectToAction("Details", "Soul", new { id = answer.SoulId });
            }

            return View(answer);
        }

        // GET: Answer
        public ActionResult ViewAnswerSixIndex()
        {
            return View(db.Answers.Where(a => a.CourseId == 6).ToList());
        }

        // GET: Answer/Create
        public ActionResult SubmitAnswerSixCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitAnswerSixCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                answer.SoulId = (int)TempData["SoulId"];
                answer.CourseId = 6;
                db.Answers.Add(answer);
                db.SaveChanges();
                return RedirectToAction("Details", "Soul", new { id = answer.SoulId });
            }

            return View(answer);
        }

        // GET: Answer
        public ActionResult ViewAnswerSevenIndex()
        {
            return View(db.Answers.Where(a => a.CourseId == 7).ToList());
        }

        // GET: Answer/Create
        public ActionResult SubmitAnswerSevenCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitAnswerSevenCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                answer.SoulId = (int)TempData["SoulId"];
                answer.CourseId = 7;
                db.Answers.Add(answer);
                db.SaveChanges();
                return RedirectToAction("Details", "Soul", new { id = answer.SoulId });
            }

            return View(answer);
        }

        // GET: Answer
        public ActionResult ViewAnswerEightIndex()
        {
            return View(db.Answers.Where(a => a.CourseId == 8).ToList());
        }

        // GET: Answer/Create
        public ActionResult SubmitAnswerEightCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitAnswerEightCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                answer.SoulId = (int)TempData["SoulId"];
                answer.CourseId = 8;
                db.Answers.Add(answer);
                db.SaveChanges();
                return RedirectToAction("Details", "Soul", new { id = answer.SoulId });
            }

            return View(answer);
        }
    }
}
    