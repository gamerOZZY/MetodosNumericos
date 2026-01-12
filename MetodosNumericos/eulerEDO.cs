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
    public partial class eulerEDO : Form
    {

        PythonBridge puente;
        private void ConfigurarGrid()
        {
            dgvTablaEuler.Columns.Clear();
            dgvTablaEuler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTablaEuler.Columns.Add("i", "Iteración (i)");
            dgvTablaEuler.Columns.Add("xi", "x");
            dgvTablaEuler.Columns.Add("wi", "Valor Actual (wi)");
            dgvTablaEuler.Columns.Add("wi_next", "Siguiente (wi+1)");
        }
        public eulerEDO()
        {
            InitializeComponent();
            puente = new PythonBridge();
            ConfigurarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validaciones basicas de entrada
                if (string.IsNullOrWhiteSpace(txtEcuacion.Text))
                    throw new Exception("Ingresa una ecuacion diferencial y' = f(x,y).");

                double x0 = double.Parse(txtX0.Text);
                double y0 = double.Parse(txtY0.Text);
                double h = double.Parse(txtH.Text);
                double xFinal = double.Parse(txtXFinal.Text);

                if (h <= 0) throw new Exception("El paso 'h' debe ser positivo.");
                if (xFinal <= x0) throw new Exception("X Final debe ser mayor que X0.");

                // 2. Llamada a paiton
                var resultados = puente.ResolverEDO_Euler(txtEcuacion.Text, x0, y0, h, xFinal);

                // 3. Mostrar resultados
                dgvTablaEuler.Rows.Clear();
                foreach (var fila in resultados)
                {
                    dgvTablaEuler.Rows.Add(
                        fila.Iteracion,
                        fila.X.ToString("F4"),
                        fila.Y_Actual.ToString("F6"),
                        fila.Y_Siguiente.ToString("F6")
                    );
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingresa numeros válidos en los campos numericos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEcuacion.Clear();
            txtX0.Clear();
            txtY0.Clear();
            txtH.Clear();
            txtXFinal.Clear();
            dgvTablaEuler.Rows.Clear();
            txtEcuacion.Focus();

        }

        private void dgvTablaEuler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eulerEDO_Load(object sender, EventArgs e)
        {

        }
    }
}
