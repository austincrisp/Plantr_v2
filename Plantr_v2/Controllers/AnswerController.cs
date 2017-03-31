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
        public ActionResult AnswerOneIndex(Answer answer, int id)
        {
            answer.SoulId = (int)TempData["SoulId"];
            return View(db.Answers.Where(a => a.CourseId == 1 && a.SoulId == id).ToList());
        }

        // GET: Answer/Create
        public ActionResult AnswerOneCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AnswerOneCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
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
        public ActionResult AnswerTwoIndex(Answer answer, int id)
        {
            answer.SoulId = (int)TempData["SoulId"];
            return View(db.Answers.Where(a => a.CourseId == 2 && a.SoulId == id).ToList());
        }

        // GET: Answer/Create
        public ActionResult AnswerTwoCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AnswerTwoCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen")] Answer answer)
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
        public ActionResult AnswerThreeIndex(Answer answer, int id)
        {
            answer.SoulId = (int)TempData["SoulId"];
            return View(db.Answers.Where(a => a.CourseId == 3 && a.SoulId == id).ToList());
        }

        // GET: Answer/Create
        public ActionResult AnswerThreeCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AnswerThreeCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
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
        public ActionResult AnswerFourIndex(Answer answer, int id)
        {
            answer.SoulId = (int)TempData["SoulId"];
            return View(db.Answers.Where(a => a.CourseId == 4 && a.SoulId == id).ToList());
        }

        // GET: Answer/Create
        public ActionResult AnswerFourCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AnswerFourCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
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
        public ActionResult AnswerFivendex(Answer answer, int id)
        {
            answer.SoulId = (int)TempData["SoulId"];
            return View(db.Answers.Where(a => a.CourseId == 5 && a.SoulId == id).ToList());
        }

        // GET: Answer/Create
        public ActionResult AnswerFiveCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AnswerFiveCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
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
        public ActionResult AnswerSixIndex(Answer answer, int id)
        {
            answer.SoulId = (int)TempData["SoulId"];
            return View(db.Answers.Where(a => a.CourseId == 6 && a.SoulId == id).ToList());
        }

        // GET: Answer/Create
        public ActionResult AnswerSixCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AnswerSixCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
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
        public ActionResult AnswerSevenIndex(Answer answer, int id)
        {
            answer.SoulId = (int)TempData["SoulId"];
            return View(db.Answers.Where(a => a.CourseId == 7 && a.SoulId == id).ToList());
        }

        // GET: Answer/Create
        public ActionResult AnswerSevenCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AnswerSevenCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen")] Answer answer)
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
        public ActionResult AnswerEightIndex(Answer answer, int id)
        {
            answer.SoulId = (int)TempData["SoulId"];
            return View(db.Answers.Where(a => a.CourseId == 8 && a.SoulId == id).ToList());
        }

        // GET: Answer/Create
        public ActionResult AnswerEightCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AnswerEightCreate([Bind(Include = "Id,SoulId,AnswerOne,AnswerTwo,AnswerThree,AnswerFour,AnswerFive,AnswerSix,AnswerSeven,AnswerEight,AnswerNine,AnswerTen,AnswerEleven,AnswerTwelve,AnswerThirteen,AnswerFourteen,AnswerFifteen,AnswerSixteen,AnswerSeventeen,AnswerEighteen,AnswerNineteen,AnswerTwenty")] Answer answer)
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
    