using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Modelo;

namespace Veterinaria.Controlador
{
    public class ProductoControlador
    {
        private readonly VeterinariaEntities entidades;

        public ProductoControlador()
        {
            entidades = new VeterinariaEntities();
        }


        public List<Producto> ObtenerProductos()
        {
            return entidades.Productos.ToList();
        }

    }

}
