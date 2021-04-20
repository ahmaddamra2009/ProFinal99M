using Microsoft.AspNetCore.Mvc;
using ProFinal99.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProFinal99.ViewComponents
{
    public class ArticleViewComponent:ViewComponent
    {
        private readonly AppDbContext db;
        public ArticleViewComponent(AppDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.Articles.OrderByDescending(x => x.ArticleId).Take(3));
        }
    }
}
