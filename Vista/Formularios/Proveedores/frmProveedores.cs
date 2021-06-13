using System;
using System.Linq;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Proveedores;

namespace Veterinaria.Formularios.Proveedores
{
    public partial class frmProveedores : Form
    {
        private readonly ProveedoresControlador proveedorController;

        public frmProveedores()
        {

            proveedorController = new ProveedoresControlador();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            AbrirPopup<frmNuevoProveedor>();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            ActualizaDBGrid();
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

                if (_type.Name == "frmNuevoProveedor")
                {

                    var frmNuevo = formulario as frmNuevoProveedor;

                    frmNuevo.Creado += (bool Creado) =>
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

        private void ActualizaDBGrid()
        {
            dgProveedores.DataSource = proveedorController.ObtenerTodos();

        }
    }
}
