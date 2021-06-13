using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;

namespace Veterinaria.Controlador
{
    public class AnimalControlador : IControlador<Animale>
    {
        private readonly VeterinariaEntities db;

        public AnimalControlador()
        {
            db = new VeterinariaEntities();
        }

        public Animale Obtener(int id)
        {
       
            return db.Animales.FirstOrDefault(a => a.ID == id);

        }

        public List<AnimalDto> ObtenerTodos()
        {
            var _result = db.Animales.ToList();

            List<AnimalDto> _animal = new List<AnimalDto>();

            _result.ForEach(a =>
            {
                _animal.Add(new AnimalDto()
                {
                    Id = a.ID,
                    NombreAnimal = a.Nombre,
                    //TipoanimalId = a.TipoanimalId,
                    TipoAnimalNombre = a.Tipo_Animal.Nombre,
                    //razaId = a.razaId,
                    RazaId = a.Raza.Id,
                    Edad = a.Edad,
                    NombrePropietario = a.Cliente.Nombre,
                    Direccion = a.Direccion,
                    Inactivo = a.Inactivo,

                });
            });

            return _animal;
        }

        public Animale Agregar(Animale entidad)
        {
            if (entidad != null)
            {
                db.Animales.Add(entidad);
                db.SaveChanges();


            }

            return entidad;

        }

        public void Editar(Animale entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var animal = db.Animales.Find(entidad);
            if (animal != null)
            {
                db.Animales.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Animale entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var animal = db.Animales.Find(entidad);
            if (animal != null)
            {
                animal.Inactivo = true;

                db.Animales.AddOrUpdate(animal);
                db.SaveChanges();
            }

        }

    }
}
