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
    public partial class pivoteoParcial : Form
    {
        PythonBridge puente;
        List<List<double>> matrizInput;
        int dimensionN;

        private void ConfigurarGrids()
        {
            dgvMatrizOriginal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatrizTriangular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatrizOriginal.AllowUserToAddRows = false;
            dgvMatrizTriangular.AllowUserToAddRows = false;
        }
        public pivoteoParcial()
        {
            InitializeComponent();
            puente = new PythonBridge();
            matrizInput = new List<List<double>>();
            ConfigurarGrids();
            cboMetodo.Items.Add("Parcial");
            cboMetodo.Items.Add("Escalado");
            cboMetodo.Items.Add("Total");
            cboMetodo.SelectedIndex = 0; 
            cboMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarFila_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrizInput.Count >= dimensionN)
                {
                    MessageBox.Show("La matriz ya esta completa.");
                    return;
                }

                // Parsear texto: 2, 3.5, -4, 10 List<double>
                string[] partes = txtFilaInput.Text.Split(',');

                if (partes.Length != dimensionN + 1)
                {
                    throw new Exception($"Debes ingresar exactamente {dimensionN + 1} valores (Coeficientes + Resultado).");
                }

                List<double> filaNueva = new List<double>();

                // convertir y validar
                foreach (var p in partes)
                {
                    if (!double.TryParse(p.Trim(), out double val))
                        throw new Exception($"El valor '{p}' no es un número válido.");
                    filaNueva.Add(val);
                }

                // agregar a memoria y al Grid
                matrizInput.Add(filaNueva);

                // convertir List<double> a object[] para el DataGridView
                object[] rowObjects = filaNueva.Select(x => (object)x).ToArray();
                dgvMatrizOriginal.Rows.Add(rowObjects);

                txtFilaInput.Clear();
                txtFilaInput.Focus();

                // verificar si terminamos
                if (matrizInput.Count == dimensionN)
                {
                    MessageBox.Show("Matriz completa. Pulsa Calcular.");
                    btnCalcular.Enabled = true;
                    txtFilaInput.Enabled = false;
                    btnAgregarFila.Enabled = false;
                }
                else
                {
                    // indicador visual de que fila sigue
                    lblInstruccion.Text = $"Ingresa fila {matrizInput.Count + 1}:";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar fila: " + ex.Message);
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // validar que eligieron un metodo
                if (cboMetodo.SelectedItem == null) throw new Exception("Selecciona un metodo de pivoteo.");
                string metodoElegido = cboMetodo.SelectedItem.ToString();

                // llamar al puente con el metodo
                var resultado = puente.ResolverGauss(matrizInput, metodoElegido);

                // A) mostrar matriz triangular
                dgvMatrizTriangular.Rows.Clear();
                dgvMatrizTriangular.Columns.Clear();

                for (int i = 0; i < dimensionN; i++) dgvMatrizTriangular.Columns.Add($"x{i + 1}", $"x{i + 1}");
                dgvMatrizTriangular.Columns.Add("b", "=");

                foreach (var fila in resultado.MatrizTriangular)
                {
                    object[] rowObj = fila.Select(x => (object)x.ToString("F8")).ToArray();
                    dgvMatrizTriangular.Rows.Add(rowObj);
                }

                // B) Mostrar Raices (Ya reordenadas por Python si fue Pivoteo Total)
                string mensajeRaices = $"Solucion ({metodoElegido}):\n\n";
                for (int i = 0; i < resultado.Raices.Count; i++)
                {
                    mensajeRaices += $"x{i + 1} = {resultado.Raices[i]:F8}\n";
                }

                MessageBox.Show(mensajeRaices, "Resultado Eliminacion Gaussiana");
                lblInstruccion.Text = "Resultado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Matematico: " + ex.Message);
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            matrizInput.Clear();
            dgvMatrizOriginal.Rows.Clear(); dgvMatrizOriginal.Columns.Clear();
            dgvMatrizTriangular.Rows.Clear(); dgvMatrizTriangular.Columns.Clear();
            btnIniciar.Enabled = true;
            numDimension.Enabled = true;
            btnCalcular.Enabled = false;
            txtFilaInput.Clear();
            lblInstruccion.Text = "Esperando...";
            cboMetodo.SelectedIndex = 0;

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            dimensionN = (int)numDimension.Value;
            matrizInput.Clear();
            dgvMatrizOriginal.Rows.Clear();
            dgvMatrizOriginal.Columns.Clear();

            // Crear N columnas para X y 1 para el término independiente (B)
            for (int i = 0; i < dimensionN; i++)
            {
                dgvMatrizOriginal.Columns.Add($"x{i + 1}", $"x{i + 1}");
            }
            dgvMatrizOriginal.Columns.Add("b", "="); // Columna de resultados

            txtFilaInput.Enabled = true;
            btnAgregarFila.Enabled = true;
            btnIniciar.Enabled = false;
            numDimension.Enabled = false;

            MessageBox.Show($"Ingresa los {dimensionN + 1} valores de la Fila 1 separados por coma.");
            txtFilaInput.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvMatrizTriangular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
