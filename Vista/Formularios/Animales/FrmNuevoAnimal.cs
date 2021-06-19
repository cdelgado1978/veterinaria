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


namespace Veterinaria.Formularios.Animales
{
    public partial class FrmNuevoAnimal : Form
    {
        private readonly AnimalControlador animalControlador;
        private readonly TipoAnimalControlador tipoAnimalControlador;
        private readonly RazaControlador razaControlador;
        private readonly ClienteControlador clienteControlador;

        public event Action<bool> Creado;

        public FrmNuevoAnimal()
        {
            animalControlador = new AnimalControlador();
            tipoAnimalControlador = new TipoAnimalControlador();
            razaControlador = new RazaControlador();
            clienteControlador = new ClienteControlador();

            InitializeComponent();
            
            
        }

         private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void NuevoAnimales(Animale newAnm)
        {

            animalControlador.Agregar(newAnm);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var _nombre = txtNombre.Text;
            var _tipoAnimalID = int.Parse(cbTipoAnimal.SelectedValue.ToString());
            var _razaID = int.Parse(cbRaza.SelectedValue.ToString());

            var _edad = int.Parse(txtEdad.Text);
            var _direccion = txtDireccion.Text;
            var _clienteID = int.Parse(txtClienteid.Text);
            var _inactivo = chkBoxInactivo.Checked;


            var _nuevoAnimal= new Animale()
            {
                Nombre = _nombre,
                TipoID = _tipoAnimalID,
                RazaID = _razaID,
                Edad = _edad,
                Direccion = _direccion,
                ClienteId = _clienteID,
                Inactivo = _inactivo

            };

            NuevoAnimales(_nuevoAnimal);

            Creado(true);

            MessageBox.Show($"Animal {_nombre} Creado. ");

            this.Close();
        }

      

       
       

        private void cbTipoAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       
        public void CargaTipoAnimal()
        {
            var result = tipoAnimalControlador.ObtenerTodos().ToList();

            cbTipoAnimal.DataSource = result;
            cbTipoAnimal.DisplayMember = "Nombre";
            cbTipoAnimal.ValueMember = "ID";
        }

        public void CargarRaza()
        {
            var result = razaControlador.ObtenerTodos().ToList();

            cbRaza.DataSource = result;
            cbRaza.DisplayMember = "Nombre";
            cbRaza.ValueMember = "ID";
        }

    }
}
