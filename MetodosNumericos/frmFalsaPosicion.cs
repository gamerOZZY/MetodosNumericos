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
    public partial class frmFalsaPosicion : Form
    {
        public frmFalsaPosicion()
        {
            InitializeComponent();
        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            SolEc1Var SolFalsa = new SolEc1Var();

            bool r;
            double AproxRaiz = 0;

            if (txtValorA.Text == "" || txtValorB.Text == "" || txtErrorMax.Text == "" || txtNumMaxIter.Text == "" || txtFuncion.Text == "")
            {
                MessageBox.Show("Llena todos los campos correctamente para continuar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SolFalsa.a1 = double.Parse(txtValorA.Text);
                SolFalsa.b1 = double.Parse(txtValorB.Text);
                SolFalsa.ErrorMax = float.Parse(txtErrorMax.Text);
                SolFalsa.NumMaxIter = int.Parse(txtNumMaxIter.Text);
                SolFalsa.FuncionTexto = txtFuncion.Text;
                SolFalsa.PrepararFuncion();

                r = SolFalsa.MetFalsaPos(ref dgvFalsaPos, ref AproxRaiz);
                if (r)
                {
                    MessageBox.Show("Raíz encontrada: " + AproxRaiz.ToString(),
                                    "Resultado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

            }

           


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
