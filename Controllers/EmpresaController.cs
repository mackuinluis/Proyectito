
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
//Ultimos Cambios
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegistrarEmpresa([Bind("Gerente","RUC","Nombre","Direccion","Celular","Telefono","Tipo")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empresa);
                await _context.SaveChangesAsync();
                return RedirectToAction("Empresas");
            }
            return View(empresa);
        }
        public async Task<IActionResult> Empresas(string searchString)
        {
             var empresas = from q in _context.Factura
                 select q;

            if (!String.IsNullOrEmpty(searchString))
            {
                empresas = empresas.Where(f => f.Nombre.Contains(searchString));
            }
            
            return View(await empresas.ToListAsync());
        }
    }
}



  

   