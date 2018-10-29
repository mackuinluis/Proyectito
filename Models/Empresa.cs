using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace demomvc.Models{
    public class Empresa{
        public int ID { get; set; }
        public string Gerente { get; set; }
        public int RUC { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Celular { get; set; }
        public int Telefono{ get; set; }
        public string Tipo { get; set; }
    }
}
//[Required(ErrorMessage = "Please enter last name")]
		//[StringLength(40)]
        // [Compare(nameof(Contraseña))] 