﻿using Microsoft.AspNetCore.Mvc;
using ProFinal99.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProFinal99.ViewComponents
{
    public class InstructorViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public InstructorViewComponent(AppDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.Instructors.OrderByDescending(x => x.InstructorId).ToList());
        }

    }
}
