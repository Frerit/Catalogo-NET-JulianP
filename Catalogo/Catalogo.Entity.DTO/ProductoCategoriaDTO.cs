using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Entity.DTO
{
    public class ProductoCategoriaDTO
    {
        [Key]
        public long IdProductoCategoria { get; set; }

        public long IdProducto { get; set; }

        public int IdCategoria { get; set; }


    }
}
