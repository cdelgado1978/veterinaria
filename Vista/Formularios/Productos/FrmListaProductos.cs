using System;
using System.Linq;
using System.Windows.Forms;
using Veterinaria.Controlador;

namespace Veterinaria.Vista.Formularios.Productos
{
    public partial class FrmListaProductos : Form
    {
        private ProductoControlador productosControlador;

        public FrmListaProductos()
        {
            InitializeComponent();

            productosControlador = new ProductoControlador();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ActualizaDBGrid();

        }

        public void ActualizaDBGrid()
        {

            dgListaProductos.DataSource = productosControlador.ObtenerTodos();

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {

            AbrirPopup<frmNuevoProducto>();

        }

        public void AbrirPopup<T>() where T : Form, new()
        {
            Form formulario;

            formulario = panelContenido.Controls.OfType<T>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new T();
                formulario.TopLevel = false;


                formulario.StartPosition = FormStartPosition.CenterParent;

                panelContenido.Controls.Add(formulario);
                panelContenido.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

                var _type = formulario.GetType();

                if (_type.Name == "frmNuevoProducto")
                {

                    var frmNuevo = formulario as frmNuevoProducto;

                    frmNuevo.Creado += (Creado) =>
                    {
                        if (Creado)
                        {
                            ActualizaDBGrid();
                        }
                    };

                }

            }
            else
            {
                formulario.BringToFront();
            }

        }

    }
}
