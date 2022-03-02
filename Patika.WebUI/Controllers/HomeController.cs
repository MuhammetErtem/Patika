using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patika.DAL.DbContexts;
using Patika.WebUI.ViewModels;
using System.Linq;

namespace Patika.WebUI.Controllers
{
    public class HomeController : Controller
    {
        SqlContext db;
        public HomeController(SqlContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            IndexVM indexVM = new IndexVM
            {
                Slider = db.Slider,
                LatestBlogs = db.Blog.Include(i =>i.BlogPictures).OrderByDescending(o => o.ID).Take(3),
                ListPortfolio = db.Portfolio.Include(i => i.PortfolioPictures).OrderByDescending(o => o.ID).Take(2),

            };
            return View(indexVM);
        }
        
    }
}
