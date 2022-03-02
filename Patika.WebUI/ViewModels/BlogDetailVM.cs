using Patika.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Patika.WebUI.ViewModels
{
    public class BlogDetailVM
    {
        public IEnumerable<Blog> SimilarBlogs { get; set; }
        public Blog Blog { get; set; }
    }
}
