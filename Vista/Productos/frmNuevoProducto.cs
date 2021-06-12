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

namespace Veterinaria.Productos
{
    public partial class frmNuevoProducto : Form
    {
        private readonly ProductoControlador productosControlador;

        public frmNuevoProducto()
        {

            productosControlador = new ProductoControlador();
            //proveedorControlador = new ProveedorControlador();


            InitializeComponent();
        }

        private void proveedorIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inactivoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void precioLabel_Click(object sender, EventArgs e)
        {

        }

        private void costoLabel_Click(object sender, EventArgs e)
        {

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
            var newproducto = new Producto();


            newproducto.Nombre = newProd.Nombre;
            newproducto.Descripcion = newProd.Descripcion;


            productosControlador.Agregar(newproducto);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var _nombre = txtNombre.Text;
            var _descripcion = txtDescripcion.Text;
            var _costo = decimal.Parse(txtCosto.Text);
            var _precio = decimal.Parse(txtPrecio.Text);
            var _cantidad = int.Parse(txtCantidad.Text);



        }
    }
}
