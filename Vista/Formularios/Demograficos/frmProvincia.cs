using System;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Modelo;

namespace Veterinaria.Vista.Formularios.Demograficos
{
    public partial class frmProvincia : Form
    {
        private readonly ProvinciaControlador provinciaControlador;
        private bool Agregando;
        private int _provinciaId;

        public frmProvincia()
        {
            InitializeComponent();

            provinciaControlador = new ProvinciaControlador();

            ActualizaDBGrid();
        }

        public void ActualizaDBGrid()
        {

            dgListaProvincias.DataSource = provinciaControlador.ObtenerTodos();

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

                var _nuevoTipoProducto = new Provincia()
                {
                    Nombre = _nombre,
                    Inactivo = _inactivo

                };

                NuevoTipoProducto(_nuevoTipoProducto);
            }
            else
            {
                var _tipoProducto = new Provincia()
                {
                    Id = _provinciaId,
                    Nombre = _nombre,
                    Inactivo = _inactivo

                };

                EditarTipoProducto(_tipoProducto);
            }

            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;

            LimpiarFormulario();

            ActualizaDBGrid();

            PanelForm.Enabled = false;
        }

        private void NuevoTipoProducto(Provincia newprod)
        {

            provinciaControlador.Agregar(newprod);


        }

        private void EditarTipoProducto(Provincia producto)
        {
            provinciaControlador.Editar(producto);
        }

        private void dgListaTipoProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _selectedRow = e.RowIndex;


            _provinciaId = int.Parse(dgListaProvincias.Rows[_selectedRow].Cells[1].Value.ToString());

            txtNombre.Text = dgListaProvincias.Rows[_selectedRow].Cells[2].Value.ToString();
            chkBoxInactivo.Checked = bool.Parse(dgListaProvincias.Rows[_selectedRow].Cells[0].Value.ToString());

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

            var _result = provinciaControlador.ObtenerTodos(_valor);

            dgListaProvincias.DataSource = _result;

        }


        private void TipoAnimal_Load(object sender, EventArgs e)
        {
            ActualizaDBGrid();
        }

    }
}
