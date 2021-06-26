namespace Veterinaria.Controlador
{
    public interface IControlador<T>
    {
      

        T Agregar(T entidad);

        void Editar(T entidad);

        void Borrar(T entidad);

        //List<T> ObtenerTodos();
        //List<T> ObtenerTodos(string texto);
    }
}