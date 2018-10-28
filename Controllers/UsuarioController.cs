
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
    public class UsuariosController : Controller
    {
        private readonly MvcContext _context;

        public UsuariosController(MvcContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Usuarios(string searchString)
        {
             var usuarios = from m in _context.Usuario
                 select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                usuarios = usuarios.Where(u => u.Nombre.Contains(searchString));
            }
            
            return View(await usuarios.ToListAsync());
        }
    }
}



  

   

