using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonRut_Click(object sender, EventArgs e)
        {
            string rut = TextoRut.Text;
            if (rut != null)
            {
                ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();
                string respuesta = cliente.GetRutValidacion(rut);
                MessageBox.Show(respuesta);
            }
        }

        private void MensajeText_Click(object sender, EventArgs e)
        {
            var ap = ApText.Text;
            var am = Amtext.Text;
            var nm = NmsText.Text;
            char genero;

            if (BotonF.Checked)
                genero = 'F';
            else
                genero = 'M';

            if (ap != "" && am != "" & nm != "")
            {
                ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();
                string respuesta = cliente.GetMensaje(ap, am, nm, genero);
                MessageBox.Show(respuesta);
            }
            else
                MessageBox.Show("Hay campos en blanco");
        }

        
    }
}
