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

        public Action<object> Creado { get; private set; }

        public FrmRaza()
        {
            InitializeComponent();

            razaControlador = new RazaControlador();
        }

        public void ActualizaDBGrid()
        {
            dgRazas.DataSource = razaControlador.ObtenerTodos();
        }

        private void FrmRaza_Load(object sender, EventArgs e)
        {
            ActualizaDBGrid();
        }

        public void AbrirPopup<T>() where T : Form, new()
        {
            Form formulario;

            formulario = panelContenido.Controls.OfType<T>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new T();
                formulario.TopLevel = false;


                formulario.StartPosition = FormStartPosition.CenterParent;

                panelContenido.Controls.Add(formulario);
                panelContenido.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

                var _type = formulario.GetType();

                if (_type.Name == "FrmNuevaRaza")
                {

                    var frmRaza = formulario as FrmNuevaRaza;

                    frmRaza.Creado += (Creado) =>
                    {
                        if ((bool)Creado)
                        {
                            ActualizaDBGrid();
                        }
                    };

                }

            }
            else
            {
                formulario.BringToFront();
            }

        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void btnNuevaRaza_Click(object sender, EventArgs e)
        {

        }
    }
}
