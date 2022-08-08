using Microsoft.AspNetCore.Mvc;
using ResumeApp.UnitOfWork;
using System.Threading.Tasks;

namespace ResumeApp.ViewComponents.Default
{
    public class _About : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
