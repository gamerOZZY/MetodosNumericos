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
    public partial class romExtrapolacion : Form
    {
        PythonBridge puente;
        public romExtrapolacion()
        {
            InitializeComponent();
            puente = new PythonBridge();
            picGrafica.SizeMode = PictureBoxSizeMode.Zoom;

            cboNiveles.Items.Add("3");
            cboNiveles.Items.Add("4");
            cboNiveles.Items.Add("5");
            cboNiveles.Items.Add("6");
            cboNiveles.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener Datos
                if (string.IsNullOrWhiteSpace(txtFuncion.Text)) throw new Exception("Ingresa la funcion.");
                string func = txtFuncion.Text.ToLower().Replace("^", "**");

                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                int niveles = int.Parse(cboNiveles.SelectedItem.ToString());

                // 2. Calcular Matriz Romberg
                var matriz = puente.CalcularRomberg(func, a, b, niveles);

                // 3. Mostrar en DataGridView
                dgvRomberg.Rows.Clear();
                dgvRomberg.Columns.Clear();

                // Encabezados: O(h^2), O(h^4), O(h^6)...
                for (int k = 0; k < niveles; k++)
                {
                    dgvRomberg.Columns.Add($"Col{k}", $"O(h^{2 * (k + 1)})");
                }

                // Llenar filas
                for (int i = 0; i < matriz.Count; i++)
                {
                    int r = dgvRomberg.Rows.Add();
                    // Info del paso en el encabezado de fila (N segmentos)
                    int segmentos = (int)Math.Pow(2, i);
                    dgvRomberg.Rows[r].HeaderCell.Value = $"n=h/{segmentos}";

                    for (int j = 0; j < matriz[i].Count; j++)
                    {
                        dgvRomberg.Rows[r].Cells[j].Value = matriz[i][j].ToString("F8");
                    }
                }
                dgvRomberg.RowHeadersWidth = 70;

                // 4. Mostrar Resultado Final
                var ultimaFila = matriz[matriz.Count - 1];
                double resultadoFinal = ultimaFila[ultimaFila.Count - 1];
                lblResultado.Text = $"Resultado Romberg: {resultadoFinal:F8}";

                // 5. Graficar
                if (picGrafica.Image != null) picGrafica.Image.Dispose();
                Image img = puente.ObtenerGraficaRomberg(func, a, b);
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
            dgvRomberg.Rows.Clear();
            dgvRomberg.Columns.Clear();
            lblResultado.Text = "Resultado: --";
            if (picGrafica.Image != null) picGrafica.Image = null;

        }
    }
}
