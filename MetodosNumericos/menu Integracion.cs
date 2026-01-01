using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosNumericos
{
    public partial class menu_Integracion : Form
    {
        public menu_Integracion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            integracion_Compuesta coso = new integracion_Compuesta();
            coso.Show();
            coso.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cuadratura_adaptiva cuadratura = new cuadratura_adaptiva();
            cuadratura.Show();
            cuadratura.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cuadratura_gaussiana cuad = new cuadratura_gaussiana();
            cuad.Show();
            cuad.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            romExtrapolacion romExtrapolacion = new romExtrapolacion();
            romExtrapolacion.Show();   
            romExtrapolacion.WindowState = FormWindowState.Maximized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            integracionMultiple MESTOVOLVIENDOJODIDAMENTELOCOAYUDA = new integracionMultiple();
            MESTOVOLVIENDOJODIDAMENTELOCOAYUDA.Show();
            MESTOVOLVIENDOJODIDAMENTELOCOAYUDA.WindowState = FormWindowState.Maximized;
        }
    }
}
