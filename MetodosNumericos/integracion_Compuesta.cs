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
    public partial class integracion_Compuesta : Form
    {
        PythonBridge puente;
        List<double> listaX = new List<double>();
        List<double> listaY = new List<double>();
        double? pasoH = null; // Guardamos el H obligatorio
        public integracion_Compuesta()
        {
            InitializeComponent();
            puente = new PythonBridge();

            dgvDatos.Columns.Add("X", "X");
            dgvDatos.Columns.Add("Y", "Y");

        }

        private void ActualizarMetodosDisponibles()
        {
            cboMetodos.Items.Clear();
            int n = listaX.Count - 1; // Numero de Intervalos

            if (n < 1) return;

            // Regla 1: Trapecio siempre disponible si n >= 1
            cboMetodos.Items.Add("Trapecio");

            // Regla 2: Simpson 1/3 si Intervalos son PARES
            if (n % 2 == 0) cboMetodos.Items.Add("Simpson 1/3");

            // Regla 3: Simpson 3/8 si Intervalos son Múltiplo de 3
            if (n % 3 == 0) cboMetodos.Items.Add("Simpson 3/8");

            if (cboMetodos.Items.Count > 0) cboMetodos.SelectedIndex = 0;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                double xNuevo = double.Parse(txtX.Text);
                string func = txtFuncion.Text.ToLower().Replace("^", "**");

                // VALIDACION DE H
                if (listaX.Count > 0)
                {
                    double xAnterior = listaX[listaX.Count - 1];
                    double hActual = Math.Round(xNuevo - xAnterior, 8); // 8 decimales de precision

                    if (hActual <= 0) { MessageBox.Show("X debe ser mayor que el anterior"); return; }

                    if (listaX.Count == 1) // Es el segundo punto (0 y 1)
                    {
                        pasoH = hActual; // FIJAMOS LA REGLA
                        lblPasoH.Text = "h = " + pasoH.ToString();
                    }
                    else // Del tercer punto en adelante
                    {
                        if (Math.Abs(hActual - (double)pasoH) > 0.0001)
                        {
                            MessageBox.Show($"¡Error! Debes respetar el paso h={pasoH}. Intentaste usar {hActual}.");
                            return;
                        }
                    }
                }

                // Calcular Y
                double yNuevo = puente.ObtenerY(func, xNuevo);

                listaX.Add(xNuevo);
                listaY.Add(yNuevo);
                dgvDatos.Rows.Add(xNuevo, yNuevo);

                // --- ACTUALIZAR COMBOBOX INTELIGENTE ---
                ActualizarMetodosDisponibles();

                txtX.Text = ""; txtX.Focus();

            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }

        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            listaX.Clear(); listaY.Clear();
            dgvDatos.Rows.Clear();
            pasoH = null;
            lblPasoH.Text = "h = --";
            lblResultado.Text = "Resultado: --";
            cboMetodos.Items.Clear();
            if (picGrafica.Image != null) picGrafica.Image = null;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (pasoH == null || listaX.Count < 2) throw new Exception("Faltan puntos.");
                if (cboMetodos.SelectedItem == null) throw new Exception("Elige un método.");

                string metodo = cboMetodos.SelectedItem.ToString();
                double h = (double)pasoH;

                // 1. Calcular Integral
                double resultado = puente.CalcularIntegral(listaY, h, metodo);
                lblResultado.Text = $"Área Aprox ({metodo}): {resultado:F8} u²";

                // 2. Graficar Sombreado
                if (picGrafica.Image != null) picGrafica.Image.Dispose();
                string funcLimpia = txtFuncion.Text.ToLower().Replace("^", "**");
                Image img = puente.ObtenerGraficaIntegracion(listaX, listaY, metodo, funcLimpia);
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
