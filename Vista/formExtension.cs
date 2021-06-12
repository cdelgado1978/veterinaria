using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public static class formExtension
    {

        public static void AbrirFormularios<P, T>(this Form form) where P : Panel, new() 
                                                                  where T : Form, new()
        {
            Form formulario;
            Panel panel = form.Controls.OfType<P>().FirstOrDefault();

            formulario = panel.Controls.OfType<T>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new T();
                formulario.TopLevel = false;

                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                panel.Controls.Add(formulario);
                panel.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }




        }

        public static void AbrirPopup<P, T>(this Form form) where P : Panel, new()
                                                            where T : Form, new()
        {
            
            Panel panel = form.Controls.OfType<P>().FirstOrDefault();
            Form formulario = panel.Controls.OfType<T>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new T();
                formulario.TopLevel = false;

                formulario.FormBorderStyle = FormBorderStyle.None;

                panel.Controls.Add(formulario);
                panel.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }


        }

    }
}
