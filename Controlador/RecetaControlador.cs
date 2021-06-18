using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;


namespace Veterinaria.Controlador
{
    class RecetaControlador : IControlador<Receta>
    {
       
            private readonly VeterinariaEntities db;

            public RecetaControlador()
            {
                db = new VeterinariaEntities();
            }

            public Receta Obtener(int id)
            {
                return db.Recetas.FirstOrDefault(r => r.Id == id);

            }

            public List<RecetaDTO> ObtenerTodos()
            {
                var _result = db.Recetas.ToList();

                List<RecetaDTO> receta = new List<RecetaDTO>();

                _result.ForEach(r =>
                {
                    receta.Add(new RecetaDTO()
                    {
                      Id = r.Id,
                      Animal = r.AnimalID,
                      TipoAnimalId = r.TipoAnimalId,
                      RazaId = r.RazaID,
                      Padecimiento = r.Padecimiento,
                      ProductoId = r.ProductoId,
                      Dosis = r.Dosis,
                      Personales = r.Personales,
                      Inactivo = r.Inactivo,

                    });
                });

                return receta;
            }

            public Receta Agregar(Receta entidad)
            {
                if (entidad != null)
                {
                    db.Recetas.Add(entidad);
                    db.SaveChanges();


                }

                return entidad;

            }

            public void Editar(Receta entidad)
            {
                //if (entidad == null) throw new Exception("Entidad Invalidad");

                var receta = db.Recetas.Find(entidad);
                if (receta != null)
                {
                    db.Recetas.AddOrUpdate(entidad);
                    db.SaveChanges();
                }
            }

            public void Borrar(Receta entidad)
            {
                //if (entidad == null) throw new Exception("Entidad Invalidad");

                var receta = db.Recetas.Find(entidad);
                if (receta != null)
                {
                    receta.Inactivo = true;

                    db.Recetas.AddOrUpdate(receta);
                    db.SaveChanges();
                }

            }

       
    }
}
