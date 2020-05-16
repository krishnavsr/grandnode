using Grand.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grand.Web.Controllers
{
    public partial class HomeController : BasePublicController
    {
        PersonViewModel aperson = new PersonViewModel() {
            FirstName = "Wael",
            LastName = "kdouh"
        };
        public virtual IActionResult Index() => View(aperson);
        public IActionResult Blazor()
        {
            return View("_Host");
        }
    }
}
