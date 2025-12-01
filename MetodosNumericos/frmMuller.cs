using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace MetodosNumericos
{
    public partial class frmMuller : Form
    {
        public frmMuller()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {


            SolEc1Var SolMuller = new SolEc1Var();

            bool r;
            Complex AproxRaiz = new Complex();

            if (txtp0_real.Text == "" || txtp1_imaginaria.Text == "" || txtp2_real.Text == "" || txtp2_real.Text == "" || txtp0_imaginaria.Text == "" || txtp0_imaginaria.Text == "" || txtErrorMax.Text == "" || txtNumMaxIter.Text == "" || txtFuncion.Text == "")
            {
                MessageBox.Show("Llena todos los campos correctamente para continuar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {

                SolMuller.p0 = new Complex(
                double.Parse(txtp0_real.Text),
                double.Parse(txtp0_imaginaria.Text)
                );
                SolMuller.p1 = new Complex(
                    double.Parse(txtp1_real.Text),
                    double.Parse(txtp1_imaginaria.Text)
                );
                SolMuller.p2 = new Complex(
                    double.Parse(txtp2_real.Text),
                    double.Parse(txtp2_imaginaria.Text)
                );

                SolMuller.ErrorMax = float.Parse(txtErrorMax.Text);
                SolMuller.NumMaxIter = int.Parse(txtNumMaxIter.Text);
                SolMuller.FuncionTexto = txtFuncion.Text;

                dgvMuller.Rows.Clear();


                r = SolMuller.Muller(ref AproxRaiz, ref dgvMuller);

                if (r)
                {
                    MessageBox.Show("Raíz encontrada: " + AproxRaiz.ToString(),
                                    "Resultado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
