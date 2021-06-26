using System;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Modelo;


namespace Veterinaria.Vista.Formularios.Recetas
{
    public partial class FrmReceta : Form
    {
        private readonly AnimalControlador animalcontrolador;
        private readonly RecetaControlador recetaControlador;

        private bool Agregando;

        public FrmReceta()
        {
            InitializeComponent();

            recetaControlador = new RecetaControlador();
            animalcontrolador = new AnimalControlador();

            ActualizaDBGrid();

        }

        public void ActualizaDBGrid()
        {

            dbGridDetalle.DataSource = recetaControlador.ObtenerTodos();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            Agregando = true;


            btnGuardar.Enabled = true;

            PanelForm.Enabled = true;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            txtTipoAnimal.Text = "";
            txtRaza.Text = "";
            txtPropietario.Text = "";
            txtPadecimiento.Text = "";
            txtNombrePro.Text = "";
            txtDosis.Text = "";
            checkboxinactivo.Checked = false;

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var _nombre = txtNombre.Text;
            var _edad = int.Parse(txtEdad.Text);
            var _direccion = txtDireccion.Text;
            var _tipoAnimal = txtTipoAnimal.Text;
            var _raza = txtRaza.Text;
            var _clinte = txtPropietario;
            var _padecimiento = txtPadecimiento;
            var _Nombrepro = txtNombrePro;
            var _dosis = txtDosis;
            var _inactivo = checkboxinactivo.Checked;

            if (Agregando)
            {

                var _nuevaReceta = new Receta()
                {



                };

                nuevaReceta(_nuevaReceta);
            }
            else
            {
                var _receta = new Receta()
                {

                };

                EditarReceta(_receta);
            }

            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;

            LimpiarFormulario();

            ActualizaDBGrid();

            PanelForm.Enabled = false;
        }

        private void nuevaReceta(Receta receta)
        {

            recetaControlador.Agregar(receta);


        }

        private void EditarReceta(Receta receta)
        {

            recetaControlador.Editar(receta);


        }

        private void FrmReceta_Load(object sender, EventArgs e)
        {

        }
    }
}

