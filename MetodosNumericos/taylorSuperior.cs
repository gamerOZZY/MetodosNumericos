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
    public partial class taylorSuperior : Form
    {
        PythonBridge puente;
        private void ConfigurarGrid()
        {
            dgvTablaTaylor.Columns.Clear();
            dgvTablaTaylor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTablaTaylor.Columns.Add("i", "i");
            dgvTablaTaylor.Columns.Add("t", "ti");
            dgvTablaTaylor.Columns.Add("w2", "Taylor Orden 2");
            dgvTablaTaylor.Columns.Add("w3", "Taylor Orden 3");
            dgvTablaTaylor.Columns.Add("w4", "Taylor Orden 4");
        }
        public taylorSuperior()
        {
            InitializeComponent();
            puente = new PythonBridge();
            ConfigurarGrid();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(txtEcuacion.Text))
                    throw new Exception("Ingresa la ecuaciozn y'.");

                double t0 = double.Parse(txtT0.Text);
                double w0 = double.Parse(txtW0.Text);
                double h = double.Parse(txtH.Text);
                double tFinal = double.Parse(txtTFinal.Text);

                if (h <= 0) throw new Exception("El paso h debe ser positivo.");

                // Llamada a apiTOn
                var resultados = puente.ResolverEDO_Taylor(txtEcuacion.Text, t0, w0, h, tFinal);

                // Llenar Grid
                dgvTablaTaylor.Rows.Clear();
                foreach (var fila in resultados)
                {
                    dgvTablaTaylor.Rows.Add(
                        fila.Iteracion,
                        fila.T.ToString("F8"),
                        fila.W_Orden2.ToString("F8"),
                        fila.W_Orden3.ToString("F8"),
                        fila.W_Orden4.ToString("F8")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEcuacion.Clear();
            txtT0.Clear();
            txtW0.Clear();
            txtH.Clear();
            txtTFinal.Clear();
            dgvTablaTaylor.Rows.Clear();
            txtEcuacion.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
