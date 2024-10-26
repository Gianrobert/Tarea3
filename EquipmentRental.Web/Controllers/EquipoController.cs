using Microsoft.AspNetCore.Mvc;

namespace EquipmentRental.Web.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
