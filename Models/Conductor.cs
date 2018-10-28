using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace demomvc.Models{
 public class Conductor{
     public int ID { get; set; }
     public string Usuario { get;set;}
     public string Licencia { get; set;}
 }

}