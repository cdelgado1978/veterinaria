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

namespace Veterinaria.Vista.Formularios.Razas
{
    public partial class FrmRaza : Form
    {
        private RazaControlador razaControlador;
        private readonly TipoAnimalControlador tipoAnimalControlador;
        private bool Agregando;
        private int _razaId;

        public Action<object> Creado { get; private set; }

        public FrmRaza()
        {
            InitializeComponent();

            razaControlador = new RazaControlador();
            tipoAnimalControlador = new TipoAnimalControlador();

            CargaTipoAnimal();
        }

        public void ActualizaDBGrid()
        {
            dgRazas.DataSource = razaControlador.ObtenerTodos();
        }

        private void FrmRaza_Load(object sender, EventArgs e)
        {
            ActualizaDBGrid();
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
            cbTipoAnimal.Text = "";
            chkBoxInactivo.Checked = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var _nombre = txtNombre.Text;
            var _inactivo = chkBoxInactivo.Checked;
            var _tipoAnimalId = int.Parse(cbTipoAnimal.SelectedValue.ToString());


            if (Agregando)
            {

                var _nuevaRaza = new Raza()
                {
                    Nombre = _nombre,
                    TipoAnimalId = _tipoAnimalId,
                    Inactivo = _inactivo

                };

                NuevaRaza(_nuevaRaza);
            }
            else
            {
                var _Producto = new Raza()
                {
                    Id = _razaId,
                    Nombre = _nombre,
                    TipoAnimalId = _tipoAnimalId,
                    Inactivo = _inactivo

                };

                EditarRaza(_Producto);
            }

            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;

            LimpiarFormulario();

            ActualizaDBGrid();

            PanelForm.Enabled = false;
        }

        private void NuevaRaza(Raza newprod)
        {

            razaControlador.Agregar(newprod);


        }

        private void EditarRaza(Raza producto)
        {
            razaControlador.Editar(producto);
        }

        private void dgListaTiposAnimal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _selectedRow = e.RowIndex;


            _razaId = int.Parse(dgRazas.Rows[_selectedRow].Cells[0].Value.ToString());

            txtNombre.Text = dgRazas.Rows[_selectedRow].Cells[1].Value.ToString();
            cbTipoAnimal.Text = dgRazas.Rows[_selectedRow].Cells[3].Value.ToString();
            chkBoxInactivo.Checked = bool.Parse(dgRazas.Rows[_selectedRow].Cells[4].Value.ToString());

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

            var _result = razaControlador.ObtenerTodos(_valor);

            dgRazas.DataSource = _result;

        }

        public void CargaTipoAnimal()
        {
            var result = tipoAnimalControlador.ObtenerTodos().ToList();

            cbTipoAnimal.DataSource = result;
            cbTipoAnimal.DisplayMember = "Nombre";
            cbTipoAnimal.ValueMember = "Id";

        }
    }
}
