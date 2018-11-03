
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
        

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nombre","Apellidos","Usu","Contraseña","ConfirmarContraseña","Correo","ConfirmarCorreo","Celular","Nacimiento")] Usuario usuario)
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
        

public async Task<IActionResult> Login(string conectado)
        {
             var usuarios = from m in _context.Usuario
                 select m;

            if (!String.IsNullOrEmpty(conectado))
            {
                usuarios = usuarios.Where(u => u.Usu.Equals(conectado));
                Conservar(conectado);
                return RedirectToAction("Perfil");
            }
            
            return View(await usuarios.ToListAsync());
        }
        public async Task<IActionResult> Perfil(string conectado)
        {
            
            var usuarios = from m in _context.Usuario
                 select m;

            Conservar(conectado);
                usuarios = usuarios.Where(u => u.Usu.Equals(conectado));
                
           
            
            return View(await usuarios.ToListAsync());
        }
        
        public void Conservar(string conectado){
            string conservado=conectado;
            
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
        
        public IActionResult CrearEmpresa()
        {
            return RedirectToAction("CrearEmpresa", "Empresas");
        }
        public IActionResult Empresa()
        {
            return RedirectToAction("Empresa", "Empresas");
        }
    }
}