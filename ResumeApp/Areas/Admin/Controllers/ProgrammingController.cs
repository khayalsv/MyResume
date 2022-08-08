using Microsoft.AspNetCore.Mvc;
using ResumeApp.Data.Entities;
using ResumeApp.UnitOfWork;
using System.Threading.Tasks;

namespace ResumeApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProgrammingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProgrammingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _unitOfWork.ProgrammingRepository.GetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Programming programming)
        {
            await _unitOfWork.ProgrammingRepository.Add(programming);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Programming/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var values = await _unitOfWork.ProgrammingRepository.Find(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Programming programming)
        {
            await _unitOfWork.ProgrammingRepository.Update(programming);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Programming/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var values = await _unitOfWork.ProgrammingRepository.Find(id);

            await _unitOfWork.ProgrammingRepository.Delete(values);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Programming/Index");
        }
    }
}
