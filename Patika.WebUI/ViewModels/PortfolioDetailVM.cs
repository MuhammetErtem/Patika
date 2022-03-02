using Patika.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Patika.WebUI.ViewModels
{
    public class PortfolioDetailVM
    {
        public IEnumerable<Portfolio> SimilarPortfolio { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
