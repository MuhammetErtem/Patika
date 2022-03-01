using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika.DAL.Entities
{
    [Table("Country")]
    public class Country
    {
        public int ID { get; set; }

        [Column(TypeName = "varchar(50)"), Display(Name = "Ad"), StringLength(50)]
        public string Name { get; set; }
        public ICollection<Portfolio> Portfolios { get; set; }


    }
}
