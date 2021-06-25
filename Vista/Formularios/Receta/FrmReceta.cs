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


namespace Veterinaria.Vista.Formularios.Receta
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
        private void NuevaReceta()
        {

            


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

                var _nuevaReceta = new  ()
                {
                    
                    

                };

                nueva(_nuevoAnimal);
            }
            else
            {
                var _animal = new Animale()
                {
                    
                };

                EditarAnimal(_animal);
            }

            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;

            LimpiarFormulario();

            ActualizaDBGrid();

            PanelForm.Enabled = false;
        }

        private void NuevoAnimal(Animale cte)
        {

            animalControlador.Agregar(cte);


        }

        private void FrmReceta_Load(object sender, EventArgs e)
        {

        }
    }
    }
}
