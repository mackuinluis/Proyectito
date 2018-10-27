using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace demomvc.Models
{
    public class Factura
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
		[StringLength(40)]
        public string CodigoFactura { get; set; }
        public string PlacaTracto { get; set; }
        public string PlacaCarreta { get; set; }
        public string CodigoConductor { get; set; }
        public string Origen { get; set; }
        public string FechaSalida { get; set; }
        public string Destino { get; set; }
        public string FechaDestino { get; set; }
        public string CodigoCarga { get; set; }
        public string FechaEntregaDocumento { get; set; }
        public string MontoFacturado { get; set; }
        public string Estado { get; set; }
        public string FechaCobrado { get; set; }
        public string MontoCobrado { get; set; }


    }

}