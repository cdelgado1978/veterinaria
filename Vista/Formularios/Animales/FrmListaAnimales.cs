using System;
using System.Linq;
using System.Windows.Forms;
using Veterinaria.Controlador;
using Veterinaria.Formularios.Animales;
using Veterinaria.Modelo;








namespace Veterinaria.Formularios.Animales
{
    public partial class FrmListaAnimales : Form
    {
        

        private AnimalControlador animalControlador;

        public FrmListaAnimales()
        {
            InitializeComponent();

            animalControlador = new AnimalControlador();
        }

        

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmListaAnimales_Load(object sender, EventArgs e)
        {
            ActualizaDBGrid();
        }

        public void ActualizaDBGrid()
        {

            dgListaProductos.DataSource = animalControlador.ObtenerTodos();

        }

        private void btnNuevoAnimal_Click(object sender, EventArgs e)
        {
            AbrirPopup<FrmNuevoAnimal>();
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

                if (_type.Name == "frmNuevoAnimal")
                {

                    var frmNuevo = formulario as FrmNuevoAnimal;

                    frmNuevo.Creado += (bool Creado) =>
                    {
                        if (Creado)
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

        private void dgListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
