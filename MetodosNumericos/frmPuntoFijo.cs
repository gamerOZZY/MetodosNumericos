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
    public partial class frmPuntoFijo : Form
    {
        public frmPuntoFijo()
        {
            InitializeComponent();
        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            SolEc1Var SolPF = new SolEc1Var();

            bool r;
            float AproxRaiz = 0;
            if (txtValorA.Text == "" || txtGuncion.Text == "" || txtErrorMax.Text == "" || txtNumMaxIter.Text == "" || txtFuncion.Text == "")
            {
                MessageBox.Show("Llena todos los campos correctamente para continuar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SolPF.a = float.Parse(txtValorA.Text);
                SolPF.ErrorMax = float.Parse(txtErrorMax.Text);
                SolPF.NumMaxIter = int.Parse(txtNumMaxIter.Text);
                SolPF.FuncionTexto = txtFuncion.Text;
                SolPF.GuncionTexto = txtGuncion.Text;
                SolPF.PrepararFunciong();

                r = SolPF.MetodoPuntoFijo(ref dgvPuntoFijo, ref AproxRaiz);

                if (r)
                    MessageBox.Show("Aprox raíz = " + AproxRaiz.ToString("F6"));
                else
                    MessageBox.Show("No convergió en el número máximo de iteraciones");
            }
                
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
