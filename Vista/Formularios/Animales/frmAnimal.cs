using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;

namespace Veterinaria.Formularios.Animales
{
    public partial class frmAnimal : Form
    {


        private AnimalControlador animalControlador;
        private readonly TipoAnimalControlador tipoAnimalControlador;
        private readonly Razacontrolador razaControlador;
        private readonly ClienteControlador clienteControlador;
        private bool Agregando;
        private int _animalId;

        public frmAnimal()
        {
            InitializeComponent();

            animalControlador = new AnimalControlador();
            tipoAnimalControlador = new TipoAnimalControlador();
            razaControlador = new Razacontrolador();
            clienteControlador = new ClienteControlador();

            ActualizaDBGrid();
            CargaTipoAnimal();
            CargaRazaAnimal();
            CargaClientes();

        }

        public void ActualizaDBGrid()
        {

            dgGridDetalle.DataSource = animalControlador.ObtenerTodos();

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
            txtEdad.Text = "";
            txtDireccion.Text = "";
            cbTipoAnimal.Text = "";
            cbRaza.Text = "";
            cbClientes.Text = "";
            chkBoxInactivo.Checked = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var _nombre = txtNombre.Text;
            var _edad = int.Parse(txtEdad.Text);
            var _direccion = txtDireccion.Text;

            var _inactivo = chkBoxInactivo.Checked;
            var _tipoAnimalId = int.Parse(cbTipoAnimal.SelectedValue.ToString());
            var _tipoRazaId = int.Parse(cbRaza.SelectedValue.ToString());
            var _clienteId = int.Parse(cbClientes.SelectedValue.ToString());


            if (Agregando)
            {

                var _nuevoAnimal = new Animale()
                {
                    Nombre = _nombre,
                    Edad = _edad,
                    Direccion = _direccion,
                    RazaID = _tipoRazaId,
                    TipoID = _tipoAnimalId,
                    ClienteId = _clienteId,
                    Inactivo = _inactivo

                };

                NuevoAnimal(_nuevoAnimal);
            }
            else
            {
                var _animal = new Animale()
                {
                    ID = _clienteId,
                    Nombre = _nombre,
                    Edad = _edad,
                    Direccion = _direccion,
                    RazaID = _tipoRazaId,
                    TipoID = _tipoAnimalId,
                    ClienteId = _clienteId,
                    Inactivo = _inactivo
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

        private void EditarAnimal(Animale cte)
        {
            animalControlador.Editar(cte);
        }

        private void dgGridDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _selectedRow = e.RowIndex;

            _animalId = int.Parse(dgGridDetalle.Rows[_selectedRow].Cells["Id"].Value.ToString());

            txtNombre.Text = dgGridDetalle.Rows[_selectedRow].Cells["Nombre"].Value.ToString();
            txtEdad.Text = dgGridDetalle.Rows[_selectedRow].Cells["Edad"].Value.ToString();
            txtDireccion.Text = dgGridDetalle.Rows[_selectedRow].Cells["Direccion"].Value.ToString();

            cbClientes.Text = dgGridDetalle.Rows[_selectedRow].Cells["ClienteNombre"].Value.ToString();
            cbTipoAnimal.Text = dgGridDetalle.Rows[_selectedRow].Cells["TipoAnimalNombre"].Value.ToString();
            cbRaza.Text = dgGridDetalle.Rows[_selectedRow].Cells["RazaNombre"].Value.ToString();
            chkBoxInactivo.Checked = bool.Parse(dgGridDetalle.Rows[_selectedRow].Cells["Inactivo"].Value.ToString());

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

            var _result = animalControlador.ObtenerTodos(_valor);

            dgGridDetalle.DataSource = _result;

        }

        private void cbTipoAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _tipoAnimalId = 0;

            var _result = int.TryParse(cbTipoAnimal.SelectedValue.ToString(), out _tipoAnimalId);

            if (_result)
                CargaRazaAnimal(_tipoAnimalId);

        }

        public void CargaRazaAnimal(int tipoAnimalId = 0)
        {


            IList<RazasDto> result;

            if (tipoAnimalId > 0)
            {
                result = razaControlador.ObtenerTodos().Where(p => p.TipoAnimalId == tipoAnimalId).OrderBy(o => o.Nombre).ToList();

            }
            else
            {
                result = razaControlador.ObtenerTodos().OrderBy(o => o.Nombre).ToList();
            }

            cbRaza.DataSource = result;
            cbRaza.DisplayMember = "Nombre";
            cbRaza.ValueMember = "Id";

        }

        public void CargaTipoAnimal()
        {
            var result = tipoAnimalControlador.ObtenerTodos();

            cbTipoAnimal.DataSource = result;
            cbTipoAnimal.DisplayMember = "Nombre";
            cbTipoAnimal.ValueMember = "Id";
        }

        public void CargaClientes()
        {
            var result = clienteControlador.ObtenerTodos();

            cbClientes.DataSource = result;
            cbClientes.DisplayMember = "NombreCompleto";
            cbClientes.ValueMember = "Id";
        }

        private void dgGridDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmListaAnimales_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            var _animal = animalControlador.Obtener(_animalId);

            if (_animal != null)
                animalControlador.Borrar(_animal);

        }
    }
}
