using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Modelo;

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
                    id = t.ID,
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
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var tipo = db.Tipo_Animal.Find(entidad);
            if (tipo != null)
            {
                db.Tipo_Animal.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Tipo_Animal entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var tipo = db.Tipo_Animal.Find(entidad);
            if (tipo != null)
            {
                tipo.Inactivo = true;

                db.Tipo_Animal.AddOrUpdate(tipo);
                db.SaveChanges();
            }

        }


    }
}

