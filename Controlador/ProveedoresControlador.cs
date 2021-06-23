using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;

namespace Veterinaria.Controlador
{
    public class ProveedoresControlador : IControlador<Proveedor>
    {
        private readonly VeterinariaEntities db;

        public ProveedoresControlador()
        {
            db = new VeterinariaEntities();

        }
        public Proveedor Obtener(int id)
        {
            return db.Proveedors.FirstOrDefault(c => c.ID == id);

        }

        public List<ProveedorDto> ObtenerTodos()
        {
            var _result = db.Proveedors.ToList();

            List<ProveedorDto> _proveedores = new List<ProveedorDto>();

            _result.ForEach(c =>
            {
                _proveedores.Add(new ProveedorDto()
                {
                    ID = c.ID,
                    Nombre = c.Nombre,
                    Direccion = c.Dirección,
                    Telefono = c.Telefono,
                    Inactivo = c.Inactivo

                });
            });

            return _proveedores;
        }

        public List<ProveedorDto> ObtenerTodos(string texto)
        {
            var _result = db.Proveedors.Where(p => p.Nombre.Contains(texto)).ToList();

            List<ProveedorDto> _proveedores = new List<ProveedorDto>();

            _result.ForEach(c =>
            {
                _proveedores.Add(new ProveedorDto()
                {
                    ID = c.ID,
                    Nombre = c.Nombre,
                    Direccion = c.Dirección,
                    Telefono = c.Telefono,
                    Inactivo = c.Inactivo

                });
            });

            return _proveedores;
        }

        public Proveedor Agregar(Proveedor entidad)
        {
            if (entidad != null)
            {
                db.Proveedors.Add(entidad);
                db.SaveChanges();


            }

            return entidad;
        }

        public void Borrar(Proveedor entidad)
        {
            var proveedor = db.Proveedors.Single(p => p.ID == entidad.ID);
            if (proveedor != null)
            {
                proveedor.Inactivo = true;

                db.Proveedors.AddOrUpdate(proveedor);
                db.SaveChanges();
            }
        }

        public void Editar(Proveedor entidad)
        {
            var proveedor = db.Proveedors.Single(p => p.ID == entidad.ID);
            if (proveedor != null)
            {
                db.Proveedors.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }
    }

}

