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
    public partial class integracionMultiple : Form
    {
        PythonBridge puente;
        public integracionMultiple()
        {
            InitializeComponent();
            puente = new PythonBridge();
            cboMetodo.Items.Add("Trapecio ");
            cboMetodo.Items.Add("Simpson 1/3 ");
            cboMetodo.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFuncion.Text)) throw new Exception("Ingresa la funcion.");

                string func = txtFuncion.Text.ToLower().Replace("^", "**");
                double a = double.Parse(txtXa.Text);
                double b = double.Parse(txtXb.Text);
                double c = double.Parse(txtYc.Text);
                double d = double.Parse(txtYd.Text);

                // Obtenemos qué eligió el usuario
                string metodoElegido = cboMetodo.SelectedItem.ToString();

                // Llamamos al puente pasando el método
                double resultado = puente.CalcularIntegralDoble(func, a, b, c, d, metodoElegido);

                lblResultado.Text = $"Volumen ({metodoElegido}): {resultado:F8} u³";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFuncion.Clear();
            txtXa.Clear(); txtXb.Clear();
            txtYc.Clear(); txtYd.Clear();
            lblResultado.Text = "Volumen Aprox: --";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFuncion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
