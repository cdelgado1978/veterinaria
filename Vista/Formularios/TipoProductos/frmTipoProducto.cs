using System;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Modelo;

namespace Veterinaria.Vista.Formularios.TipoProductos
{
    public partial class frmTipoProducto : Form
    {
        private readonly TipoProductoControlador tipoProductoControlador;
        private int _tipoProductoId;
        private bool Agregando;

        public frmTipoProducto()
        {
            InitializeComponent();

            tipoProductoControlador = new TipoProductoControlador();

            ActualizaDBGrid();
        }



        public void ActualizaDBGrid()
        {

            dgListaTipoProducto.DataSource = tipoProductoControlador.ObtenerTodos();

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

                var _nuevoTipoProducto = new Tipo_Producto()
                {
                    Nombre = _nombre,
                    Inactivo = _inactivo

                };

                NuevoTipoProducto(_nuevoTipoProducto);
            }
            else
            {
                var _tipoProducto = new Tipo_Producto()
                {
                    Id = _tipoProductoId,
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

        private void NuevoTipoProducto(Tipo_Producto newprod)
        {

            tipoProductoControlador.Agregar(newprod);


        }

        private void EditarTipoProducto(Tipo_Producto producto)
        {
            tipoProductoControlador.Editar(producto);
        }

        private void dgListaTipoProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _selectedRow = e.RowIndex;


            _tipoProductoId = int.Parse(dgListaTipoProducto.Rows[_selectedRow].Cells[1].Value.ToString());

            txtNombre.Text = dgListaTipoProducto.Rows[_selectedRow].Cells[2].Value.ToString();
            chkBoxInactivo.Checked = bool.Parse(dgListaTipoProducto.Rows[_selectedRow].Cells[0].Value.ToString());

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

            var _result = tipoProductoControlador.ObtenerTodos(_valor);

            dgListaTipoProducto.DataSource = _result;

        }


        private void TipoAnimal_Load(object sender, EventArgs e)
        {
            ActualizaDBGrid();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var tipoProducto = tipoProductoControlador.Obtener(_tipoProductoId);

            if (tipoProducto != null)
                tipoProductoControlador.Borrar(tipoProducto);
        }
    }
}
