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
    public partial class derivadaExtrapolacion : Form
    {
        PythonBridge puente;
        public derivadaExtrapolacion()
        {
            InitializeComponent();
            puente = new PythonBridge();

            // Llenar combo de niveles por defecto
            cboNiveles.Items.AddRange(new object[] { "3", "4", "5", "6" });
            cboNiveles.SelectedIndex = 1; // Selecciona 4 por defecto
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFuncion.Clear();
            txtX.Clear();
            txtH.Clear();
            dgvMatriz.Rows.Clear();
            dgvMatriz.Columns.Clear();
            lblResultado.Text = "Resultado: --";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener Datos
                string func = txtFuncion.Text.ToLower();
                double xVal = double.Parse(txtX.Text);
                double hVal = double.Parse(txtH.Text);
                int niveles = int.Parse(cboNiveles.SelectedItem.ToString());

                // 2. Llamar al Puente
                List<List<double>> matriz = puente.CalcularRichardson(func, xVal, hVal, niveles);

                // 3. Configurar DataGridView
                dgvMatriz.Rows.Clear();
                dgvMatriz.Columns.Clear();

                // Crear columnas  (Nivel 1, Nivel 2...)
                // Nivel 1 es O(h^2), Nivel 2 es O(h^4), etc.
                for (int k = 0; k < niveles; k++)
                {
                    dgvMatriz.Columns.Add($"Col{k}", $"O(h^{2 * (k + 1)})");
                }

                // 4. Llenar Filas
                for (int i = 0; i < matriz.Count; i++)
                {
                    // Agregamos una fila vacía
                    int rowIndex = dgvMatriz.Rows.Add();

                    // Llenamos las celdas de esa fila
                    for (int j = 0; j < matriz[i].Count; j++)
                    {
                        dgvMatriz.Rows[rowIndex].Cells[j].Value = matriz[i][j].ToString("F8"); // 8 decimales
                    }

                    // Poner encabezado de fila 
                    double hFila = hVal / Math.Pow(2, i);
                    dgvMatriz.Rows[rowIndex].HeaderCell.Value = $"h={hFila}";
                }

                // 5. Mostrar Resultado Final (Último valor de la última fila)
                var ultimaFila = matriz[matriz.Count - 1];
                double resultadoFinal = ultimaFila[ultimaFila.Count - 1];

                lblResultado.Text = $"Resultado Aproximado: {resultadoFinal:F8}";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void derivadaExtrapolacion_Load(object sender, EventArgs e)
        {

        }
    }
}
