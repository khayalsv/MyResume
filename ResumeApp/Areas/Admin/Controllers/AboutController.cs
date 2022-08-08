using Microsoft.AspNetCore.Mvc;
using ResumeApp.Data.Entities;
using ResumeApp.UnitOfWork;
using System.Threading.Tasks;

namespace ResumeApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AboutController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _unitOfWork.AboutRepository.GetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(About about)
        {
            await _unitOfWork.AboutRepository.Add(about);
            await _unitOfWork.Commit();

            return Redirect("/Admin/About/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var values = await _unitOfWork.AboutRepository.Find(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(About about)
        {
            await _unitOfWork.AboutRepository.Update(about);
            await _unitOfWork.Commit();

            return Redirect("/Admin/About/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var values = await _unitOfWork.AboutRepository.Find(id);

            await _unitOfWork.AboutRepository.Delete(values);
            await _unitOfWork.Commit();

            return Redirect("/Admin/About/Index");
        }
    }

}
