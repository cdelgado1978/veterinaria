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

namespace Veterinaria
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


            dataGridView1.DataSource = productosControlador.ObtenerTodos();

           
        }

        private void NuevoProducto(Producto newProd)
        {
            var newproducto = new Producto();

           
            newproducto.Nombre = newProd.Nombre;
            newproducto.Descripcion= newProd.Descripcion;


            productosControlador.Agregar(newproducto);

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    NuevoProducto(new Producto()
        //    {
        //        Id = txtID.Text
        //    });
        //}
    }
}
