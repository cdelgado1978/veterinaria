using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Modelo;

namespace Veterinaria.Vista.Formularios.Demograficos
{
    public partial class frmMunicipio : Form
    {
        private readonly MunicipioControlador municipioControlador;
        private readonly ProvinciaControlador provinciaControlador;
        private bool Agregando;
        private int _municipioId;

        public frmMunicipio()
        {

            municipioControlador = new MunicipioControlador();
            provinciaControlador = new ProvinciaControlador();

            InitializeComponent();

            ActualizaDBGrid();
            CargaProvincias();

        }

        public void ActualizaDBGrid()
        {
            dgMunicipios.DataSource = municipioControlador.ObtenerTodos();
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
            cbProvincias.Text = "";
            chkBoxInactivo.Checked = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var _nombre = txtNombre.Text;
            var _inactivo = chkBoxInactivo.Checked;
            var _provinciaId = int.Parse(cbProvincias.SelectedValue.ToString());


            if (Agregando)
            {

                var _nuevaMunicipio = new Municipio()
                {
                    Nombre = _nombre,
                    ProvinciaId = _provinciaId,
                    Inactivo = _inactivo

                };

                NuevoMunicipio(_nuevaMunicipio);
            }
            else
            {
                var _municipio = new Municipio()
                {
                    Id = _municipioId,
                    Nombre = _nombre,
                    ProvinciaId = _provinciaId,
                    Inactivo = _inactivo

                };

                EditarMunicipio(_municipio);
            }

            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;

            LimpiarFormulario();

            ActualizaDBGrid();

            PanelForm.Enabled = false;
        }

        private void NuevoMunicipio(Municipio municipio)
        {

            municipioControlador.Agregar(municipio);


        }

        private void EditarMunicipio (Municipio municipio)
        {
            municipioControlador.Editar(municipio);
        }

        private void dgMunicipios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _selectedRow = e.RowIndex;

            _municipioId = int.Parse(dgMunicipios.Rows[_selectedRow].Cells[0].Value.ToString());

            txtNombre.Text = dgMunicipios.Rows[_selectedRow].Cells[1].Value.ToString();
            cbProvincias.Text = dgMunicipios.Rows[_selectedRow].Cells[3].Value.ToString();
            chkBoxInactivo.Checked = bool.Parse(dgMunicipios.Rows[_selectedRow].Cells[4].Value.ToString());

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

            dgMunicipios.DataSource = _result;

        }

        public void CargaProvincias()
        {
            var result = provinciaControlador.ObtenerTodos().OrderBy(o => o.Nombre).ToList();

            cbProvincias.DataSource = result;
            cbProvincias.DisplayMember = "Nombre";
            cbProvincias.ValueMember = "Id";

        }
    }
}
