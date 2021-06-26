using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;


namespace Veterinaria.Vista.Formularios.Recetas
{
    public partial class FrmReceta : Form
    {
        private readonly AnimalControlador animalcontrolador;
        private readonly RecetaControlador recetaControlador;

        SqlConnection conexion = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Veterinaria;Integrated Security=True");


        private bool Agregando;
        private int _recetaid;
        private int _AnimalID;
        private string _ProductoID;

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
            var _nombre = txtanimalid.Text;
            var _edad = int.Parse(txtEdad.Text);
            var _direccion = txtDireccion.Text;
            var _tipoAnimal = int.Parse(txtTipoAnimal.Text);
            var _raza = int.Parse(txtRaza.Text);
            var _clinte = txtPropietario;
            var _padecimiento = txtPadecimiento.Text;
            var _Nombrepro = txtNombrePro;
            var _dosis = txtDosis.Text;
            var _inactivo = checkboxinactivo.Checked;

            if (Agregando)
            {

                var _nuevaReceta = new Receta ()
                
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
            string query = "select *from Animales where ID='" + txtanimalid.Text + "'";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txtEdad.Text = leer["Edad"].ToString();
                txtnombreanm.Text = leer["Nombre"].ToString();
                txtDireccion.Text = leer["Direccion"].ToString();
                txtTipoAnimal.Text = leer["TipoID"].ToString();
                txtRaza.Text = leer["RazaID"].ToString();
                txtPropietario.Text = leer["ClienteID"].ToString();

                conexion.Close();

            }
            
            else
            {
                MessageBox.Show("Animal no encontrado");

            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            string query = "select *from Producto where Id='" + txtProductoID.Text + "'";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txtNombrePro.Text = leer["Nombre"].ToString();
                

                conexion.Close();

            }

            else
            {
                MessageBox.Show("Producto no encontrado");

            }
        }
    }
}

