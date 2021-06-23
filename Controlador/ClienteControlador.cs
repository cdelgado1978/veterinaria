using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;

namespace Veterinaria.Controlador
{
    public class ClienteControlador : IControlador<Cliente>
    {
        private readonly VeterinariaEntities db;

        public ClienteControlador()
        {
            db = new VeterinariaEntities();
        }

        public Cliente Obtener(int id)
        {
            return db.Clientes.FirstOrDefault(c => c.ID == id);

        }

        public List<ClienteDTO> ObtenerTodos()
        {
            var _result = db.Clientes.ToList();

            List<ClienteDTO> _cliente = new List<ClienteDTO>();

            _result.ForEach(c =>
            {
                _cliente.Add(new ClienteDTO()
                {
                    Id = c.ID,
                    Nombre = c.Nombre,
                    Apellido= c.Apellidos,
                    NombreCompleto = $"{c.Nombre} {c.Apellidos}",
                    Cedula= c.Cedula,
                    Direccion= c.Direccion,
                    Telefono= c.Telefono,
                    Inactivo = c.Inactivo,
                    MunicipioId = c.MunicipioId,
                    MunicipioNombre = c.Municipio.Nombre,
                    ProvinciaNombre = c.Municipio.Provincia.Nombre

                });
            });

            return _cliente;
        }
        public List<ClienteDTO> ObtenerTodos(string texto)
        {
            var _result = db.Clientes.Where(c => c.Nombre.Contains(texto)).ToList();

            List<ClienteDTO> _cliente = new List<ClienteDTO>();

            _result.ForEach(c =>
            {
                _cliente.Add(new ClienteDTO()
                {
                    Id = c.ID,
                    Nombre = c.Nombre,
                    Apellido = c.Apellidos,
                    Cedula = c.Cedula,
                    Direccion = c.Direccion,
                    Telefono = c.Telefono,
                    Inactivo = c.Inactivo,
                    MunicipioId = c.MunicipioId,
                    MunicipioNombre = c.Municipio.Nombre,
                    ProvinciaNombre = c.Municipio.Provincia.Nombre

                });
            });

            return _cliente;
        }

        public Cliente Agregar(Cliente entidad)
        {
            if (entidad != null)
            {
                db.Clientes.Add(entidad);
                db.SaveChanges();


            }

            return entidad;

        }

        public void Editar(Cliente entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var cliente = db.Clientes.Single(c => c.ID == entidad.ID);
            if (cliente != null)
            {
                db.Clientes.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Cliente entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var cliente = db.Clientes.Single(c => c.ID == entidad.ID);
            if (cliente != null)
            {
                cliente.Inactivo = true;

                db.Clientes.AddOrUpdate(cliente);
                db.SaveChanges();
            }

        }

       
    }
}
