using System;
using System.Linq;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Modelo;

namespace Veterinaria.Vista.TipoAnimal
{
    public partial class FrmTipoAnimal : Form
    {

        private TipoAnimalControlador tipoAnimalControlador;
        private bool Agregando;
        private int _tipoAnimalId;

        public FrmTipoAnimal()
        {
            InitializeComponent();

            tipoAnimalControlador = new TipoAnimalControlador();
        }

       

        public void ActualizaDBGrid()
        {

            dgListaTiposAnimal.DataSource = tipoAnimalControlador.ObtenerTodos();

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            Agregando = true;

            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;

            PanelForm.Enabled = true;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            chkBoxInactivo.Checked = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var _nombre = txtNombre.Text;
            var _inactivo = chkBoxInactivo.Checked;



            if (Agregando)
            {

                var _nuevoProducto = new Tipo_Animal()
                {
                    Nombre = _nombre,
                    Inactivo = _inactivo

                };

                NuevoTipoAnimal(_nuevoProducto);
            }
            else
            {
                var _Producto = new Tipo_Animal()
                {
                    Id = _tipoAnimalId,
                    Nombre = _nombre,
                    Inactivo = _inactivo

                };

                EditarTipoAnimal(_Producto);
            }

            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;

            LimpiarFormulario();

            ActualizaDBGrid();

            PanelForm.Enabled = false;
        }

        private void NuevoTipoAnimal(Tipo_Animal newprod)
        {

            tipoAnimalControlador.Agregar(newprod);


        }

        private void EditarTipoAnimal(Tipo_Animal producto)
        {
            tipoAnimalControlador.Editar(producto);
        }

        private void dgListaTiposAnimal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _selectedRow = e.RowIndex;


            _tipoAnimalId = int.Parse(dgListaTiposAnimal.Rows[_selectedRow].Cells[0].Value.ToString());

            txtNombre.Text = dgListaTiposAnimal.Rows[_selectedRow].Cells[1].Value.ToString();
            chkBoxInactivo.Checked = bool.Parse(dgListaTiposAnimal.Rows[_selectedRow].Cells[2].Value.ToString());

            btnEditar.Enabled = true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PanelForm.Enabled = true;
            Agregando = false;

            btnGuardar.Enabled = true;
            PanelForm.Enabled = true;

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            var _valor = txtBuscar.Text;

            var _result = tipoAnimalControlador.ObtenerTodos(_valor);

            dgListaTiposAnimal.DataSource = _result;

        }

        
        private void TipoAnimal_Load(object sender, EventArgs e)
        {
            ActualizaDBGrid();
        }

      
    }
}
