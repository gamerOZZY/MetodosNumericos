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
    public partial class diferenciasDivididas : Form
    {

        PythonBridge puente;
        List<double> listaX = new List<double>();
        List<double> listaY = new List<double>();
        public diferenciasDivididas()
        {
            InitializeComponent();
            // Configurar columnas del DGV de Puntos
            puente = new PythonBridge();
            
            dgvDatos.Columns.Add("X", "X");
            dgvDatos.Columns.Add("Y", "Y");

            // Llenar combo
            cboTipo.Items.Add("Hacia adelante");
            cboTipo.Items.Add("Hacia atras Atras");
            cboTipo.SelectedIndex = 0;
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

                txtX.Text = ""; 
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listaX.Clear(); listaY.Clear();
            dgvDatos.Rows.Clear(); dgvTabla.Rows.Clear(); dgvTabla.Columns.Clear();
            txtPolinomio.Clear();
            if (picGrafica.Image != null) picGrafica.Image = null;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaX.Count < 2) throw new Exception("Se necesitan al menos 2 puntos.");

                // OBTENER Y MOSTRAR TABLA DE DIFERENCIAS
                var matriz = puente.ObtenerTablaDiferencias(listaX, listaY);

                dgvTabla.Rows.Clear();
                dgvTabla.Columns.Clear();

                // Crear columnas
                dgvTabla.Columns.Add("y", "f(x)");
                for (int k = 1; k < matriz.Count; k++)
                {
                    dgvTabla.Columns.Add($"dif{k}", $"{k}ª Dif");
                }

                // Llenar filas
                for (int i = 0; i < matriz.Count; i++)
                {
                    int r = dgvTabla.Rows.Add();
                    dgvTabla.Rows[r].HeaderCell.Value = listaX[i].ToString(); // Poner X en el encabezado

                    // Solo llenamos hasta donde corresponde (matriz triangular)
                    // En diferencias divididas, la fila i tiene i+1 elementos validos? 
                    // No, en la logica F[i][j], llenamos toda la triangular inferior.
                    //(si, me respondi yo solo la pregunta, ME ESTOYVOLVIENDOLOCOCARAJO)
                    for (int j = 0; j <= i; j++)
                    {
                        dgvTabla.Rows[r].Cells[j].Value = matriz[i][j].ToString("F5");
                    }
                }

                //OBTENER POLINOMIO TEXTO
                string tipo = cboTipo.SelectedIndex == 0 ? "adelante" : "atras";
                string textoPolinomio = puente.ObtenerPolinomioTexto(listaX, listaY, tipo);
                txtPolinomio.Text = textoPolinomio;

                //GRAFICAR (Reutilizamos la funcion de difdiv de las derivadas anterior)
                // Nota: La gráfica es la misma sin importar si es adelante o atras
                //se usa un punto random para el punto deseado que se pedia en la funcion, realmente es indiferente el punto
                //dado que solo queremos la grafica, entonces da igual gg
                Image img = puente.ObtenerGraficaNewton(listaX, listaY, listaX[0]);
                if (picGrafica.Image != null) picGrafica.Image.Dispose();
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
