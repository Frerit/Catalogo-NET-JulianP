using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Entity;
using Catalogo.Entity.DTO;

namespace Catalogo.Data
{
    class CategoriaData
    {
        private CatalogoModel _context = new CatalogoModel();
        public List<CategoriaDTO> ListarCategorias()
        {
            var categoria = (from c in _context.Categoria
                             select new CategoriaDTO
                             {
                                 Id = c.Id,
                                 Descripcion = c.Descripcion,
                                 Estado = c.Estado.Value
                             }).ToList() ;

            return categoria;
        }

        public bool CrearCategoria(CategoriaDTO_Crear categoriadto_crear)
        {
            var categoria = new Categoria
            {
                Descripcion = categoriadto_crear.Descripcion,
                Estado = categoriadto_crear.Estado
            };
            _context.Categoria.Add(categoria);
            return true;
        }

        public bool EditarCategoria(CategoriaDTO_Update categoriadto_update)
        {
            var entity = _context.Categoria.Find(categoriadto_update.Id);
            entity.Descripcion = categoriadto_update.Descripcion;
            entity.Estado = categoriadto_update.Estado;
                
            _context.SaveChanges();
            return true;
        }

        public bool CambiardeEstado(CategoriaDTO_CambioEstado categoriadto_estado)
        {
            var categoria = _context.Categoria.Find(categoriadto_estado.Id);
            categoria.Estado = categoriadto_estado.Estado;
            _context.SaveChanges();
            return true;
        }

        public bool EliminarCategoria(CategoriaDTO_Delete categoriadto_delete)
        {
            var categoria = _context.Categoria.Find(categoriadto_delete.Id);
            _context.Categoria.Remove(categoria);
            _context.SaveChanges();
            return true;
        }
    }
}
