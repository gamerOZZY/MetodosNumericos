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
    public partial class frmSecante : Form
    {
        public frmSecante()
        {
            InitializeComponent();
        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            SolEc1Var SolSec = new SolEc1Var();

            bool r;
            double AproxRaiz = 0;

            if (txtValorA.Text == "" || txtValorB.Text == "" || txtErrorMax.Text == "" || txtNumMaxIter.Text == "" || txtFuncion.Text == "")
            {
                MessageBox.Show("Llena todos los campos correctamente para continuar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {

                SolSec.a = float.Parse(txtValorA.Text);
                SolSec.b = float.Parse(txtValorB.Text);
                SolSec.ErrorMax = float.Parse(txtErrorMax.Text);
                SolSec.NumMaxIter = int.Parse(txtNumMaxIter.Text);
                SolSec.FuncionTexto = txtFuncion.Text;
                SolSec.PrepararFuncion();


                dgvSecante.Rows.Clear();

                r = SolSec.MetSecante(ref dgvSecante, ref AproxRaiz);

                if (r)
                {
                    MessageBox.Show("Raíz encontrada: " + AproxRaiz.ToString("F6"),
                                    "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
