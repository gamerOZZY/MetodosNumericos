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
    public partial class frmBiseccion : Form
    {
        public frmBiseccion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmCalcular_Click(object sender, EventArgs e)
        { 
            SolEc1Var SolBisec = new SolEc1Var();

            bool r;
            float AproxRaiz = 0;

            if(txtValorA.Text=="" || txtValorB.Text =="" || txtErrorMax.Text == "" || txtNumMaxIter.Text == "" || txtFuncion.Text == "") 
            {
                MessageBox.Show("Llena todos los campos correctamente para continuar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
                SolBisec.a = float.Parse(txtValorA.Text);
                SolBisec.b = float.Parse(txtValorB.Text);
                SolBisec.ErrorMax = float.Parse(txtErrorMax.Text);
                SolBisec.NumMaxIter = int.Parse(txtNumMaxIter.Text);
                SolBisec.FuncionTexto = txtFuncion.Text;
                SolBisec.PrepararFuncion();

                r = SolBisec.MetBiseccion(ref dgvBiseccion, ref AproxRaiz);
                if (r)
                {
                    MessageBox.Show("Raíz encontrada: " + AproxRaiz.ToString(),
                                    "Resultado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

            }
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmBiseccion_Load(object sender, EventArgs e)
        {


        }
    }
}
