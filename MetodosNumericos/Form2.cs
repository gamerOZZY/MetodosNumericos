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
    public partial class frmBiseccion : Form
    {
        PythonBridge puente;
        private void ConfigurarTabla()
        {
            dgvBiseccion.Columns.Clear();
            dgvBiseccion.Columns.Add("Iter", "Iter");
            dgvBiseccion.Columns.Add("a", "a");
            dgvBiseccion.Columns.Add("b", "b");
            dgvBiseccion.Columns.Add("xr", "c");
            dgvBiseccion.Columns.Add("fxr", "f(c)");
            dgvBiseccion.Columns.Add("error", "Error ");
            dgvBiseccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public frmBiseccion()
        {
            InitializeComponent();
            puente = new PythonBridge();
            ConfigurarTabla();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar Inputs
                if (string.IsNullOrWhiteSpace(txtFuncion.Text)) throw new Exception("Falta funcion");

                string func = txtFuncion.Text.ToLower().Replace("^", "**");
                double a = double.Parse(txtValorA.Text);
                double b = double.Parse(txtValorB.Text);
                double tol = double.Parse(txtErrorMax.Text);
                int maxIter = int.Parse(txtNumMaxIter.Text);

                // 2. Obtener Tabla desde Python
                var tabla = puente.CalcularBiseccion(func, a, b, tol, maxIter);

                // 3. Llenar DataGridView
                this.dgvBiseccion.Rows.Clear();
                ConfigurarTabla();

                foreach (var fila in tabla)
                {
                    this.dgvBiseccion.Rows.Add(
                        (int)fila[0],     
                        fila[1].ToString("F8"),  
                        fila[2].ToString("F8"),  
                        fila[3].ToString("F8"), 
                        fila[4].ToString("F8"), 
                        fila[5].ToString("F8"), 
                        fila[6].ToString("F8"),  
                        fila[7].ToString("F8")   
                    );
                }

                double raizFinal = tabla[tabla.Count - 1][2]; 
                MessageBox.Show($"Raíz aproximada: {raizFinal:F8}");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmBiseccion_Load(object sender, EventArgs e)
        {


        }

        private void dgvBiseccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
