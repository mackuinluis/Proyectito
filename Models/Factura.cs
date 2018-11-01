using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace demomvc.Models
{
    public class Factura
    {
        public int ID { get; set; }
        public string CodigoFactura { get; set; }
        public string PlacaTracto { get; set; }
        public string PlacaCarreta { get; set; }
        public int CodigoConductor { get; set; }
        public string Origen { get; set; }
        public string FechaSalida { get; set; }
        public string Destino { get; set; }
        public string FechaDestino { get; set; }
        public int CodigoCarga { get; set; }
        public string FechaEntregaDocumento { get; set; }
        public double MontoFacturado { get; set; }
        public string Estado { get; set; }
        public string FechaCobrado { get; set; }
        public double MontoCobrado { get; set; }


    }

}