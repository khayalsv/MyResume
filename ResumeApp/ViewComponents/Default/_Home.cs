using Microsoft.AspNetCore.Mvc;
using ResumeApp.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApp.ViewComponents.Default
{
    public class _Home :ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;

        public _Home(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _unitOfWork.HomeRepository.GetAllList();
            return View(values);
        }
    }
}
