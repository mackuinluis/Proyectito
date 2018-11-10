using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace demomvc.Models
{
    public class Factura
    {
        [Required(ErrorMessage = "Ingrese Nombres")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Ingrese Código de Factura")]
        public string CodigoFactura { get; set; }
        [Required(ErrorMessage = "Ingrese Placa del Tracto")]
        public string PlacaTracto { get; set; }
        [Required(ErrorMessage = "Ingrese Placa de Carreta")]
        public string PlacaCarreta { get; set; }
        [Required(ErrorMessage = "Ingrese Ingrese Codigo Del Conductor")]

        public int CodigoConductor { get; set; }
        [Required(ErrorMessage = "Ingrese Nombres Ingrese El Origen del Viaje")]
        public string Origen { get; set; }
        [Required(ErrorMessage = "Ingrese Nombres Ingrese La Fecha de Salida")]
        public string FechaSalida { get; set; }
        [Required(ErrorMessage = "Ingrese el Destino")]
        public string Destino { get; set; }
        [Required(ErrorMessage = "Ingrese la Fecha Del Destino")]
        public string FechaDestino { get; set; }
        [Required(ErrorMessage = "Ingrese Código de Carga")]
        public int CodigoCarga { get; set; }
        [Required(ErrorMessage = "Ingrese la Fecha de Entrega Del Documento")]
        public string FechaEntregaDocumento { get; set; }
        [Required(ErrorMessage = "Ingrese el Monto de la Factura")]
        public double MontoFacturado { get; set; }
        [Required(ErrorMessage = "Ingrese el Estado")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Ingrese la Fecha Cobrado")]
        public string FechaCobrado { get; set; }
        [Required(ErrorMessage = "Ingrese Monto Cobrado")]
        public double MontoCobrado { get; set; }
        


    }

}