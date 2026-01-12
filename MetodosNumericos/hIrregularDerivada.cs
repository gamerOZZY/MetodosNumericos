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
    public partial class hIrregularDerivada : Form
    {
        PythonBridge puente;
        List<double> listaX = new List<double>();
        List<double> listaY = new List<double>();
        public hIrregularDerivada()
        {
            InitializeComponent();
            try
            {
                puente = new PythonBridge(); // Iniciar motor


                try
                {
                    puente = new PythonBridge();


                    dgvDatos.DataSource = null; 
                    dgvDatos.Columns.Clear();   
                    dgvDatos.Columns.Add("ColX", "X");
                    dgvDatos.Columns.Add("ColY", "Y");
                    dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtFuncionNewton.Text)) throw new Exception("Falta la función");
                if (string.IsNullOrWhiteSpace(txtX.Text)) throw new Exception("Falta X");

                double xVal = double.Parse(txtX.Text);
                string func = txtFuncionNewton.Text.ToLower(); // "x**2"

                // 1. Usamos el puente para calcular Y
                double yVal = puente.ObtenerY(func, xVal);

                // 2. Guardamos en memoria
                listaX.Add(xVal);
                listaY.Add(yVal);

                // 3. Mostramos en la tabla
                dgvDatos.Rows.Add(xVal, yVal);

                // Limpiar input X para meter el siguiente rapido
                txtX.Text = "";
                txtX.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listaX.Clear();
            listaY.Clear();
            dgvDatos.Rows.Clear();
            lblResultado.Text = "Resultado: --";
            // Limpiar gráfica
            if (picGrafica.Image != null)
            {
                picGrafica.Image.Dispose();
                picGrafica.Image = null;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaX.Count < 2) throw new Exception("Necesitas al menos 2 puntos.");
                if (string.IsNullOrWhiteSpace(txtPuntoInteres.Text)) throw new Exception("Introduce el punto X.");

                double xInteres = double.Parse(txtPuntoInteres.Text);

                // 1. Calcular el valor numérico de la derivada
                double resultado = puente.CalcularDerivadaNewton(listaX, listaY, xInteres);
                lblResultado.Text = $"Derivada en x={xInteres}: {resultado:F5}";

                // 2. --- NUEVO: Obtener y mostrar la gráfica ---
                // Limpiamos imagen anterior si existe para liberar memoria
                if (picGrafica.Image != null) picGrafica.Image.Dispose();

                // Pedimos la nueva imagen al puente
                Image grafica = puente.ObtenerGraficaNewton(listaX, listaY, xInteres);

                // La asignamos al PictureBox
                picGrafica.Image = grafica;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hIrregularDerivada_Load(object sender, EventArgs e)
        {

        }
    }
}
