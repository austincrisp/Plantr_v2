using Plantr_v2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Net;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using System.IO;

namespace Plantr_v2.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Route("u/{userName}")]
        public ActionResult Index(string userName)
        {
            ApplicationUser userInstance = db.Users.Where(u => u.UserName == userName).FirstOrDefault();
            return View(userInstance);
        }

        public ActionResult Upload()
        {
            var uploadViewModel = new ImageUploadViewModel();
            return View(uploadViewModel);
        }

        [HttpPost]
        public ActionResult Upload(ImageUploadViewModel formData)
        {
            var uploadedFile = Request.Files[0];
            string filename = $"{DateTime.Now.Ticks}{uploadedFile.FileName}";
            var serverPath = Server.MapPath(@"~\Upload");
            var fullPath = Path.Combine(serverPath, filename);

            uploadedFile.SaveAs(fullPath);

            var uploadModel = new Upload
            {
                File = filename
            };

            db.Uploads.Add(uploadModel);
            db.SaveChanges();

            return View();
        }
    }
}