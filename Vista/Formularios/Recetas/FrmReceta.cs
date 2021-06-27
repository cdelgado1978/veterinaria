using System;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Modelo;


namespace Veterinaria.Vista.Formularios.Recetas
{
    public partial class FrmReceta : Form
    {
        private readonly AnimalControlador animalcontrolador;
        private readonly ProductoControlador productoControlador;
        private readonly RecetaControlador recetaControlador;

        private bool Agregando;
        private int _recetaid;
        private int _AnimalID;
        private string _ProductoID;

        public FrmReceta()
        {
            InitializeComponent();

            recetaControlador = new RecetaControlador();
            animalcontrolador = new AnimalControlador();
            productoControlador = new ProductoControlador();

            ActualizaDBGrid();

        }

        public void ActualizaDBGrid()
        {

            dbGridDetalle.DataSource = recetaControlador.ObtenerTodos();

        }



        private void LimpiarFormulario()
        {
            txtanimalid.Text = "";
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

        private void nuevaReceta(Receta receta)
        {

            recetaControlador.Agregar(receta);

        }



        private void FrmReceta_Load(object sender, EventArgs e)
        {
            ActualizaDBGrid();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
            Agregando = true;


            btnGuardar.Enabled = true;

            PanelForm.Enabled = true;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
           
            var _tipoAnimal = int.Parse(txtTipoAnimal.Text);
            var _raza = int.Parse(txtRaza.Text);
            var _padecimiento = txtPadecimiento.Text;
            var _dosis = txtDosis.Text;
            var _inactivo = checkboxinactivo.Checked;

            if (Agregando)
            {

                var _nuevaReceta = new Receta()

                {

                    TipoAnimalId = _tipoAnimal,
                    RazaID = _raza,
                    Padecimiento = _padecimiento,
                    Dosis = _dosis,
                    Inactivo = _inactivo

                };

                nuevaReceta(_nuevaReceta);
            }
            else
            {
                var _receta = new Receta()
                {
                    Id = _recetaid,
                    AnimalID = _AnimalID,
                    TipoAnimalId = _tipoAnimal,
                    RazaID = _raza,
                    Padecimiento = _padecimiento,
                    ProductoId = _ProductoID,
                    Dosis = _dosis,
                    Inactivo = _inactivo

                };


            }


            btnGuardar.Enabled = false;

            LimpiarFormulario();

            ActualizaDBGrid();

            PanelForm.Enabled = false;
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {

        }

        private void txtanimalid_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnBuscaranm_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtanimalid.Text))
            {
                MessageBox.Show("El ID del animal no puede estar en blanco.");
                return;
            }


            var _animalId = 0;

            var result = int.TryParse(txtanimalid.Text, out _animalId);

            if (result)
            {
                var _animal = animalcontrolador.Obtener(_animalId);

                if (_animal != null)
                {
       

                    txtEdad.Text = _animal.Edad.ToString();
                    txtnombreanm.Text = _animal.Nombre;
                    txtDireccion.Text = _animal.Direccion;
                    txtTipoAnimal.Text = _animal.Tipo_Animal.Nombre;
                    txtRaza.Text = _animal.Raza.Nombre;
                    txtPropietario.Text = $"{_animal.Cliente.Nombre} {_animal.Cliente.Apellidos}";


                } else
                {
                    MessageBox.Show("Animal no encontrado");
                }
            }
            else
            {
                MessageBox.Show("ID del Animal debe ser un entero");
                return;

            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductoID.Text))
            {
                MessageBox.Show("El ID del producto no puede estar en blanco.");
                return;
            }

            var _productoId = int.Parse(txtProductoID.Text);

            var _producto = productoControlador.Obtener(_productoId);


 
            if (_producto != null)
            {
                txtNombrePro.Text = _producto.Nombre;
            }
            else
            {
                MessageBox.Show("Producto no encontrado");

            }
        }
    }
}

