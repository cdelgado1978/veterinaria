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
    class UsuarioControlador : IControlador<Usuario>
    {
        private readonly VeterinariaEntities db;

        public UsuarioControlador()
        {
            db = new VeterinariaEntities();
        }

        public Usuario Obtener(int id)
        {
            return db.Usuarios.FirstOrDefault(u => u.Id == id);

        }

        public List<UsuarioDTO> ObtenerTodos()
        {
            var _result = db.Usuarios.ToList();

            List<UsuarioDTO> usuario = new List<UsuarioDTO>();

            _result.ForEach(u =>
            {
                usuario.Add(new UsuarioDTO()
                {
                    Id = u.Id,
                    EmpleadoId = u.EmpleadoId,
                    Usuario = u.Usuario1,
                    Contrasena = u.Contrasena,
                    Inactivo = u.Inactivo,

                });
            });

            return usuario;
        }

        public Usuario Agregar(Usuario entidad)
        {
            if (entidad != null)
            {
                db.Usuarios.Add(entidad);
                db.SaveChanges();


            }

            return entidad;

        }

        public void Editar(Usuario entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var usuario = db.Usuarios.Find(entidad);
            if (usuario != null)
            {
                db.Usuarios.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Usuario entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var usuario = db.Usuarios.Find(entidad);
            if (usuario != null)
            {
                usuario.Inactivo = true;

                db.Usuarios.AddOrUpdate(usuario);
                db.SaveChanges();
            }

        }

        
    }
}
