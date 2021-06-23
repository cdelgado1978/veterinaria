using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;

namespace Veterinaria.Controlador
{
    public class TipoProductoControlador : IControlador<Tipo_Producto>
    {
        private readonly VeterinariaEntities db;

        public TipoProductoControlador()
        {
            db = new VeterinariaEntities();
        }

        public Tipo_Producto Agregar(Tipo_Producto entidad)
        {
            if (entidad != null)
            {
                db.Tipo_Producto.Add(entidad);
                db.SaveChanges();
            }

            return entidad;

        }

        public void Editar(Tipo_Producto entidad)
        {

            var result = db.Tipo_Producto.Single(tp => tp.Id == entidad.Id);
            if (result != null)
            {
                db.Tipo_Producto.AddOrUpdate(entidad);
                db.SaveChanges();
            }

            
        }

        public void Borrar(Tipo_Producto entidad)
        {

            var result = db.Tipo_Producto.Single(tp => tp.Id == entidad.Id);
            if (result != null)
            {
                result.Inactivo = true;

                db.Tipo_Producto.AddOrUpdate(result);
                db.SaveChanges();
            }
        }

        public List<TipoProductoDto> ObtenerTodos()
        {
            var _result = db.Tipo_Producto.ToList();

            List<TipoProductoDto> _tipoProductos = new List<TipoProductoDto>();

            _result.ForEach(tp =>
            {
                _tipoProductos.Add(new TipoProductoDto()
                {
                    Id = tp.Id,
                    Nombre = tp.Nombre,
                    Inactivo = tp.Inactivo
                    
                });
            });

            return _tipoProductos;
        }

        public object ObtenerTodos(string texto)
        {
            var _result = db.Tipo_Producto.Where(p => p.Nombre.Contains(texto) ).ToList();

            List<TipoProductoDto> _tipoProductos = new List<TipoProductoDto>();

            _result.ForEach(tp =>
            {
                _tipoProductos.Add(new TipoProductoDto()
                {
                    Id = tp.Id,
                    Nombre = tp.Nombre,
                    Inactivo = tp.Inactivo
                });
            });

            return _tipoProductos;
        }
    }
}