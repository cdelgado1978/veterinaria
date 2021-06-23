using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;

namespace Veterinaria.Controlador
{
    public class TipoAnimalControlador
    {
        private readonly VeterinariaEntities db;

        public TipoAnimalControlador()
        {
            db = new VeterinariaEntities();
        }

        public Tipo_Animal Obtener(int id)
        {

            return db.Tipo_Animal.FirstOrDefault(t => t.Id == id);

        }

        public List<TipoAnimalDto> ObtenerTodos()
        {
            var _result = db.Tipo_Animal.ToList();

            List<TipoAnimalDto> _tipoanimal = new List<TipoAnimalDto>();

            _result.ForEach(t =>
            {
                _tipoanimal.Add(item: new TipoAnimalDto()
                {
                    Id = t.Id,
                    Nombre = t.Nombre,

                    Inactivo = t.Inactivo,

                });
            });

            return _tipoanimal;
        }

        public List<TipoAnimalDto> ObtenerTodos(string texto)
        {
            var _result = db.Tipo_Animal.Where(ta => ta.Nombre.Contains(texto)).ToList();

            List<TipoAnimalDto> _tipoanimal = new List<TipoAnimalDto>();

            _result.ForEach(t =>
            {
                _tipoanimal.Add(item: new TipoAnimalDto()
                {
                    Id = t.Id,
                    Nombre = t.Nombre,
                    Inactivo = t.Inactivo,

                });
            });

            return _tipoanimal;
        }

        public Tipo_Animal Agregar(Tipo_Animal entidad)
        {
            if (entidad != null)
            {
                db.Tipo_Animal.Add(entidad);
                db.SaveChanges();


            }

            return entidad;

        }

        public void Editar(Tipo_Animal entidad)
        {

            var tipo = db.Tipo_Animal.Single(ta => ta.Id == entidad.Id);
            if (tipo != null)
            {
                db.Tipo_Animal.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Tipo_Animal entidad)
        {
            
            var tipo = db.Tipo_Animal.Single(ta => ta.Id == entidad.Id);
            if (tipo != null)
            {
                tipo.Inactivo = true;

                db.Tipo_Animal.AddOrUpdate(tipo);
                db.SaveChanges();
            }

        }


    }
}

