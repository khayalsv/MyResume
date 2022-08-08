using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ResumeApp.Data;
using ResumeApp.Models;
using ResumeApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext _myContext;

        public HomeController(MyContext myContext)
        {
            _myContext = myContext;
        }

        public async Task<IActionResult> Index()
        {
            var vM = new ALLVM
            {
                Abouts = await _myContext.Abouts.ToListAsync(),
                Services = await _myContext.Services.ToListAsync(),
                Educations = await _myContext.Educations.ToListAsync(),
                Experiences = await _myContext.Experiences.ToListAsync(),
                Homes = await _myContext.Homes.ToListAsync(),
                Languages = await _myContext.Languages.ToListAsync(),
                Portfolios = await _myContext.Portfolios.ToListAsync(),
                Programmings = await _myContext.Programmings.ToListAsync()
            };

            return View(vM);
        }

    }
}
