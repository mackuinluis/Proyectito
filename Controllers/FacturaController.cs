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
    public class FacturasController : Controller
    {
        private readonly MvcContext _context;

        public FacturasController(MvcContext context)
        {
            _context = context;
        }

        


        public IActionResult ModificarFactura()
        {
            return View();
        }
        
        public IActionResult EliminarFactura()
        {
            return View();
        }

       

       

         

         public IActionResult RegistrarFactura()
        {
            return View();
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegistrarFactura([Bind("CodigoFactura","PlacaTracto","PlacaCarreta","CodigoConductor","Origen","FechaSalida","Destino","FechaDestino","CodigoCarga","FechaEntregaDocumento","MontoFacturado","Estado","FechaCobrado","MontoCobrado")] Factura factura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(factura);
                await _context.SaveChangesAsync();
                return RedirectToAction("Facturas");
            }
            return View(factura);
        }
        public async Task<IActionResult> Facturas(string origen,string fDestino, string fEstado)
        {
             var facturas = from n in _context.Factura
                 select n;
            if (!String.IsNullOrEmpty(origen))
            { facturas = facturas.Where(f => f.Origen.Equals(origen)); } 
            if (!String.IsNullOrEmpty(fDestino))
            { facturas = facturas.Where(f => f.Destino.Equals(fDestino)); }      
            if (!String.IsNullOrEmpty(fEstado))
            { facturas = facturas.Where(f => f.Estado.Equals(fEstado)); }

            return View(await facturas.ToListAsync());
        }
        
    }
}