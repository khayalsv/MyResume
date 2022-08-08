using Microsoft.AspNetCore.Mvc;
using ResumeApp.UnitOfWork;
using System.Threading.Tasks;

namespace ResumeApp.ViewComponents.Default
{
    public class _Portfolio : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;

        public _Portfolio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _unitOfWork.PortfolioRepository.GetAllList();
            return View(values);
        }
    }
}
