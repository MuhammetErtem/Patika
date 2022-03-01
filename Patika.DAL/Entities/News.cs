using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOfUs.DAL.Entities
{
    public class News
    {
        public int ID { get; set; }

        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string Name { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [Display(Name = "Haber")]
        public string Descriptions { get; set; }

        [Display(Name = "Etkin")]
        public bool Enabled { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
