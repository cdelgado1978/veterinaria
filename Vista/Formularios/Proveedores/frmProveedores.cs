using System;
using System.Linq;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Modelo;

namespace Veterinaria.Vista.Formularios.Proveedores
{
    public partial class frmProveedores : Form
    {
        private readonly ProveedoresControlador proveedorController;
        private int _proveedorId;
        private bool Agregando;

        public frmProveedores()
        {

            proveedorController = new ProveedoresControlador();
            InitializeComponent();
        }


        //private void btnNuevoProducto_Click(object sender, EventArgs e)
        //{
        //    AbrirPopup<frmNuevoProveedor>();
        //}

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            ActualizaDBGrid();
        }

        //public void AbrirPopup<T>() where T : Form, new()
        //{
        //    Form formulario;

        //    formulario = panelContenido.Controls.OfType<T>().FirstOrDefault();

        //    if (formulario == null)
        //    {
        //        formulario = new T();
        //        formulario.TopLevel = false;


        //        formulario.StartPosition = FormStartPosition.CenterParent;

        //        panelContenido.Controls.Add(formulario);
        //        panelContenido.Tag = formulario;
        //        formulario.Show();
        //        formulario.BringToFront();

        //        var _type = formulario.GetType();

        //        if (_type.Name == "frmNuevoProveedor")
        //        {

        //            var frmNuevo = formulario as frmNuevoProveedor;

        //            frmNuevo.Creado += (bool Creado) =>
        //            {
        //                if (Creado)
        //                {
        //                    ActualizaDBGrid();
        //                }
        //            };

        //        }

        //    }
        //    else
        //    {
        //        formulario.BringToFront();
        //    }

        //}


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            Agregando = true;

            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;

            PanelForm.Enabled = true;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            chkBoxInactivo.Checked = false;
 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var _nombre = txtNombre.Text;
            var _direccion = txtDireccion.Text;
            var _telefono = txtTelefono.Text;
            var _inactivo = chkBoxInactivo.Checked;



            if (Agregando)
            {

                var _nuevoProducto = new Proveedor()
                {
                    Nombre = _nombre,
                    Dirección = _direccion,
                    Telefono = _telefono,
                    Inactivo = _inactivo

                };

                NuevoProveedor(_nuevoProducto);
            }
            else
            {
                var _Producto = new Proveedor()
                {
                    ID = _proveedorId,
                    Nombre = _nombre,
                    Dirección = _direccion,
                    Telefono = _telefono,
                    Inactivo = _inactivo

                };

                EditarProducto(_Producto);
            }

            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;

            LimpiarFormulario();

            ActualizaDBGrid();

            PanelForm.Enabled = false;
        }

        private void NuevoProveedor(Proveedor newprod)
        {

            proveedorController.Agregar(newprod);


        }

        private void EditarProducto(Proveedor producto)
        {
            proveedorController.Editar(producto);
        }

        private void ActualizaDBGrid()
        {
            dgProveedores.DataSource = proveedorController.ObtenerTodos();

        }

        private void dgProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _selectedRow = e.RowIndex;


            _proveedorId = int.Parse(dgProveedores.Rows[_selectedRow].Cells[0].Value.ToString());

            txtNombre.Text = dgProveedores.Rows[_selectedRow].Cells[1].Value.ToString();
            txtDireccion.Text = dgProveedores.Rows[_selectedRow].Cells[2].Value.ToString();
            txtTelefono.Text = dgProveedores.Rows[_selectedRow].Cells[3].Value.ToString();
            chkBoxInactivo.Checked = bool.Parse(dgProveedores.Rows[_selectedRow].Cells[4].Value.ToString());

            btnEditar.Enabled = true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PanelForm.Enabled = true;
            Agregando = false;

            btnGuardar.Enabled = true;
            PanelForm.Enabled = true;

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            var _valor = txtBuscar.Text;

            var _result = proveedorController.Obtener(_valor);

            dgProveedores.DataSource = _result;

        }
    }
}
