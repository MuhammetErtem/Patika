using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOfUs.DAL.Entities
{
    public class SubCategory
    {
        [Display(Name = "Kategori")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        [Display(Name = "Etkin")]
        public bool Enabled { get; set; }

        public ICollection<Category> Categories { get; set; } = new HashSet<Category>();

    }
}
