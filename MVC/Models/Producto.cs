﻿using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Producto
    {
          [Key]
          public int Id { get; set; }
         public string Nombre { get; set; }
        public string Tipo { get; set; }
    }
}
