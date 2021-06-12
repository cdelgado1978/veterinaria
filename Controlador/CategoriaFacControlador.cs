using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Modelo;

namespace Veterinaria.Controlador
{
    public class CategoriaFacControlador : IControlador<Categoria_Factura>
    {
        private readonly VeterinariaEntities db;

        public CategoriaFacControlador()
        {
            db = new VeterinariaEntities();
        }

        public Categoria_Factura Obtener(int id)
        {
            return db.Categoria_Factura.FirstOrDefault(c => c.ID == id);

        }

        public List<CategoriaFacDTO> ObtenerTodos()
        {
            var _result = db.Categoria_Factura.ToList();

            List<CategoriaFacDTO> _categoriaFac = new List<CategoriaFacDTO>();

            _result.ForEach(c =>
            {
                _categoriaFac.Add(new CategoriaFacDTO()
                {
                    Id = c.ID,
                    Nombre = c.Nombre,
                    Inactivo = c.Inactivo,

                });
            });

            return _categoriaFac;
        }

        public Categoria_Factura Agregar(Categoria_Factura entidad)
        {
            if (entidad != null)
            {
                db.Categoria_Factura.Add(entidad);
                db.SaveChanges();


            }

            return entidad;

        }

        public void Editar(Categoria_Factura entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var categoriaFac = db.Categoria_Factura.Find(entidad);
            if (categoriaFac != null)
            {
                db.Categoria_Factura.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Categoria_Factura entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var categoriaFac = db.Categoria_Factura.Find(entidad);
            if (categoriaFac != null)
            {
                categoriaFac.Inactivo = true;

                db.Categoria_Factura.AddOrUpdate(categoriaFac);
                db.SaveChanges();
            }

        }

       
    }
}
