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
    public partial class frmNewton : Form
    {
        PythonBridge puente;

        private void ConfigurarTabla()
        {
            dgvNewton.Columns.Clear();
            dgvNewton.Columns.Add("Iter", "i");
            dgvNewton.Columns.Add("p0", "p0 (Actual)");
            dgvNewton.Columns.Add("p1", "p1 (Siguiente)");
            dgvNewton.Columns.Add("error", "Error (|p1-p0|)");

            dgvNewton.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public frmNewton()
        {
            InitializeComponent();
            puente = new PythonBridge();
            ConfigurarTabla();
        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtFuncion.Text)) throw new Exception("Falta funcion");

                string func = txtFuncion.Text.ToLower().Replace("^", "**");

                double p0 = double.Parse(txtValorA.Text);

                double tol = double.Parse(txtErrorMax.Text);
                int maxIter = int.Parse(txtNumMaxIter.Text);

                var tabla = puente.CalcularNewtonRaphson(func, p0, tol, maxIter);

                dgvNewton.Rows.Clear();

                foreach (var fila in tabla)
                {
                    dgvNewton.Rows.Add(
                        (int)fila[0],      
                        fila[1].ToString("F8"), 
                        fila[2].ToString("F8"), 
                        fila[3].ToString("F8")  
                    );
                }

                // Resultado
                double raiz = tabla[tabla.Count - 1][2]; 
                MessageBox.Show($"Raiz encontrada: {raiz:F6}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




    

        private void frmNewton_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNewton_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
