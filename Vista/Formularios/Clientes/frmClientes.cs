using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Modelo;
using Veterinaria.Modelo.DTO;

namespace Veterinaria.Vista.Formularios.Clientes
{
    public partial class frmClientes : Form
    {
        private readonly ClienteControlador clienteControlador;
        private readonly MunicipioControlador municipioControlador;
        private readonly ProvinciaControlador provinciaControlador;
        private int _clienteId;

        public bool Agregando { get; private set; }

        public frmClientes()
        {
            InitializeComponent();

            clienteControlador = new ClienteControlador();
            municipioControlador = new MunicipioControlador();
            provinciaControlador = new ProvinciaControlador();

            ActualizaDBGrid();
            CargaProvincias();
        }

 
        public void ActualizaDBGrid()
        {
            dgGridDetalle.DataSource = clienteControlador.ObtenerTodos();
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
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtCedula.Text = "";
            txtTelefono.Text = "";
            cbProvincia.Text = "";
            cbMunicipio.Text = "";
            chkBoxInactivo.Checked = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var _nombre = txtNombre.Text;
            var _apellidos = txtApellidos.Text;
            var _direccion = txtDireccion.Text;
            var _cedula = txtCedula.Text;
            var _telefono = txtTelefono.Text;
            
            var _inactivo = chkBoxInactivo.Checked;
            
            var _municipioId = int.Parse(cbMunicipio.SelectedValue.ToString());


            if (Agregando)
            {

                var _nuevaCte = new Cliente()
                {
                    Nombre = _nombre,
                    Apellidos = _apellidos,
                    Cedula = _cedula,
                    Direccion = _direccion,
                    Telefono = _telefono,
                    MunicipioId = _municipioId,
                    Inactivo = _inactivo

                };

                NuevoCliente(_nuevaCte);
            }
            else
            {
                var _cte = new Cliente()
                {
                    ID = _clienteId,
                    Nombre = _nombre,
                    Apellidos = _apellidos,
                    Cedula = _cedula,
                    Direccion = _direccion,
                    Telefono = _telefono,
                    MunicipioId = _municipioId,
                    Inactivo = _inactivo

                };

                EditarCliente(_cte);
            }

            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;

            LimpiarFormulario();

            ActualizaDBGrid();

            PanelForm.Enabled = false;
        }

        private void NuevoCliente(Cliente cte)
        {

            clienteControlador.Agregar(cte);


        }

        private void EditarCliente(Cliente cte)
        {
            clienteControlador.Editar(cte);
        }

        private void dgGridDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _selectedRow = e.RowIndex;

            _clienteId = int.Parse(dgGridDetalle.Rows[_selectedRow].Cells[0].Value.ToString());

            txtNombre.Text = dgGridDetalle.Rows[_selectedRow].Cells["Nombre"].Value.ToString();
            txtApellidos.Text = dgGridDetalle.Rows[_selectedRow].Cells["Apellidos"].Value.ToString();
            txtDireccion.Text = dgGridDetalle.Rows[_selectedRow].Cells["Direccion"].Value.ToString();
            txtCedula.Text = dgGridDetalle.Rows[_selectedRow].Cells["Cedula"].Value.ToString();
            txtTelefono.Text = dgGridDetalle.Rows[_selectedRow].Cells["Telefono"].Value.ToString();
            cbProvincia.Text = dgGridDetalle.Rows[_selectedRow].Cells["ProvinciaNombre"].Value.ToString();
            cbMunicipio.Text = dgGridDetalle.Rows[_selectedRow].Cells["MunicipioNombre"].Value.ToString();
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

            var _result = municipioControlador.ObtenerTodos(_valor);

            dgGridDetalle.DataSource = _result;

        }

        public void CargaProvincias()
        {
            var result = provinciaControlador.ObtenerTodos().OrderBy(o => o.Nombre).ToList();

            cbProvincia.DataSource = result;
            cbProvincia.DisplayMember = "Nombre";
            cbProvincia.ValueMember = "Id";

        }

        public void CargaMunicipios(int provinciaId)
        {
            var result = municipioControlador.ObtenerTodos().Where(p => p.ProvinciaId == provinciaId).OrderBy(o => o.Nombre).ToList();

            cbMunicipio.DataSource = result;
            cbMunicipio.DisplayMember = "Nombre";
            cbMunicipio.ValueMember = "Id";

        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

            int _provincia = 0;

            var _result = int.TryParse(cbProvincia.SelectedValue.ToString(), out _provincia);

            if (_result)
                CargaMunicipios(_provincia);


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var _cliente = clienteControlador.Obtener(_clienteId);

            if (_cliente != null)
                clienteControlador.Borrar(_cliente);
        }
    }
}
