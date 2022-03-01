using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOfUs.DAL.Entities
{
    public class Banner
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public string SafeImage => Image ?? "/img/images/no-image.png";

    }
}
