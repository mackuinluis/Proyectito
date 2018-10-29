
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
    public class CuentasController : Controller
    {
        private readonly MvcContext _context;

        public CuentasController(MvcContext context)
        {
            _context = context;
        }

        // GET: usuarios
        public async Task<IActionResult> Index(string searchString)
        {
             var usuarios = from m in _context.Usuario
                 select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                usuarios = usuarios.Where(u => u.Nombre.Contains(searchString));
            }
            
            return View(await usuarios.ToListAsync());
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nombre","Apellidos","Usu","Contraseña","ConfirmarContraseña","Correo","Celular","Nacimiento")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login");
            }
            return View(usuario);
        }

        

        // GET: Usuarios/Login
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            return View();
        }
        public IActionResult Conductor()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Conductor([Bind("Usuario","Licencia")] Conductor conductor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conductor);
                await _context.SaveChangesAsync();
                return RedirectToAction("Perfil");
            }
            return View(conductor);
        }
    }
}