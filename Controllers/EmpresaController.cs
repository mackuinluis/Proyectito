
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
        



        public IActionResult CrearEmpresa()
        
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEmpresa([Bind("Gerente","RUC","Nombre","Direccion","Celular","Telefono","Tipo")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empresa);
                await _context.SaveChangesAsync();
                return RedirectToAction("Empresas");
            }
            return View(empresa);
        }


        public async Task<IActionResult> Empresas(string fTipo)
        {
             var empresas = from q in _context.Empresa
                 select q;

            if (!String.IsNullOrEmpty(fTipo))
            {
                empresas = empresas.Where(e => e.Tipo.Contains(fTipo));
            }
            
            return View(await empresas.ToListAsync());
        }
         public async Task<IActionResult> Empresa(string a)
        {
             var empresas = from q in _context.Empresa
                 select q;

            if (!String.IsNullOrEmpty(a))
            {
                empresas = empresas.Where(e => e.Nombre.Contains(a));
                return RedirectToAction("Empresa");
            }
            
            return View(await empresas.ToListAsync());
        }
    }
}



  

   