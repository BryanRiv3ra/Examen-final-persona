using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 abrir = new Form2();
            abrir.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("¿Quieres irte de la habitacion terciopelo?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
        }
    }
}
