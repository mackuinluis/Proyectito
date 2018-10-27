using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace demomvc.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
		[StringLength(40)]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Usu { get; set; }
        
        public string Contraseña { get; set; }
        [Compare(nameof(Contraseña))] 
        public string ConfirmarContraseña { get; set;}
        public string Correo { get; set; }
        public string Celular { get; set; }
        public string Nacimiento { get; set; }
    }
}