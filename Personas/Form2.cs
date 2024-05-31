using Personas.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Personas.Model;
using System.Media;

namespace Personas
{
    public partial class Form2 : Form
    {
        ConexionMysql Clscone = new ConexionMysql();
        PersonaModel prs = new PersonaModel();

        public Form2()
        {
            InitializeComponent();
            SoundPlayer Sonido = new SoundPlayer();
            Sonido.SoundLocation = "C:/Users/bryan/Downloads/y2mate.com-Persona-5-OST-Beneath-the-Mask-rain.wav";
            Sonido.Play(); 
        }

        private void buttonVerconfidentes_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Clscone.LeerPersonajes();
                Registro1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar personajes: " + ex.Message);
            }
        }
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                prs.id_persona = int.Parse(textBoxId.Text);
                prs.nombre = textBoxNombre.Text;
                prs.apellido = textBoxApellido.Text;
                prs.persona = textBoxPersona.Text;
                prs.estado = textBoxEstado.Text;
                prs.asociacion = textBoxAsociacion.Text;
                prs.arma = textBoxArma.Text;
                prs.juego = textBoxJuego.Text;
                Clscone.ActualizarConfidente(prs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar tu confidente: " + ex.Message);
            }

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxPersona.Text = "";
            textBoxAsociacion.Text = "";
            textBoxArma.Text = "";
            textBoxJuego.Text = "";
            textBoxEstado.Text = "";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxId.Text, out int id))
                {
                    Clscone.EliminarConfidente(id);
                    PersonaModel prs = new PersonaModel();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }

        }

        private void buttonInsertarmodel_Click(object sender, EventArgs e)
        {
            try
            {
                prs.id_persona = int.Parse(textBoxId.Text);
                prs.nombre = textBoxNombre.Text;
                prs.apellido = textBoxApellido.Text;
                prs.persona = textBoxPersona.Text;
                prs.estado = textBoxEstado.Text;
                prs.asociacion = textBoxAsociacion.Text;
                prs.arma = textBoxArma.Text;
                prs.juego = textBoxJuego.Text;
                MessageBox.Show("Se agregó correctamente.");
                Clscone.Insertar(prs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void Registro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSorpresa_Click(object sender, EventArgs e)
        {
            Form3 abrir = new Form3();
            abrir.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        { 
                try
                {
                    if (int.TryParse(textBoxId.Text, out int id))
                    {
                        PersonaModel prs = Clscone.BuscarPorId(id);

                        if (prs != null)
                        {
                            textBoxNombre.Text = prs.nombre;
                            textBoxApellido.Text = prs.apellido;
                            textBoxPersona.Text = prs.persona;
                            textBoxEstado.Text = prs.estado;
                            textBoxAsociacion.Text = prs.asociacion;
                            textBoxArma.Text = prs.arma;
                            textBoxJuego.Text = prs.juego;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un ID válido.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                }
        }


    }
}



