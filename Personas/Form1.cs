using Personas.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Personas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SoundPlayer Sonido = new SoundPlayer();
            Sonido.SoundLocation = "C:/Users/bryan/Downloads/y2mate.com-Aria-of-the-Soul-Persona-3-Reload-OST.wav";
            Sonido.Play();
        }
        private void buttonEmpezar_Click(object sender, EventArgs e)
        {
            Form2 abrir = new Form2();
            abrir.Show();
            this.Hide();
        }
    }
}
