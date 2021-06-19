using System;
using System.Linq;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Modelo;

namespace Veterinaria.Vista.Formularios.Productos
{ 
    public partial class frmNuevoProducto : Form
    {
        private readonly ProductoControlador productosControlador;
        private readonly ProveedoresControlador proveedorControlador;
        private readonly TipoProductoControlador tipoProductoControlador;


        public event Action<bool> Creado;

        public frmNuevoProducto()
        {

            productosControlador = new ProductoControlador();
            proveedorControlador = new ProveedoresControlador();
            tipoProductoControlador = new TipoProductoControlador();

            

            InitializeComponent();

            CargaProveedores();
            CargaTipoProducto();

        }




        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevoProducto(Producto newProd)
        {
            
            productosControlador.Agregar(newProd);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var _nombre = txtNombre.Text;
            var _descripcion = txtDescripcion.Text;
            var _tipoProductoId = int.Parse(cbTipoProducto.SelectedValue.ToString());
            var _proveedorId = int.Parse(cbProveedor.SelectedValue.ToString());

            var _costo = decimal.Parse(txtCosto.Text);
            var _precio = decimal.Parse(txtPrecio.Text);
            var _cantidad = int.Parse(txtCantidad.Text);
            var _inactivo = chkBoxInactivo.Checked;


            var _nuevoProducto = new Producto()
            {
                Nombre = _nombre,
                Descripcion = _descripcion,
                Costo = _costo,
                Precio = _precio,
                Cantidad = _cantidad,
                ProveedorId = _proveedorId,
                TipoProductoId = _tipoProductoId,
                Inactivo = _inactivo

            };

            NuevoProducto(_nuevoProducto);

            Creado(true);

            MessageBox.Show($"Producto {_nombre} Creado. ");

            this.Close();

                     


        }

        public void CargaProveedores()
        {
            var result = proveedorControlador.ObtenerTodos().ToList();

            cbProveedor.DataSource = result;
            cbProveedor.DisplayMember = "Nombre";
            cbProveedor.ValueMember = "ID";
        }

        public void CargaTipoProducto()
        {
            var result = tipoProductoControlador.ObtenerTodos().ToList();

            cbTipoProducto.DataSource = result;
            cbTipoProducto.DisplayMember = "Nombre";
            cbTipoProducto.ValueMember = "ID";

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
