using Microsoft.AspNetCore.Mvc;
using ResumeApp.Data.Entities;
using ResumeApp.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _unitOfWork.HomeRepository.GetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Home home)
        {
            await _unitOfWork.HomeRepository.Add(home);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Home/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var values = await _unitOfWork.HomeRepository.Find(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Home home)
        {
            await _unitOfWork.HomeRepository.Update(home);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Home/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var values = await _unitOfWork.HomeRepository.Find(id);

            await _unitOfWork.HomeRepository.Delete(values);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Home/Index");
        }
    }
}
