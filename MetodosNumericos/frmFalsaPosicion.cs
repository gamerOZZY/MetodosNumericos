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
    public partial class frmFalsaPosicion : Form
    {
        PythonBridge puente;
        private void ConfigurarTabla()
    {
        dgvFalsaPos.Columns.Clear();

        dgvFalsaPos.Columns.Add("i", "i");
        dgvFalsaPos.Columns.Add("a", "a");
        dgvFalsaPos.Columns.Add("c", "c (Raíz)");
        dgvFalsaPos.Columns.Add("b", "b");
        dgvFalsaPos.Columns.Add("fa", "f(a)");
        dgvFalsaPos.Columns.Add("fc", "f(c)");
        dgvFalsaPos.Columns.Add("fb", "f(b)");
        dgvFalsaPos.Columns.Add("error", "Error Aprox");
        dgvFalsaPos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }
        public frmFalsaPosicion()
        {
            InitializeComponent();
            puente = new PythonBridge();
            ConfigurarTabla();
        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtFuncion.Text)) throw new Exception("Ingresa la funcion.");

                string func = txtFuncion.Text.ToLower().Replace("^", "**");
                double a = double.Parse(txtValorA.Text);
                double b = double.Parse(txtValorB.Text);
                double tol = double.Parse(txtErrorMax.Text);
                int maxIter = int.Parse(txtNumMaxIter.Text);


                var tabla = puente.CalcularFalsaPosicion(func, a, b, tol, maxIter);


                dgvFalsaPos.Rows.Clear();

                foreach (var fila in tabla)
                {
                    dgvFalsaPos.Rows.Add(
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

                // Resultado final
                double raizFinal = tabla[tabla.Count - 1][2];
                MessageBox.Show($"Raíz encontrada: {raizFinal:F6}", "Éxito");

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
