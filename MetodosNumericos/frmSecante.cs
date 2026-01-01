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
    public partial class frmSecante : Form
    {
        PythonBridge puente;
        private void ConfigurarTabla()
        {

            dgvSecante.Columns.Clear();
            dgvSecante.Columns.Add("Iter", "i");
            dgvSecante.Columns.Add("p0", "p0 (Anterior)");
            dgvSecante.Columns.Add("p1", "p1 (Actual)");
            dgvSecante.Columns.Add("p2", "p2 (Siguiente)");
            dgvSecante.Columns.Add("fp2", "f(p2)");
            dgvSecante.Columns.Add("error", "Error Aprox");

            dgvSecante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public frmSecante()
        {
            InitializeComponent();
            puente = new PythonBridge();
            ConfigurarTabla();
        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFuncion.Text)) throw new Exception("Falta función");

                string func = txtFuncion.Text.ToLower().Replace("^", "**");

                double p0 = double.Parse(txtValorA.Text);
                double p1 = double.Parse(txtValorB.Text);

                double tol = double.Parse(txtErrorMax.Text);
                int maxIter = int.Parse(txtNumMaxIter.Text);

                var tabla = puente.CalcularSecante(func, p0, p1, tol, maxIter);

                dgvSecante.Rows.Clear();

                foreach (var fila in tabla)
                {
                    dgvSecante.Rows.Add(
                        (int)fila[0],       
                        fila[1].ToString("F8"), 
                        fila[2].ToString("F8"),
                        fila[3].ToString("F8"), 
                        fila[4].ToString("F8"),
                        fila[5].ToString("F8")  
                    );
                }

                double raiz = tabla[tabla.Count - 1][3]; 
                MessageBox.Show($"Raíz encontrada: {raiz:F8}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
