using Microsoft.AspNetCore.Mvc;
using ResumeApp.Data.Entities;
using ResumeApp.UnitOfWork;
using System.Threading.Tasks;

namespace ResumeApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LanguageController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public LanguageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _unitOfWork.LanguageRepository.GetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Language language)
        {
            await _unitOfWork.LanguageRepository.Add(language);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Language/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var values = await _unitOfWork.LanguageRepository.Find(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Language language)
        {
            await _unitOfWork.LanguageRepository.Update(language);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Language/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var values = await _unitOfWork.LanguageRepository.Find(id);

            await _unitOfWork.LanguageRepository.Delete(values);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Language/Index");
        }
    }
}
