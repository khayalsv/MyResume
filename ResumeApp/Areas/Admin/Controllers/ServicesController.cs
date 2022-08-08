using Microsoft.AspNetCore.Mvc;
using ResumeApp.Data.Entities;
using ResumeApp.UnitOfWork;
using System.Threading.Tasks;

namespace ResumeApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServicesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _unitOfWork.ServicesRepository.GetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Services services)
        {
            await _unitOfWork.ServicesRepository.Add(services);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Services/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var values = await _unitOfWork.ServicesRepository.Find(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Services services)
        {
            await _unitOfWork.ServicesRepository.Update(services);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Services/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var values = await _unitOfWork.ServicesRepository.Find(id);

            await _unitOfWork.ServicesRepository.Delete(values);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Services/Index");
        }
    }
}
