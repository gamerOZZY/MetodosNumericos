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
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void menuInterpolacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void derivacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuIntegracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pivoteoParcialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pivoteoParcial dadsa = new pivoteoParcial();
            dadsa.Show();
            dadsa.WindowState = FormWindowState.Maximized;
        }

        private void factorizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            factorizaciones ola = new factorizaciones();
            ola.Show();
            ola.WindowState = FormWindowState.Maximized;
        }

        private void metodoDeEulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eulerEDO adsad = new eulerEDO();
            adsad.Show();
            adsad.WindowState = FormWindowState.Maximized;
        }

        private void derivacion235PuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            der123 f = new der123();
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void conHIrregularpuntosNoEquidistantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hIrregularDerivada f = new hIrregularDerivada();
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void extrapolacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            derivadaExtrapolacion q = new derivadaExtrapolacion();
            q.Show();
            q.WindowState = FormWindowState.Maximized;
        }

        private void reglasCompuestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            integracion_Compuesta coso = new integracion_Compuesta();
            coso.Show();
            coso.WindowState = FormWindowState.Maximized;
        }

        private void cuadraturaAdaptivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuadratura_adaptiva cuadratura = new cuadratura_adaptiva();
            cuadratura.Show();
            cuadratura.WindowState = FormWindowState.Maximized;
        }

        private void cuadraturaGaussianaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuadratura_gaussiana cuad = new cuadratura_gaussiana();
            cuad.Show();
            cuad.WindowState = FormWindowState.Maximized;
        }

        private void extrapolacionDeRombergToolStripMenuItem_Click(object sender, EventArgs e)
        {
            romExtrapolacion romExtrapolacion = new romExtrapolacion();
            romExtrapolacion.Show();
            romExtrapolacion.WindowState = FormWindowState.Maximized;
        }

        private void integracionMultipleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            integracionMultiple MESTOVOLVIENDOJODIDAMENTELOCOAYUDA = new integracionMultiple();
            MESTOVOLVIENDOJODIDAMENTELOCOAYUDA.Show();
            MESTOVOLVIENDOJODIDAMENTELOCOAYUDA.WindowState = FormWindowState.Maximized;
        }

        private void diferenciasDivididasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diferenciasDivididas f = new diferenciasDivididas();
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void nevilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            neville neville = new neville();
            neville.Show();
            neville.WindowState = FormWindowState.Maximized;
        }

        private void lagranjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lagranje lagranje = new lagranje();
            lagranje.Show();
            lagranje.WindowState = FormWindowState.Maximized;
        }

        private void metodoDeTaylorDeOrdenSuperiorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taylorSuperior taylorSuperior = new taylorSuperior();
            taylorSuperior.Show();
            taylorSuperior.WindowState = FormWindowState.Maximized;
        }
    }
}
