using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace demomvc.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Ingrese Nombre")]
		[StringLength(40)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese Apellido")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Ingrese Usuario")]
        public string Usu { get; set; }
        [Required(ErrorMessage = "Ingrese Contraseña")]
        public string Contraseña { get; set; }
        [Compare(nameof(Contraseña),ErrorMessage = "Confirmación Incorrecta")] 
        public string ConfirmarContraseña { get; set;}
        [Required(ErrorMessage = "Ingrese Correo")]
        public string Correo { get; set; }
        [Compare(nameof(Correo),ErrorMessage = "Confirmación Incorrecta")] 
        public string ConfirmarCorreo { get; set;}
        [Required(ErrorMessage = "Ingrese Celular")]
        public int Celular { get; set; }
        public string Nacimiento { get; set; }
    }
}