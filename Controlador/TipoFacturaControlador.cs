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
    class TipoFacturaControlador : IControlador<Tipo_Factura>
    {
        private readonly VeterinariaEntities db;

        public TipoFacturaControlador()
        {
            db = new VeterinariaEntities();
        }

        public Tipo_Factura Obtener(int id)
        {
            return db.Tipo_Factura.FirstOrDefault(tf => tf.Id == id);

        }

        public List<TipoFacturaDTO> ObtenerTodos()
        {
            var _result = db.Tipo_Factura.ToList();

            List<TipoFacturaDTO> tipo_factura = new List<TipoFacturaDTO>();

            _result.ForEach(tf =>
            {
                tipo_factura.Add(new TipoFacturaDTO()
                {
                    Id = tf.Id,
                    Nombre = tf.Nombre,
                    Inactivo = tf.Inactivo,

                });
            });

            return tipo_factura;
        }

        public Tipo_Factura Agregar(Tipo_Factura entidad)
        {
            if (entidad != null)
            {
                db.Tipo_Factura.Add(entidad);
                db.SaveChanges();


            }

            return entidad;

        }

        public void Editar(Tipo_Factura entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var tipo_factura = db.Tipo_Factura.Find(entidad);
            if (tipo_factura != null)
            {
                db.Tipo_Factura.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Tipo_Factura entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var tipo_factura = db.Tipo_Factura.Find(entidad);
            if (tipo_factura != null)
            {
                tipo_factura.Inactivo = true;

                db.Tipo_Factura.AddOrUpdate(tipo_factura);
                db.SaveChanges();
            }

        }

        
    }
}
