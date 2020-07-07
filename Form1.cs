using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encuestas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEncuesta_Click(object sender, EventArgs e)
        {
            Preguntas pr = new Preguntas();
            pr.ShowDialog();

            //Boton que hace saltar la ventana de las preguntas. 

        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login sesion = new Login();
            sesion.ShowDialog();

            //Boton que al darle click se abre el Login. 
        }
    }
}
