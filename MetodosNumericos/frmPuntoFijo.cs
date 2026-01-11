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
    public partial class frmPuntoFijo : Form
    {
        PythonBridge puente;
        private void ConfigurarTabla()
        {
            dgvPuntoFijo.Columns.Clear();
            dgvPuntoFijo.Columns.Add("Iter", "i");
            dgvPuntoFijo.Columns.Add("p0", "p0 (Actual)");
            dgvPuntoFijo.Columns.Add("p1", "p1 (Siguiente)");
            dgvPuntoFijo.Columns.Add("error", "Error Aprox");
            dgvPuntoFijo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public frmPuntoFijo()
        {
            InitializeComponent();
            puente = new PythonBridge();
            ConfigurarTabla();
        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtGuncion.Text)) throw new Exception("Ingresa la funcion g(x).");

                string g_func = txtGuncion.Text.ToLower().Replace("^", "**");

                double p0 = double.Parse(txtValorA.Text);

                double tol = double.Parse(txtErrorMax.Text);
                int maxIter = int.Parse(txtNumMaxIter.Text);

                var tabla = puente.CalcularPuntoFijo(g_func, p0, tol, maxIter);
                dgvPuntoFijo.Rows.Clear();

                foreach (var fila in tabla)
                {
                    dgvPuntoFijo.Rows.Add(
                        (int)fila[0],        
                        fila[1].ToString("F8"),
                        fila[2].ToString("F8"), 
                        fila[3].ToString("F8")   
                    );
                }


                double raiz = tabla[tabla.Count - 1][2]; 
                MessageBox.Show($"Raíz aproximada: {raiz:F8}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        


    }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPuntoFijo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtErrorMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPuntoFijo_Load(object sender, EventArgs e)
        {

        }

        private void txtNumMaxIter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
