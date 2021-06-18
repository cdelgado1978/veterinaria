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
    class FacturaDetalleControlador : IControlador<Facturas_Detalle>
    {
        private readonly VeterinariaEntities db;

        public FacturaDetalleControlador()
        {
            db = new VeterinariaEntities();
        }

        public Facturas_Detalle Obtener(int id)
        {
            return db.Facturas_Detalle.FirstOrDefault(fd => fd.ID == id);

        }

        public List<FacturaDetalleDTO> ObtenerTodos()
        {
            var _result = db.Facturas_Detalle.ToList();

            List<FacturaDetalleDTO> factura_detalle = new List<FacturaDetalleDTO>();

            _result.ForEach(fd =>
            {
                factura_detalle.Add(new FacturaDetalleDTO()
                {
                    Id = fd.ID,
                    FacturaId = fd.FacturasID,
                    Fecha = fd.Fecha,
                    EmpleadoId = fd.EmpleadoID,
                    ProductoId = fd.ProductoID,
                    TipoProducto = fd.TipoProductoId,
                    Precio = fd.Precio,
                    Cantidad = fd.Cantidad,
                    Descuento = fd.Descuento,
                    SubTotal = fd.SubTotal,
                    Total = fd.Total,
                    Inactivo = fd.Inactivo


                });
            });

            return factura_detalle;
        }

        public Facturas_Detalle Agregar(Facturas_Detalle entidad)
        {
            if (entidad != null)
            {
                db.Facturas_Detalle.Add(entidad);
                db.SaveChanges();


            }

            return entidad;

        }

        public void Editar(Facturas_Detalle entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var facturas_detalle = db.Facturas_Detalle.Find(entidad);
            if (facturas_detalle != null)
            {
                db.Facturas_Detalle.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Facturas_Detalle entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var factura_detalle = db.Facturas_Detalle.Find(entidad);
            if (factura_detalle != null)
            {
                factura_detalle.Inactivo = true;

                db.Facturas_Detalle.AddOrUpdate(factura_detalle);
                db.SaveChanges();
            }

        }

        
    }
}
