
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using demomvc.Models;

namespace demomvc.Controllers
{
    public class EmpresasController : Controller
    {
        private readonly MvcContext _context;

        public EmpresasController(MvcContext context)
        {
            _context = context;
        }

        public IActionResult Empresa()
        {
            return View();
        }
        public IActionResult Empresas()
        {
            return View();
        }
    }
}



  

   