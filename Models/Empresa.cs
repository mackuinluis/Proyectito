using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace demomvc.Models
{
    public class Empresa
    {
        public int ID { get; set; }
        // [Compare(nameof(Usuario))] 
        public string Gerente { get; set; }
        [Required(ErrorMessage = "Ingrese RUC")]
        public int RUC { get; set; }
        [Required(ErrorMessage = "Ingrese Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese Direccion")]
        public string Direccion { get; set; }
        public int Celular { get; set; }
        public int Telefono { get; set; }
        [Required(ErrorMessage = "Seleccion un tipo")]
        public string Tipo { get; set; }
    }
}
//[Required(ErrorMessage = "Please enter last name")]
		//[StringLength(40)]
        // [Compare(nameof(Contraseña))] 