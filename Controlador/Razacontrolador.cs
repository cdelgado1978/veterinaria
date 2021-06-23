using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;


namespace Veterinaria.Controlador
{
    public class RazaControlador : IControlador<Raza>
    {
        private readonly VeterinariaEntities db;

        public RazaControlador()
        {
            db = new VeterinariaEntities();
        }

        public Raza Obtener(int id)
        {

            return db.Razas.FirstOrDefault(r => r.Id == id);

        }

        public List<RazasDto> ObtenerTodos()
        {
            var _result = db.Razas.ToList();

            List<RazasDto> _raza = new List<RazasDto>();

            _result.ForEach(r =>
            {
                _raza.Add(item: new RazasDto()
                {
                    Id = r.Id,
                    Nombre = r.Nombre,
                    TipoAnimalNombre = r.Tipo_Animal.Nombre,
                    Inactivo = r.Inactivo,

                });
            });

            return _raza;
        }

        public List<RazasDto> ObtenerTodos(string texto)
        {
            var _result = db.Razas.Where(r => r.Nombre.Contains(texto)).ToList();

            List<RazasDto> _raza = new List<RazasDto>();

            _result.ForEach(r =>
            {
                _raza.Add(item: new RazasDto()
                {
                    Id = r.Id,
                    Nombre = r.Nombre,
                    TipoAnimalNombre = r.Tipo_Animal.Nombre,
                    Inactivo = r.Inactivo,

                });
            });

            return _raza;
        }

        public Raza Agregar(Raza entidad)
        {
            if (entidad != null)
            {
                db.Razas.Add(entidad);
                db.SaveChanges();

            }

            return entidad;

        }

        public void Editar(Raza entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var raza = db.Razas.Find(entidad);
            if (raza != null)
            {
                db.Razas.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Raza entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var raza = db.Razas.Find(entidad);
            if (raza != null)
            {
                raza.Inactivo = true;

                db.Razas.AddOrUpdate(raza);
                db.SaveChanges();
            }

        }

        
    }
}
