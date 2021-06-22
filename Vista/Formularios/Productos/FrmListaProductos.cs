using System;
using System.Linq;
using System.Threading.Tasks;
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

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {

            //AbrirPopup<FrmNuevoProducto>();

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

        //        if (_type.Name == "frmNuevoProducto")
        //        {

        //            var frmNuevo = formulario as FrmNuevoProducto;

        //            frmNuevo.Creado += (Creado) =>
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
            }
        }

        private void NuevoProducto(Producto newprod)
        {

            productosControlador.Agregar(newprod);

        }

        private void dbGridDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _selectedRow = e.RowIndex;


            //txtID.Text = dbGridDetalle.Rows[_selectedRow].Cells[0].Value.ToString();

            txtNombre.Text = dbGridDetalle.Rows[_selectedRow].Cells[1].Value.ToString();
            cbTipoProducto.Text = dbGridDetalle.Rows[_selectedRow].Cells[2].Value.ToString();
            txtDescripcion.Text = dbGridDetalle.Rows[_selectedRow].Cells[3].Value.ToString();
            cbProveedor.Text = dbGridDetalle.Rows[_selectedRow].Cells[4].Value.ToString();
            txtPrecio.Text = dbGridDetalle.Rows[_selectedRow].Cells[6].Value.ToString();
            txtCosto.Text = dbGridDetalle.Rows[_selectedRow].Cells[5].Value.ToString();
            txtCantidad.Text = dbGridDetalle.Rows[_selectedRow].Cells[7].Value.ToString();
            chkBoxInactivo.Checked = bool.Parse(dbGridDetalle.Rows[_selectedRow].Cells[8].Value.ToString());

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

    }
}
