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

namespace Veterinaria.Vista.Formularios.Raza
{
    public partial class FrmNuevaRaza : Form
    {
        private readonly TipoAnimalControlador tipoAnimalControlador;
        public FrmNuevaRaza()
        {
            tipoAnimalControlador = new TipoAnimalControlador();

            InitializeComponent();
        }

        private void NuevaRaza(Raza newRaza)
        {

            RazaControlador.Agregar(newRaza);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var _nombre = txtRaza.Text;
            var _tipoAnimalId = int.Parse(cbTipoAnimal.SelectedValue.ToString());
            var _inactivo = chkBoxInactivo.Checked;
           
            var _nuevaRaza = new Raza()
            {
                Nombre = _nombre,
                TipoProductoId= _tipoAnimalId,
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

    }
}
}
