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

            AbrirPopup<FrmNuevoProducto>();

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

                    var frmNuevo = formulario as FrmNuevoProducto;

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

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
