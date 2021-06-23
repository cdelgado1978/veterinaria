using System;
using System.Linq;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Modelo;

namespace Veterinaria.Vista.Formularios.Productos
{
    public partial class FrmListaProductos : Form
    {
        private readonly ProductoControlador productosControlador;
        private readonly ProveedoresControlador proveedorControlador;
        private readonly TipoProductoControlador tipoProductoControlador;
        private bool Agregando;
        private int _productoId;

        public FrmListaProductos()
        {

            InitializeComponent();

            productosControlador = new ProductoControlador();

            proveedorControlador = new ProveedoresControlador();
            tipoProductoControlador = new TipoProductoControlador();

            CargaProveedores();
            CargaTipoProducto();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ActualizaDBGrid();

        }

        public void ActualizaDBGrid()
        {

            dbGridDetalle.DataSource = productosControlador.ObtenerTodos();

        }

     

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCosto.Text = "";
            txtCantidad.Text = "";
            chkBoxInactivo.Checked = false;
            cbProveedor.Text = "";
            cbTipoProducto.Text = "";

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



            if (Agregando)
            {

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
            } else
            {
                var _Producto = new Producto()
                {
                    Id = _productoId,
                    Nombre = _nombre,
                    Descripcion = _descripcion,
                    Costo = _costo,
                    Precio = _precio,
                    Cantidad = _cantidad,
                    ProveedorId = _proveedorId,
                    TipoProductoId = _tipoProductoId,
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

        private void NuevoProducto(Producto newprod)
        {

            productosControlador.Agregar(newprod);
           

        }

        private void EditarProducto(Producto producto)
        {
            productosControlador.Editar(producto);
        }

        private void dbGridDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _selectedRow = e.RowIndex;


            _productoId = int.Parse(dbGridDetalle.Rows[_selectedRow].Cells[0].Value.ToString());

            txtNombre.Text = dbGridDetalle.Rows[_selectedRow].Cells[1].Value.ToString();
            cbTipoProducto.Text = dbGridDetalle.Rows[_selectedRow].Cells[2].Value.ToString();
            txtDescripcion.Text = dbGridDetalle.Rows[_selectedRow].Cells[3].Value.ToString();
            cbProveedor.Text = dbGridDetalle.Rows[_selectedRow].Cells[4].Value.ToString();
            txtPrecio.Text = dbGridDetalle.Rows[_selectedRow].Cells[6].Value.ToString();
            txtCosto.Text = dbGridDetalle.Rows[_selectedRow].Cells[5].Value.ToString();
            txtCantidad.Text = dbGridDetalle.Rows[_selectedRow].Cells[7].Value.ToString();
            chkBoxInactivo.Checked = bool.Parse(dbGridDetalle.Rows[_selectedRow].Cells[8].Value.ToString());

            btnEditar.Enabled = true;


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

            var _result = productosControlador.Obtener(_valor);

            dbGridDetalle.DataSource = _result;

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
            Agregando = true;

            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
            PanelForm.Enabled = true;
        }
    }
}
