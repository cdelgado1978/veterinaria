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
    class HistorialRecestasControlador : IControlador<Historial_Recetas>
    {
        private readonly VeterinariaEntities db;

        public HistorialRecestasControlador()
        {
            db = new VeterinariaEntities();
        }

        public Historial_Recetas Obtener(int id)
        {
            return db.Historial_Recetas.FirstOrDefault(hr => hr.ID == id);

        }

        public List<HistorialRecetasDTO> ObtenerTodos()
        {
            var _result = db.Historial_Recetas.ToList();

            List<HistorialRecetasDTO> historial_recetas = new List<HistorialRecetasDTO>();

            _result.ForEach(hr =>
            {
                historial_recetas.Add(new HistorialRecetasDTO()
                {
                   id = hr.ID,
                   RecetaId = hr.RecetaId,
                   AnimalId = hr.AnimalId,
                   Fecha = hr.Fecha,
                   Diagnostico = hr.Diagnostico,
                   Hora = hr.Hora,
                   Tratamiento = hr.Tratamiento,
                   Inactivo = hr.Inactivo,


                });
            });

            return historial_recetas;
        }

        public Historial_Recetas Agregar(Historial_Recetas entidad)
        {
            if (entidad != null)
            {
                db.Historial_Recetas.Add(entidad);
                db.SaveChanges();


            }

            return entidad;

        }

        public void Editar(Historial_Recetas entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var historial_recetas = db.Historial_Recetas.Find(entidad);
            if (historial_recetas != null)
            {
                db.Historial_Recetas.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Historial_Recetas entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var historial_recetas = db.Historial_Recetas.Find(entidad);
            if (historial_recetas != null)
            {
                historial_recetas.Inactivo = true;

                db.Historial_Recetas.AddOrUpdate(historial_recetas);
                db.SaveChanges();
            }

        }

      
    }
}
