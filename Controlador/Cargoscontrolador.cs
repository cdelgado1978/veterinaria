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
    public class Cargocontrolador : IControlador<Cargo>
    {
        private readonly VeterinariaEntities db;

        public Cargocontrolador()
        {
            db = new VeterinariaEntities();
        }

        public Cargo Obtener(int id)
        {
            return db.Cargos.FirstOrDefault(c => c.ID == id);

        }

        public List<CargoDto> ObtenerTodos()
        {
            var _result = db.Cargos.ToList();

            List<CargoDto> _cargos = new List<CargoDto>();

            _result.ForEach(c =>
            {
                _cargos.Add(new CargoDto()
                {
                    Id=c.ID,
                    Nombre= c.Nombre,
                    Inactivo= c.Inactivo,

                });
            });

            return _cargos;
        }

        public Cargo Agregar(Cargo entidad)
        {
            if (entidad != null)
            {
                db.Cargos.Add(entidad);
                db.SaveChanges();


            }

            return entidad;

        }

        public void Editar(Cargo entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var cargo = db.Cargos.Find(entidad);
            if (cargo != null)
            {
                db.Cargos.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Cargo entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var cargos = db.Cargos.Find(entidad);
            if (cargos != null)
            {
                cargos.Inactivo = true;

                db.Cargos.AddOrUpdate(cargos);
                db.SaveChanges();
            }

        }

       
    }
}
