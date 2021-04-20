﻿using Microsoft.AspNetCore.Mvc;
using ProFinal99.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProFinal99.ViewComponents
{
    public class CourseViewComponent :ViewComponent
    {
        private readonly AppDbContext db;
        public CourseViewComponent(AppDbContext _db)
        {
            db = _db;
        }


        public IViewComponentResult Invoke()
        {

            return View(db.Courses.ToList());
        }
    }
}
