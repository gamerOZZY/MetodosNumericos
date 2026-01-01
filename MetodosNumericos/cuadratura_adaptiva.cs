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
    public partial class cuadratura_adaptiva : Form
    {
        PythonBridge puente;
        public cuadratura_adaptiva()
        {
            InitializeComponent();
            puente = new PythonBridge();
            picGrafica.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener Inputs
                if (string.IsNullOrWhiteSpace(txtFuncion.Text)) throw new Exception("Ingresa la funcion.");

                string func = txtFuncion.Text.ToLower().Replace("^", "**");
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double tol = double.Parse(txtError.Text);

                if (tol <= 0) throw new Exception("La tolerancia debe ser mayor a 0.");

                // 2. Calcular Integral y obtener Nodos
                var resultado = puente.CalcularAdaptativa(func, a, b, tol);

                // 3. Mostrar Resultados Numéricos
                lblResultado.Text = $"Área Aprox: {resultado.Area:F8} u²";
                lblNodos.Text = $"Sub-intervalos generados: {resultado.PuntosCorte.Count - 1}";

                // 4. Generar Gráfica Visualizando los Nodos
                if (picGrafica.Image != null) picGrafica.Image.Dispose();

                // Le pasamos la lista de puntos exacta que uso el algoritmo
                Image img = puente.ObtenerGraficaAdaptativa(func, resultado.PuntosCorte);
                picGrafica.Image = img;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Numerico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFuncion.Clear();
            txtA.Clear();
            txtB.Clear();
            txtError.Text = "0.001";
            lblResultado.Text = "Resultado: --";
            lblNodos.Text = "Nodos: --";
            if (picGrafica.Image != null) picGrafica.Image = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void picGrafica_Click(object sender, EventArgs e)
        {

        }
    }
}
