using Microsoft.AspNetCore.Mvc;
using ResumeApp.Data.Entities;
using ResumeApp.UnitOfWork;
using System.Threading.Tasks;

namespace ResumeApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortfolioController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PortfolioController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _unitOfWork.PortfolioRepository.GetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Portfolio portfolio)
        {
            await _unitOfWork.PortfolioRepository.Add(portfolio);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Portfolio/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var values = await _unitOfWork.PortfolioRepository.Find(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Portfolio portfolio)
        {
            await _unitOfWork.PortfolioRepository.Update(portfolio);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Portfolio/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var values = await _unitOfWork.PortfolioRepository.Find(id);

            await _unitOfWork.PortfolioRepository.Delete(values);
            await _unitOfWork.Commit();

            return Redirect("/Admin/Portfolio/Index");
        }
    }
}
