using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encuestas
{
    public partial class Preguntas : Form
    {
        public int a = 0;
        public Preguntas()
        {
            InitializeComponent();
            Ejecutar();
            salir.Hide();
            
               //Al Iniciar las preguntas el boton salir se oculta para que quede al final. 
        }
        public bool boton = false;

        private void b1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Encuestass", Conexion.conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Opcion", 1);
                cmd.Parameters.AddWithValue("@Preguntas", pregunta.Text);
                cmd.Parameters.AddWithValue("@Respuestas", b1.Text);

                Conexion.conex.Open();
                cmd.ExecuteNonQuery();
                Conexion.conex.Close();
                a += 1;
                Ejecutar();

                //Conexión con la base de datos. 
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Ejecutar()
        {
            //Estas son las preguntas englobadas en una sola función. 

            if (a == 0)
                    {
                        pregunta.Text = "1 ¿Con qué frecuencia visita nuestra ferretería?";
                        b1.Text = "Diario";
                        b2.Text = "Semanal";
                        b3.Text = "Mensual";
                    }


             if (a==1)
                    {
                        pregunta.Text = "2 Si compara nuestra ferretería con otra alternativa, somos:";
                        b1.Text = "Mucho Mejor";
                        b2.Text = "Poco Mejor";
                        b3.Text = "Peor";

                    }

            if (a == 2)
            {
                pregunta.Text = "3 ¿Cuál es la probabilidad de que nos recomiende con sus conocidos?";
                b1.Text = "Los Recomiendo";
                b2.Text = "Muy Probable";
                b3.Text = "Poco probable";
            }

          
            if (a == 3)
            {
                pregunta.Text = "4 ¿A quién recomendaría nuestra tienda?: ";
                b1.Text = "Amigos";
                b2.Text = "Familiares";
                b3.Text = "Conocidos";
            }
            if (a == 4)
            {
                pregunta.Text = "5 ¿Qué tan bueno es el trato de los vendedores en general?";
                b1.Text = "Bueno";
                b2.Text = "Malo";
                b3.Text = "Regular";
            }
            if (a == 5)
            {
                pregunta.Text = "6 ¿De qué calidad considera que son los artículos que ha comprado con nosotros?";
                b1.Text = "Bueno";
                b2.Text = "Malo";
                b3.Text = "Regular";
            }
            if (a == 6)
            {
                pregunta.Text = "7 ¿Cómo piensa que es el trabajo que realizan los vendedores en general?";
                b1.Text = "Bueno";
                b2.Text = "Malo";
                b3.Text = "Regular";

            }
            if (a == 7)
            {
                pregunta.Text = "8 ¿Qué tan buena es la relación calidad-precio?";
                b1.Text = "Bueno";
                b2.Text = "Malo";
                b3.Text = "Regular";

            }
            if (a == 8)
            {
                pregunta.Text = "9 ¿Volvería a visitar nuestra ferretería?";
                b1.Text = "Claro";
                b2.Text = "No me gusto el servicio";
                b3.Text = "Poco probable";

            }
            if (a == 9)
            {
                pregunta.Text = "10 ¿Por qué visitaría otra ferretería y no la nuestra?";
                b1.Text = "Calidad-precio.";
                b2.Text = "Mejor Servicio";
                b3.Text = "Ambiente Agradable";

            }
            if (a == 10)
            {
                pregunta.Height = 400;
                

                pregunta.Text = "Gracias por realizar la encuesta";
                b1.Hide();
                b2.Hide();
                b3.Hide();
                salir.Visible = Visible;


                //Lo realicé así para que se cambien las preguntas y respuestas a base de condiciones y no hacer 10 ventanas. 
            }





        }

        private void b2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Encuestass", Conexion.conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Opcion", 1);
                cmd.Parameters.AddWithValue("@Preguntas", pregunta.Text);
                cmd.Parameters.AddWithValue("@Respuestas", b2.Text);

                Conexion.conex.Open();
                cmd.ExecuteNonQuery();
                Conexion.conex.Close();
                a += 1;
                Ejecutar();

                //Estos botones son variables de valor, guardan todo. 
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Encuestass", Conexion.conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Opcion", 1);
                cmd.Parameters.AddWithValue("@Preguntas", pregunta.Text);
                cmd.Parameters.AddWithValue("@Respuestas", b3.Text);

                Conexion.conex.Open();
                cmd.ExecuteNonQuery();
                Conexion.conex.Close();
                a += 1;
                Ejecutar();

                //Boton para añadir las respuestas a la base de datos automaticamente. 
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Conexiones()
        {
            SqlCommand cmd = new SqlCommand("Encuestass", Conexion.conex);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Opcion", 1);
            cmd.Parameters.AddWithValue("@Preguntas", pregunta.Text);
            cmd.Parameters.AddWithValue("@Respuestas", b1.Text);
          
            Conexion.conex.Open();
            cmd.ExecuteNonQuery();
            Conexion.conex.Close();
            
            //Boton para las conexiones con la base de datos. 

        }
    }
}
