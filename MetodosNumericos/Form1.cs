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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
        }

        private void biseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBiseccion f = new frmBiseccion();
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void mullerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuller g = new frmMuller();
            g.Show();
            g.WindowState = FormWindowState.Maximized;
        }

        private void newtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewton n = new frmNewton();
            n.Show();
            n.WindowState = FormWindowState.Maximized;
        }

        private void puntoFijoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPuntoFijo m = new frmPuntoFijo();
            m.Show();
            m.WindowState = FormWindowState.Maximized;
        }

        private void secanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecante l = new frmSecante();
            l.Show();
            l.WindowState = FormWindowState.Maximized;
        }

        private void falsaPosicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFalsaPosicion fp = new frmFalsaPosicion();
            fp.Show();
            fp.WindowState = FormWindowState.Maximized;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
             menuDerivacion f = new menuDerivacion();
            f.Show();
            f.WindowState = FormWindowState.Maximized;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void menuInterpolacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuInterpolacion menuInterpolacion = new menuInterpolacion();
            menuInterpolacion.Show();
            menuInterpolacion.WindowState = FormWindowState.Maximized;
        }

        private void derivacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
