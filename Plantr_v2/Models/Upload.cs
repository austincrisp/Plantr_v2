using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Plantr_v2.Models
{
    public class Upload
    {
        public int Id { get; set; }
        public string File { get; set; }

        public virtual string FilePath
        {
            get
            {
                return $"/Uploads/{File}";
            }
        }

    }

    public class ImageUploadViewModel
    {
        [Required]
        public HttpPostedFile File { get; set; }
    }
}