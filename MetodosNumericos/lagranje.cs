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
    public partial class lagranje : Form
    {
        PythonBridge puente;
        List<double> listaX = new List<double>();
        List<double> listaY = new List<double>();
        public lagranje()
        {
            InitializeComponent();
            puente = new PythonBridge();

            dgvDatos.Columns.Add("X", "X");
            dgvDatos.Columns.Add("Y", "Y");
            picGrafica.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                double xVal = double.Parse(txtX.Text);
                string func = txtFuncion.Text.ToLower().Replace("^", "**");

                double yVal = puente.ObtenerY(func, xVal);

                listaX.Add(xVal);
                listaY.Add(yVal);
                dgvDatos.Rows.Add(xVal, yVal);

                txtX.Text = ""; txtX.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listaX.Clear(); listaY.Clear();
            dgvDatos.Rows.Clear();
            txtEcuacion.Clear();
            lblResultado.Text = "Resultado: --";
            if (picGrafica.Image != null) picGrafica.Image = null;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaX.Count < 2) throw new Exception("Se necesitan al menos 2 puntos.");
                if (string.IsNullOrWhiteSpace(txtPuntoInteres.Text)) throw new Exception("Falta punto de interés.");

                double xInteres = double.Parse(txtPuntoInteres.Text);

                // 1. Calcular Valor
                double resultado = puente.CalcularLagrange(listaX, listaY, xInteres);
                lblResultado.Text = $"Resultado f({xInteres}) ≈ {resultado:F6}";

                // 2. Obtener Ecuación
                string ecuacion = puente.ObtenerTextoLagrange(listaX, listaY);
                txtEcuacion.Text = ecuacion; // Asegúrate de que este TextBox tenga Multiline = True

                // 3. Graficar
                if (picGrafica.Image != null) picGrafica.Image.Dispose();
                Image img = puente.ObtenerGraficaLagrange(listaX, listaY, xInteres);
                picGrafica.Image = img;

            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
