using System;
using System.Linq;
using System.Windows.Forms;
using Veterinaria.Controlador;

namespace Veterinaria.Vista.Tipo_Animal
{
    public partial class FrmTipoAnimal : Form
    {

        private TipoAnimalControlador tipoAnimalControlador;

        public Action<object> Creado { get; private set; }

        public FrmTipoAnimal()
        {
            InitializeComponent();

            tipoAnimalControlador = new TipoAnimalControlador();
        }

       

        public void ActualizaDBGrid()
        {

            dgListaTiposAnimal.DataSource = tipoAnimalControlador.ObtenerTodos();

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {

           

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

                if (_type.Name == "Tipo_Animal")
                {

                    var frmLista = formulario as FrmTipoAnimal;

                    frmLista.Creado += (Creado) =>
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

        private void TipoAnimal_Load(object sender, EventArgs e)
        {
            ActualizaDBGrid();
        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
