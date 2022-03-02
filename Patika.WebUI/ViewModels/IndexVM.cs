using Patika.DAL.Entities;
using System.Collections.Generic;

namespace Patika.WebUI.ViewModels
{
    public class IndexVM
    {
        public IEnumerable<Slider> Slider { get; set; }
        public IEnumerable<Portfolio> LatestPortfolio { get; set; }
        public IEnumerable<Portfolio> ListPortfolio { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Blog> LatestBlogs { get; set; }
        public Contact Contact { get; set; }
    }
}
