using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika.DAL.Entities
{
    public class Contact
    {
        public int ID { get; set; }

        [Column(TypeName = "varchar(50)"), Display(Name = "Ad"), StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "varchar(50)"), Display(Name = "Mail"), StringLength(50)]
        public string Mail { get; set; }
        [Column(TypeName = "varchar(50)"), Display(Name = "Şehir"), StringLength(50)]
        public string City { get; set; }

        [Column(TypeName = "varchar(50)"), Display(Name = "Başlık"), StringLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "varchar(150)"), Display(Name = "Açıklama"), StringLength(150)]
        public string Description { get; set; }

        [Display(Name = "Kayıt Tarihi")]
        public DateTime RecDate { get; set; }
    }
}
