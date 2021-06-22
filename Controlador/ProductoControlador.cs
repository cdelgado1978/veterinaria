using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;

namespace Veterinaria.Controlador
{
    public class ProductoControlador : IControlador<Producto>
    {
        private readonly VeterinariaEntities db;

        public ProductoControlador()
        {
            db = new VeterinariaEntities();
            
        }

        public Producto Obtener(int id)
        {
            return db.Productos.FirstOrDefault(p => p.Id == id);

        }
        
        public List<ProductoDto> ObtenerTodos()
        {
            var _result = db.Productos.ToList();

            List<ProductoDto> _productos = new List<ProductoDto>();

            _result.ForEach(p =>
            {
                _productos.Add(new ProductoDto()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    //TipoProductoId = p.TipoProductoId,
                    TipoProductoNombre = p.Tipo_Producto.Nombre,
                    Descripcion = p.Descripcion,
                    //ProveedorId = p.ProveedorId,
                    ProveedorNombre = p.Proveedor.Nombre,
                    Costo = p.Costo,
                    Precio = p.Precio,
                    Cantidad = p.Cantidad,
                    Inactivo = p.Inactivo

                });
            });

            return _productos;
        }

 
        public Producto Agregar(Producto entidad)
        {
            if (entidad != null)
            {

                db.Productos.Add(entidad);
                db.SaveChanges();

            }

            return entidad;

        }

        public void Editar(Producto entidad)
        {
            //if (entidad == null) throw new Exception("Entidad Invalidad");

            var producto = db.Productos.Find(entidad);
            if (producto != null)
            {
                db.Productos.AddOrUpdate(entidad);
                db.SaveChanges();
            }
        }
        
        public void Borrar(Producto entidad)
        {

            var producto = db.Productos.Find(entidad);
            if (producto != null)
            {
                producto.Inactivo = true;

                db.Productos.AddOrUpdate(producto);
                db.SaveChanges();
            }

        }
        
    }
}
