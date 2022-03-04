using Patika.DAL.Entities;
using Patika.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Patika.DAL.DbContexts;

namespace Patika.WebUI.Controllers
{
    public class BlogController : Controller
    {
        SqlContext db;
        public BlogController(SqlContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {

            return View();
        }

        [Route("/blog/{Title}-{id}")]
        public IActionResult Detail(string title, int id)
        {

            Blog blog = db.Blog.Include(i => i.BlogPictures).FirstOrDefault(x => x.ID == id) ?? null;
            if (blog != null)
            {
                BlogDetailVM blogdetailVM = new BlogDetailVM
                {
                    Blog = blog,
                };
                return View(blogdetailVM);
            }
            else return Redirect("/");
        }
    }
}