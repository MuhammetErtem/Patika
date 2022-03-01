using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika.DAL.Entities
{
    [Table("Video")]
    public class Video
    {
        public int ID { get; set; }

        [Column(TypeName = "varchar(50)"), Display(Name = "Ad"), StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "varchar(150)"), Display(Name = "Video Dosyası"), StringLength(150)]
        public string Picture { get; set; }

        [Column(TypeName = "varchar(150)"), Display(Name = "Sayfa Adresi"), StringLength(150)]
        public string Link { get; set; }

        [Display(Name = "Görüntülenme Sırası")]
        public int DisplayIndex { get; set; }
    }
}
