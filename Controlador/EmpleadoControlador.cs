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
    class EmpleadoControlador : IControlador<Empleado>
    {
        private readonly VeterinariaEntities db;
        public EmpleadoControlador()
        {
            db = new VeterinariaEntities();
        }

        public Empleado Obtener(int id)
        {
            return db.Empleados.FirstOrDefault(e => e.ID == id);

        }

        public List<EmpleadoDTO> ObtenerTodos()
        {
            var _result = db.Empleados.ToList();

            List<EmpleadoDTO> empleado = new List<EmpleadoDTO>();

            _result.ForEach(e =>
            {
                empleado.Add(new EmpleadoDTO()
                {
                    Id = e.ID,
                    Nombre = e.Nombre,
                    Apellido = e.Apellidos,
                    UsuarioId = e.UsuarioId,
                    CargoId= e.CargoId,
                    Sueldo = e.Sueldo,
                    Direccion = e.Direccion,
                    MunicipioId = e.MunicipioId,
                    Telefono = e.Telefono,
                    Cedula = e.Cedula,
                    Correo = e.Correo,
                    Inactivo = e.Inactivo,

                });
            });

            return empleado;
        }

        public Empleado Agregar(Empleado entidad)
        {
            if (entidad != null)
            {
                db.Empleados.Add(entidad);
                db.SaveChanges();


            }

            return entidad;

        }

        public void Editar(Empleado entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var empleado = db.Empleados.Find(entidad);
            if (empleado != null)
            {
                db.Empleados.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Empleado entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var empleado = db.Empleados.Find(entidad);
            if (empleado != null)
            {
                empleado.Inactivo = true;

                db.Empleados.AddOrUpdate(empleado);
                db.SaveChanges();
            }

        }

        
    }
}
