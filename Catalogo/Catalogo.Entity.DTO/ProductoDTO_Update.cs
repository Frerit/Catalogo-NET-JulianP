using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Entity.DTO
{
    public class ProductoDTO_Update
    {
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public bool Activo { get; set; }
    }
}
