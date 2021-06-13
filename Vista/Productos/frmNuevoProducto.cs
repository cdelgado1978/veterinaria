using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;

namespace Veterinaria.Productos
{
    public partial class frmNuevoProducto : Form
    {
        private readonly ProductoControlador productosControlador;
        private readonly ProveedoresControlador proveedorControlador;
        private readonly TipoProductoControlador tipoProductoControlador;


        public event Action<bool> ProductoCreado;

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

            ProductoCreado(true);

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
    }
}
