using System;
using System.Windows.Forms;
using Veterinaria.Controlador;

namespace Veterinaria.Vista.Formularios.Razas
{
    public partial class FrmNuevaRaza : Form
    {

        public event Action<bool> Creado;
        
        private readonly RazaControlador _razaControlador;
        public FrmNuevaRaza()
        {
            _razaControlador = new RazaControlador();

            InitializeComponent();
        }

        private void NuevaRaza(Modelo.Raza newRaza)
        {

            _razaControlador.Agregar(newRaza);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var _nombre = txtRaza.Text;
            var _tipoAnimalId = int.Parse(cbTipoAnimal.SelectedValue.ToString());
            var _inactivo = chkBoxInactivo.Checked;
           
            var _nuevaRaza = new Modelo.Raza()
            {
                Nombre = _nombre,
                Inactivo = _inactivo

            };

            NuevaRaza(_nuevaRaza);

            Creado(true);

            MessageBox.Show($"Raza {_nombre} Creada. ");

            this.Close();




        }

       

    }
}

