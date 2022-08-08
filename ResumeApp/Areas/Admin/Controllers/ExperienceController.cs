using Microsoft.AspNetCore.Mvc;
using ResumeApp.Data.Entities;
using ResumeApp.UnitOfWork;
using System.Threading.Tasks;

namespace ResumeApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExperienceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExperienceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _unitOfWork.ExperienceRepository.GetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Experience experience)
        {
            await _unitOfWork.ExperienceRepository.Add(experience);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Experience/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var values = await _unitOfWork.ExperienceRepository.Find(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Experience experience)
        {
            await _unitOfWork.ExperienceRepository.Update(experience);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Experience/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var values = await _unitOfWork.ExperienceRepository.Find(id);

            await _unitOfWork.ExperienceRepository.Delete(values);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Experience/Index");
        }
    }
}
