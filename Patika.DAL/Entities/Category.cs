using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOfUs.DAL.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string Name { get; set; }


        [Display(Name = "Etkin")]
        public bool Enabled { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; } = new HashSet<SubCategory>();
    }
}
