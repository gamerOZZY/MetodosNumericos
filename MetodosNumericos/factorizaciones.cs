using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MetodosNumericos.PythonBridge;

namespace MetodosNumericos
{
    public partial class factorizaciones : Form
    {
        PythonBridge puente;
        List<List<double>> matrizInput;
        int dimensionN;
        private void ConfiguracionInicial()
        {

            dgvMatrizOriginal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatrizL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatrizU.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatrizP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cboMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public factorizaciones()
        {
            InitializeComponent();
            puente = new PythonBridge();
            matrizInput = new List<List<double>>();
            ConfiguracionInicial();
        }
        private void LlenarGrid(DataGridView dgv, List<List<double>> datos)
        {
            dgv.Rows.Clear();
            foreach (var fila in datos)
            {
                dgv.Rows.Add(fila.Select(x => (object)x.ToString("F4")).ToArray());
            }
        }
        private void LimpiarGrids()
        {
            dgvMatrizOriginal.Rows.Clear(); dgvMatrizOriginal.Columns.Clear();
            dgvMatrizL.Rows.Clear(); dgvMatrizL.Columns.Clear();
            dgvMatrizU.Rows.Clear(); dgvMatrizU.Columns.Clear();
            dgvMatrizP.Rows.Clear(); dgvMatrizP.Columns.Clear();
        }
        private void FinalizarIngresoDatos()
        {
            txtFilaInput.Enabled = false;
            btnAgregarFila.Enabled = false;
            try
            {
                List<string> metodosPosibles = puente.ObtenerMetodosValidos(matrizInput);

                cboMetodo.Items.Clear();
                if (metodosPosibles.Count == 0)
                {
                    MessageBox.Show("Error Critico: matriz mal formada (nada que hacer).");
                    return;
                }

                foreach (string m in metodosPosibles) cboMetodo.Items.Add(m);

                cboMetodo.SelectedIndex = 0;
                cboMetodo.Enabled = true;
                btnCalcular.Enabled = true;
                lblInstruccion.Text = "Matriz completa. Selecciona Metodo.";

                MessageBox.Show("Analisis Completo.\nSe han filtrado los metodos disponibles segun la matriz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion Python: " + ex.Message);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            dimensionN = (int)numDimension.Value;
            matrizInput.Clear();
            LimpiarGrids();
            btnCalcular.Enabled = true;
            btnAgregarFila.Enabled = true;
            txtFilaInput.Enabled = true;
            cboMetodo.Enabled = true;


            // Crear columnas  (x0, x1, x2...)
            for (int i = 0; i < dimensionN; i++)
            {
                dgvMatrizOriginal.Columns.Add($"c{i}", $"Col {i + 1}");
                dgvMatrizL.Columns.Add($"l{i}", $"L {i + 1}");
                dgvMatrizU.Columns.Add($"u{i}", $"U {i + 1}");
                dgvMatrizP.Columns.Add($"p{i}", $"P {i + 1}");
            }



            txtFilaInput.Focus();
            lblInstruccion.Text = "Ingresa Fila 1 (separada por comas):";

        }

        private void AgregarFila_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrizInput.Count >= dimensionN) return;

                // 1. Parsear datos
                string[] partes = txtFilaInput.Text.Split(',');
                if (partes.Length != dimensionN)
                    throw new Exception($"Se requieren {dimensionN} valores.");

                List<double> filaNueva = new List<double>();
                foreach (var p in partes)
                {
                    if (!double.TryParse(p.Trim(), out double val))
                        throw new Exception($"Valor invalido: '{p}'");
                    filaNueva.Add(val);
                }

                // 2. Agregar a memoria y Grid
                matrizInput.Add(filaNueva);
                dgvMatrizOriginal.Rows.Add(filaNueva.Select(x => (object)x).ToArray());
                txtFilaInput.Clear();
                txtFilaInput.Focus();

                // 3. Verificar si terminamos
                if (matrizInput.Count == dimensionN)
                {
                    FinalizarIngresoDatos();
                }
                else
                {
                    lblInstruccion.Text = $"Ingresa fila {matrizInput.Count + 1}:";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboMetodo.SelectedItem == null) return;
                string metodo = cboMetodo.SelectedItem.ToString();

                ResultadoFactorizacion res = puente.CalcularFactorizacion(matrizInput, metodo);

                LlenarGrid(dgvMatrizL, res.MatrizL);
                LlenarGrid(dgvMatrizU, res.MatrizU);
                LlenarGrid(dgvMatrizP, res.MatrizP);

                lblInstruccion.Text = "Calculo exitoso.";
                if (metodo == "LLT (Cholesky)") { lblU.Text = "matriz Lt"; }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error matematico: " + ex.Message);
            }

        }
        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarGrids();
            matrizInput.Clear();

            btnIniciar.Enabled = true;
            numDimension.Enabled = true;
            btnCalcular.Enabled = false;
            btnAgregarFila.Enabled = false;
            txtFilaInput.Enabled = false;
            cboMetodo.Enabled = false;
            cboMetodo.Items.Clear();

            lblInstruccion.Text = "Esperando...";
            lblU.Text = "Matriz U";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
