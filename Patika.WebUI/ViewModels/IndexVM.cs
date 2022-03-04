using Patika.DAL.Entities;
using System.Collections.Generic;

namespace Patika.WebUI.ViewModels
{
    public class IndexVM
    {
        public IEnumerable<Slider> Slider { get; set; }
        public IEnumerable<Portfolio> LatestPortfolio { get; set; }
        public IEnumerable<Portfolio> ListPortfolio { get; set; }
        public IEnumerable<Blog> Blog { get; set; }
        public IEnumerable<Blog> LatestBlog { get; set; }
        public IEnumerable<Portfolio> Portfolio { get; set; }
        public IEnumerable<PortfolioPicture> PortfolioPicture { get; set; }
        public IEnumerable<Country> ListCountry { get; set; }
        public Contact Contact { get; set; }
    }
}
