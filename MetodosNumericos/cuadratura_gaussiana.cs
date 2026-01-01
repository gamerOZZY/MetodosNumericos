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
    public partial class cuadratura_gaussiana : Form
    {
        PythonBridge puente;
        public cuadratura_gaussiana()
        {
            InitializeComponent();
            puente = new PythonBridge();

            cboPuntos.Items.Add("2");
            cboPuntos.Items.Add("3");
            cboPuntos.Items.Add("4");
            cboPuntos.Items.Add("5");
            cboPuntos.Items.Add("6");
            cboPuntos.SelectedIndex = 0; 
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar Inputs
                if (string.IsNullOrWhiteSpace(txtFuncion.Text)) throw new Exception("Falta funcion.");

                string func = txtFuncion.Text.ToLower().Replace("^", "**");
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);

                if (cboPuntos.SelectedItem == null) throw new Exception("Selecciona n puntos.");
                int n = int.Parse(cboPuntos.SelectedItem.ToString());

                // 2. Calcular Integral
                double resultado = puente.CalcularGauss(func, a, b, n);
                lblResultado.Text = $"Integral (Gauss n={n}): {resultado:F8}";

                // 3. Graficar
                if (picGrafica.Image != null) picGrafica.Image.Dispose();

                Image img = puente.ObtenerGraficaGauss(func, a, b, n);
                picGrafica.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFuncion.Clear();
            txtA.Clear();
            txtB.Clear();
            lblResultado.Text = "Resultado: --";
            if (picGrafica.Image != null) picGrafica.Image = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
