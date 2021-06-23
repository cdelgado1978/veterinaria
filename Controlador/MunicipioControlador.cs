using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;

namespace Veterinaria.Controlador
{
    public class MunicipioControlador : IControlador<Municipio>
    {

        private readonly VeterinariaEntities db;

        public MunicipioControlador()
        {
            db = new VeterinariaEntities();
        }

        public Municipio Obtener(int id)
        {
            return db.Municipios.FirstOrDefault(c => c.Id == id);

        }

        public List<MunicipioDto> ObtenerTodos()
        {
            var _result = db.Municipios.ToList();

            List<MunicipioDto> _Municipio = new List<MunicipioDto>();

            _result.ForEach(c =>
            {
                _Municipio.Add(new MunicipioDto()
                {
                    Id = c.Id,
                    Nombre = c.Nombre,
                    Inactivo = c.Inactivo,
                    ProvinciaId = c.ProvinciaId,
                    ProvinciaNombre = c.Provincia.Nombre

                });
            });

            return _Municipio;
        }

        public List<MunicipioDto> ObtenerTodos(string texto)
        {
            var _result = db.Municipios.Where(p => p.Nombre.Contains(texto)).ToList();

            List<MunicipioDto> _Municipio = new List<MunicipioDto>();

            _result.ForEach(c =>
            {
                _Municipio.Add(new MunicipioDto()
                {
                    Id = c.Id,
                    Nombre = c.Nombre,
                    Inactivo = c.Inactivo,
                    ProvinciaId = c.ProvinciaId,
                    ProvinciaNombre = c.Provincia.Nombre

                });
            });

            return _Municipio;
        }

        public Municipio Agregar(Municipio entidad)
        {
            if (entidad != null)
            {
                db.Municipios.Add(entidad);
                db.SaveChanges();

            }

            return entidad;

        }

        public void Editar(Municipio entidad)
        {

            var Municipio = db.Municipios.Single(p => p.Id == entidad.Id);
            if (Municipio != null)
            {
                db.Municipios.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Municipio entidad)
        {

            var Municipio = db.Municipios.Single(p => p.Id == entidad.Id);
            if (Municipio != null)
            {
                Municipio.Inactivo = true;

                db.Municipios.AddOrUpdate(Municipio);
                db.SaveChanges();
            }

        }
    }
}
