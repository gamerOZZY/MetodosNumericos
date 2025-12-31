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
    public partial class neville : Form
    {

        PythonBridge puente;
        List<double> listaX = new List<double>();
        List<double> listaY = new List<double>();
        public neville()
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaX.Count < 2) throw new Exception("Se necesitan al menos 2 puntos.");
                if (string.IsNullOrWhiteSpace(txtPuntoInteres.Text)) throw new Exception("Ingresa el punto a interpolar.");

                double xInteres = double.Parse(txtPuntoInteres.Text);

                // 1. OBTENER MATRIZ NEVILLE
                var matriz = puente.CalcularNeville(listaX, listaY, xInteres);

                // 2. MOSTRAR EN DATAGRIDVIEW
                dgvTablaNeville.Rows.Clear();
                dgvTablaNeville.Columns.Clear();

                // Columnas Q0, Q1, Q2...
                for (int k = 0; k < matriz.Count; k++)
                {
                    dgvTablaNeville.Columns.Add($"Q{k}", $"Q{k}");
                }

                // Llenar Filas
                for (int i = 0; i < matriz.Count; i++)
                {
                    int r = dgvTablaNeville.Rows.Add();
                    dgvTablaNeville.Rows[r].HeaderCell.Value = $"i={i} (x={listaX[i]})"; // Info extra en cabecera

                    // Llenamos solo la parte triangular inferior (j <= i)
                    for (int j = 0; j <= i; j++)
                    {
                        dgvTablaNeville.Rows[r].Cells[j].Value = matriz[i][j].ToString("F6");
                    }
                }

                // 3. MOSTRAR RESULTADO (Esquina inferior derecha Q[n-1][n-1])
                int ultimoIdx = matriz.Count - 1;
                double resultadoFinal = matriz[ultimoIdx][ultimoIdx];
                lblResultado.Text = $"Resultado f({xInteres}) ≈ {resultadoFinal:F6}";

                // 4. GRAFICAR (Reutilizamos la lógica existente)
                // Usamos la función de Newton/Interpolación general, ya que el polinomio es único.
                if (picGrafica.Image != null) picGrafica.Image.Dispose();

                Image img = puente.ObtenerGraficaNewton(listaX, listaY, xInteres);
                picGrafica.Image = img;

            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listaX.Clear(); listaY.Clear();
            dgvDatos.Rows.Clear();
            dgvTablaNeville.Rows.Clear(); dgvTablaNeville.Columns.Clear();
            lblResultado.Text = "Resultado: --";
            if (picGrafica.Image != null) picGrafica.Image = null;
        }
    }
}
