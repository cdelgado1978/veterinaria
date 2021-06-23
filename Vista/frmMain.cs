using System;
using System.Linq;
using System.Windows.Forms;
using Veterinaria.Formularios.Animales;
using Veterinaria.Vista.Formularios.Clientes;
using Veterinaria.Vista.Formularios.Demograficos;
using Veterinaria.Vista.Formularios.Productos;
using Veterinaria.Vista.Formularios.Proveedores;
using Veterinaria.Vista.Formularios.Razas;
using Veterinaria.Vista.Formularios.TipoProductos;
using Veterinaria.Vista.TipoAnimal;

namespace Veterinaria.Vista
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            CustomActions();

        }

       
        private void CustomActions()
        {
            panel_MantenimientoSubMenu.Visible = false;
            panel_SeguridadSubmenu.Visible = false;
        }

        private void OcultaSubMenu()
        {
            if (panel_MantenimientoSubMenu.Visible)
                panel_MantenimientoSubMenu.Visible = false;

            if (panel_SeguridadSubmenu.Visible)
                panel_SeguridadSubmenu.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                OcultaSubMenu();
                subMenu.Visible = true;
            } else
            {
                subMenu.Visible = false;
            }
        }



        private void btnProductos_Click(object sender, EventArgs e)
        {
            OcultaSubMenu();

            AbrirFormularios<frmProductos>();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OcultaSubMenu();
            AbrirFormularios<frmClientes>();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmProveedores>();
            OcultaSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmTipoAnimal>();
            OcultaSubMenu();
        }

        private void btnRaza_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmRaza>();
            OcultaSubMenu();
        }

        private void btnMantenimientoMenu_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(panel_MantenimientoSubMenu);
        }

        private void btnSeguridadMenu_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(panel_SeguridadSubmenu);
        }

        private void btnAnimalesMenu_Click(object sender, EventArgs e)
        {
            OcultaSubMenu();
        }


        public void AbrirFormularios<T>() where T : Form, new()
        {
            Form formulario;

            formulario = PanelContent.Controls.OfType<T>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new T();
                formulario.TopLevel = false;

                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                PanelContent.Controls.Add(formulario);
                PanelContent.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }

        }

        private void btnanimales_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmListaAnimales>();
            OcultaSubMenu();
        }

        private void btnTipoProducto_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmTipoProducto>();
            OcultaSubMenu();
        }

        private void btnProvincias_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmProvincia>();
            OcultaSubMenu();
        }

        private void btnMunicipios_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmMunicipio>();
            OcultaSubMenu();
        }
    }
}
