using Microsoft.AspNetCore.Mvc;
using ResumeApp.Data.Entities;
using ResumeApp.UnitOfWork;
using System.Threading.Tasks;

namespace ResumeApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EducationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public EducationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _unitOfWork.EducationRepository.GetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Education education)
        {
            await _unitOfWork.EducationRepository.Add(education);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Education/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var values = await _unitOfWork.EducationRepository.Find(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Education education)
        {
            await _unitOfWork.EducationRepository.Update(education);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Education/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var values = await _unitOfWork.EducationRepository.Find(id);

            await _unitOfWork.EducationRepository.Delete(values);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Education/Index");
        }
    }
}
