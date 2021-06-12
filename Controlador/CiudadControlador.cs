using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Modelo;

namespace Veterinaria.Controlador
{
    public class CiudadControlador : IControlador<Ciudad>
    {
        private readonly VeterinariaEntities db;

        public CiudadControlador()
        {
            db = new VeterinariaEntities();
        }

        public Ciudad Obtener(int id)
        {
            return db.Ciudads.FirstOrDefault(c => c.ID == id);

        }

        public List<CiudadDto> ObtenerTodos()
        {
            var _result = db.Ciudads.ToList();

            List<CiudadDto> _ciudad = new List<CiudadDto>();

            _result.ForEach(c =>
            {
                _ciudad.Add(new CiudadDto()
                {
                    Id = c.ID,
                    Nombre = c.Nombre,
                    Inactivo = c.Inactivo,

                });
            });

            return _ciudad;
        }

        public Ciudad Agregar(Ciudad entidad)
        {
            if (entidad != null)
            {
                db.Ciudads.Add(entidad);
                db.SaveChanges();


            }

            return entidad;

        }

        public void Editar(Ciudad entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var ciudad = db.Cargos.Find(entidad);
            if (ciudad != null)
            {
                db.Ciudads.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Ciudad entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var ciudad = db.Ciudads.Find(entidad);
            if (ciudad != null)
            {
                ciudad.Inactivo = true;

                db.Ciudads.AddOrUpdate(ciudad);
                db.SaveChanges();
            }

        }

 
    }
}
