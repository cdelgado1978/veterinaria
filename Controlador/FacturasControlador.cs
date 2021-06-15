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
    class FacturasControlador : IControlador<Factura>
    {
        private readonly VeterinariaEntities db;

        public FacturasControlador()
        {
            db = new VeterinariaEntities();
        }

        public Factura Obtener(int id)
        {
            return db.Facturas.FirstOrDefault(f => f.ID == id);

        }

        public List<FacturaDTO> ObtenerTodos()
        {
            var _result = db.Facturas.ToList();

            List<FacturaDTO> facturas = new List<FacturaDTO>();

            _result.ForEach(f =>
            {
                facturas.Add(new FacturaDTO()
                {
                    Id = f.ID,
                    CategoriaId = f.CategoriaID,
                    Fecha = f.Fecha,
                    TipoFactura = f.TipoFacturaID,
                    EmpleadoId = f.EmpleadoID,
                    ClienteId = f.ClienteID,
                    Descuento = f.DescuentoTotal,
                    SubTotal = f.SubTotal,
                    Total = f.Total,
                    Inactivo = f.Inactivo
                    

                });
            });

            return facturas;
        }

        public Factura Agregar(Factura entidad)
        {
            if (entidad != null)
            {
                db.Facturas.Add(entidad);
                db.SaveChanges();


            }

            return entidad;

        }

        public void Editar(Factura entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var facturas = db.Facturas.Find(entidad);
            if (facturas != null)
            {
                db.Facturas.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }

        public void Borrar(Factura entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var facturas = db.Facturas.Find(entidad);
            if (facturas != null)
            {
                facturas.Inactivo = true;

                db.Facturas.AddOrUpdate(facturas);
                db.SaveChanges();
            }

        }

      
    }
}

