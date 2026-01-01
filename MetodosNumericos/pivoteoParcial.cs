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

                // Parsear texto: "2, 3.5, -4, 10" -> List<double>
                string[] partes = txtFilaInput.Text.Split(',');

                if (partes.Length != dimensionN + 1)
                {
                    throw new Exception($"Debes ingresar exactamente {dimensionN + 1} valores (Coeficientes + Resultado).");
                }

                List<double> filaNueva = new List<double>();

                // Convertir y validar
                foreach (var p in partes)
                {
                    if (!double.TryParse(p.Trim(), out double val))
                        throw new Exception($"El valor '{p}' no es un número válido.");
                    filaNueva.Add(val);
                }

                // Agregar a memoria y al Grid
                matrizInput.Add(filaNueva);

                // Convertir List<double> a object[] para el DataGridView
                object[] rowObjects = filaNueva.Select(x => (object)x).ToArray();
                dgvMatrizOriginal.Rows.Add(rowObjects);

                txtFilaInput.Clear();
                txtFilaInput.Focus();

                // Verificar si terminamos
                if (matrizInput.Count == dimensionN)
                {
                    MessageBox.Show("Matriz completa. Pulsa Calcular.");
                    btnCalcular.Enabled = true;
                    txtFilaInput.Enabled = false;
                    btnAgregarFila.Enabled = false;
                }
                else
                {
                    // Indicador visual de qué fila sigue
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
                var resultado = puente.ResolverGauss(matrizInput);

                // A) Mostrar Matriz Triangular resultante
                dgvMatrizTriangular.Columns.Clear();
                // Copiamos las mismas columnas
                for (int i = 0; i < dimensionN; i++) dgvMatrizTriangular.Columns.Add($"x{i + 1}", $"x{i + 1}");
                dgvMatrizTriangular.Columns.Add("b", "=");

                foreach (var fila in resultado.MatrizTriangular)
                {
                    object[] rowObj = fila.Select(x => (object)x.ToString("F4")).ToArray();
                    dgvMatrizTriangular.Rows.Add(rowObj);
                }

                // B) Mostrar Raíces en MessageBox
                string mensajeRaices = "Solución del Sistema:\n\n";
                for (int i = 0; i < resultado.Raices.Count; i++)
                {
                    mensajeRaices += $"x{i + 1} = {resultado.Raices[i]:F6}\n";
                }

                MessageBox.Show(mensajeRaices, "Resultado Eliminación Gaussiana");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Matemático: " + ex.Message);
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
    }
}
