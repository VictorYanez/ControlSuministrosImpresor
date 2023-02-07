using ControlSuministrosImpresor.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControlSuministrosImpresor.Controllers
{
    public class InstitucionController : Controller
    {
        public IActionResult Crear()
        { 
            return View();
        }

    
    [HttpPost]
     public IActionResult Crear(Institucion institucion)
    {
        return View();
    }

    }
}

