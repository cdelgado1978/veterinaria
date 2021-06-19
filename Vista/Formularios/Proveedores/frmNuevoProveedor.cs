using System;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Modelo;

namespace Veterinaria.Vista.Formularios.Proveedores
{
    public partial class frmNuevoProveedor : Form
    {
        
        private readonly ProveedoresControlador proveedorControlador;
        //private readonly TipoProductoControlador tipoProductoControlador;


        public event Action<bool> Creado;

        public frmNuevoProveedor()
        {

            proveedorControlador = new ProveedoresControlador();
            
            InitializeComponent();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevoProveedor(Proveedor newProd)
        {
            
            proveedorControlador.Agregar(newProd);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var _nombre = txtNombre.Text;
            var _direccion = txtDireccion.Text;
            //var _tipoProveedorId = int.Parse(cbTipoProveedor.SelectedValue.ToString());
            var _tipoProveedorId = 1;

            var _telefono = txtTelefono.Text;
            var _inactivo = chkBoxInactivo.Checked;


            var _nuevoProveedor = new Proveedor()
            {
                Nombre = _nombre,
                Dirección = _direccion,
                Telefono = _telefono,
                TipoProveedorID = _tipoProveedorId,
                Inactivo = _inactivo

            };

            NuevoProveedor(_nuevoProveedor);

            Creado(true);

            this.Close();

                     


        }



        private void cantidadLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
