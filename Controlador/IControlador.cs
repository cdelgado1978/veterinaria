using System.Collections.Generic;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;

namespace Veterinaria.Controlador
{
    public interface IControlador<T>
    {
      

        T Agregar(T entidad);

        void Editar(T entidad);

        void Borrar(T entidad);
        List<RecetaDTO> ObtenerTodos(string texto);
    }
}