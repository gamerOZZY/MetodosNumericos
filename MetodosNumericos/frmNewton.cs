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
    public partial class frmNewton : Form
    {
        public frmNewton()
        {
            InitializeComponent();
        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            SolEc1Var SolNewton = new SolEc1Var();

            bool r;
            float AproxRaiz = 0;
            if (txtValorA.Text == "" ||  txtErrorMax.Text == "" || txtNumMaxIter.Text == "" || txtFuncion.Text == "")
            {
                MessageBox.Show("Llena todos los campos para continuar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SolNewton.a = float.Parse(txtValorA.Text);

                SolNewton.ErrorMax = float.Parse(txtErrorMax.Text);
                SolNewton.NumMaxIter = int.Parse(txtNumMaxIter.Text);
                SolNewton.FuncionTexto = txtFuncion.Text;
                SolNewton.PrepararFuncion();

                r = SolNewton.MetNewtonRaphson(ref dgvNewton, ref AproxRaiz);
                if (r)
                {
                    MessageBox.Show("Raíz encontrada: " + AproxRaiz.ToString(),
                                    "Resultado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }



            }
                


        }

        private void frmNewton_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
