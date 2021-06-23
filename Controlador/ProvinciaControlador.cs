using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;

namespace Veterinaria.Controlador
{
    public class ProvinciaControlador : IControlador<Provincia>
    {
        private readonly VeterinariaEntities db;

        public ProvinciaControlador()
        {
            db = new VeterinariaEntities();
        }

        public Provincia Obtener(int id)
        {
            return db.Provincias.FirstOrDefault(c => c.Id == id);

        }

        public List<ProvinciaDto> ObtenerTodos()
        {
            var _result = db.Provincias.ToList();

            List<ProvinciaDto> _Provincia = new List<ProvinciaDto>();

            _result.ForEach(c =>
            {
                _Provincia.Add(new ProvinciaDto()
                {
                    Id = c.Id,
                    Nombre = c.Nombre,
                    Inactivo = c.Inactivo,

                });
            });

            return _Provincia;
        }

        public List<ProvinciaDto> ObtenerTodos(string texto)
        {
            var _result = db.Provincias.Where(p => p.Nombre.Contains(texto)).ToList();

            List<ProvinciaDto> _Provincia = new List<ProvinciaDto>();

            _result.ForEach(c =>
            {
                _Provincia.Add(new ProvinciaDto()
                {
                    Id = c.Id,
                    Nombre = c.Nombre,
                    Inactivo = c.Inactivo,

                });
            });

            return _Provincia;
        }

        public Provincia Agregar(Provincia entidad)
        {
            if (entidad != null)
            {
                db.Provincias.Add(entidad);
                db.SaveChanges();

            }

            return entidad;

        }

        public void Editar(Provincia entidad)
        {
          
            var Provincia = db.Provincias.Single(p => p.Id == entidad.Id);
            if (Provincia != null)
            {
                db.Provincias.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Provincia entidad)
        {

            var Provincia = db.Provincias.Single(p => p.Id == entidad.Id);
            if (Provincia != null)
            {
                Provincia.Inactivo = true;

                db.Provincias.AddOrUpdate(Provincia);
                db.SaveChanges();
            }

        }

 
    }
}
