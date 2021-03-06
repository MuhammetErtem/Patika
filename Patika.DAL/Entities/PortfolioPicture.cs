using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika.DAL.Entities
{
    [Table("PortfolioPicture")]

    public class PortfolioPicture
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar(30)"), Display(Name = "Kategori Adı"), StringLength(30), Required(ErrorMessage = "Kategori Boş Geçilemez...")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(150)"), Display(Name = "Kategori Adı"), StringLength(150), Required(ErrorMessage = "Kategori Boş Geçilemez...")]
        public string Path { get; set; }
        public int PortfolioID { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
