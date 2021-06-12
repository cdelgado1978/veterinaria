using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Modelo;

namespace Veterinaria.Controlador
{
    public class CotizacionesControlador : IControlador<Cotizacione>
    {
        private readonly VeterinariaEntities db;

        public CotizacionesControlador()
        {
            db = new VeterinariaEntities();
        }

        public Cotizacione Obtener(int id)
        {
            return db.Cotizaciones.FirstOrDefault(c => c.ID == id);

        }

        public List<CotizacionesDTO> ObtenerTodos()
        {
            var _result = db.Cotizaciones.ToList();

            List<CotizacionesDTO> _cotizacion = new List<CotizacionesDTO>();

            _result.ForEach(c =>
            {
                _cotizacion.Add(new CotizacionesDTO()
                {
                    Id= c.ID,
                    Fecha= c.fecha,
                    EmpleadoId= c.EmpleadoID,
                    ClienteId= c.ClienteID,
                    ProductoId= c.ProductoID,
                    TipoProductoId= c.TipoProductoID,
                    Precio= c.Precio,
                    Cantidad= c.Cantidad,
                    Descuento= c.Descuento,
                    SubTotal= c.SubTotal,
                    Total= c.Total,
                    Inactivo= c.Inactivo

                });
            });

            return _cotizacion;
        }

        public Cotizacione Agregar(Cotizacione entidad)
        {
            if (entidad != null)
            {
                db.Cotizaciones.Add(entidad);
                db.SaveChanges();


            }

            return entidad;

        }

        public void Editar(Cotizacione entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var cotizacion = db.Cotizaciones.Find(entidad);
            if (cotizacion != null)
            {
                db.Cotizaciones.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Cotizacione entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var cotizacion = db.Cotizaciones.Find(entidad);
            if (cotizacion != null)
            {
                cotizacion.Inactivo = true;

                db.Cotizaciones.AddOrUpdate(cotizacion);
                db.SaveChanges();
            }

        }

       
    }
}

