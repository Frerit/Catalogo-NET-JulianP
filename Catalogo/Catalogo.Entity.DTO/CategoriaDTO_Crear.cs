﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Entity.DTO
{
   public class CategoriaDTO_Crear
    {
       
        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
