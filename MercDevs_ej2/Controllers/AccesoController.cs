using Microsoft.AspNetCore.Mvc;
using Applogin.Models;
using MercDevs_ej2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.DotNet.Scaffolding.Shared.Project;

namespace MercDevs_ej2.Controllers
{
    public class AccesoController : Controller
    {
        private readonly MercydevsEjercicio2Context _mercydevsEjercicio2Context;
        public AccesoController(MercydevsEjercicio2Context mercydevsEjercicio2Context) 
        {
            _mercydevsEjercicio2Context = mercydevsEjercicio2Context;

        }
        [HttpGet]
        public IActionResult Ingreso()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ingreso(Ingreso modelo)
        {


            return RedirectToAction("Index", "Home") ;
        }

        
    }
}
