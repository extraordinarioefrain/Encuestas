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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)

        
        {
            

            try
            {
                if (txtUsuario.Text == "efrain") //Usuario de Inicio de sesión. 
                {
                    if (txtPass.Text == "12345") //Clave de Incio de sesión. 

                    {
                        FuncAdministrador admin = new FuncAdministrador();
                        admin.ShowDialog();

                        //El resultado de cumplirse ambos requisitos, abre la ventana Funciones de Administrador. 
                    }

                }

                else
                {
                    MessageBox.Show("Contraseña o Usuario Incorrecto");

                    //Mensaje de aviso que la contraseña o usuario está malo. 
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
