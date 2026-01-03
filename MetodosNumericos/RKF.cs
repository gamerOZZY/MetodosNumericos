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
    public partial class RKF : Form
    {
        PythonBridge puente;
        private void ConfigurarGrid()
        {
            //Hice las mismas columnas que en el archivo que nos envio solo que aca no puse el
            // error real pq no tenemos la aproximacion exacta gg
            dgvTablaRKF.Columns.Clear();
            dgvTablaRKF.AllowUserToAddRows = false;
            dgvTablaRKF.Columns.Add("i", "i");
            dgvTablaRKF.Columns.Add("h", "h");
            dgvTablaRKF.Columns.Add("t", "ti+1");
            dgvTablaRKF.Columns.Add("k1", "k1");
            dgvTablaRKF.Columns.Add("k2", "k2");
            dgvTablaRKF.Columns.Add("k3", "k3");
            dgvTablaRKF.Columns.Add("k4", "k4");
            dgvTablaRKF.Columns.Add("k5", "k5");
            dgvTablaRKF.Columns.Add("k6", "k6");
            dgvTablaRKF.Columns.Add("w4", "wi (Ord 4)");
            dgvTablaRKF.Columns.Add("w5", "Wi (Mejor)");
            dgvTablaRKF.Columns.Add("R", "R");
            dgvTablaRKF.Columns.Add("ok", "R<=Tol?");
            dgvTablaRKF.Columns.Add("part", "(Tol/R)^1/4");
            dgvTablaRKF.Columns.Add("q", "q");
            dgvTablaRKF.Columns.Add("qh", "q*h (Nuevo h)");
        }
        public RKF()
        {
            InitializeComponent();
            puente = new PythonBridge();
            ConfigurarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Inputs
                if (string.IsNullOrWhiteSpace(txtEcuacion.Text)) throw new Exception("Ingresa ecuacion.");

                double t0 = double.Parse(txtT0.Text);
                double w0 = double.Parse(txtW0.Text);
                double h = double.Parse(txtH.Text);
                double tf = double.Parse(txtTFinal.Text);
                double tol = double.Parse(txtTolerancia.Text);
                double fac = double.Parse(txtFactor.Text); // Ejemplo de claes: 0.84

                if (tol <= 0) throw new Exception("Tolerancia debe ser > 0");

                var resultados = puente.ResolverRKF(txtEcuacion.Text, t0, w0, h, tf, tol, fac);

                dgvTablaRKF.Rows.Clear();
                foreach (var r in resultados)
                {
                    int idx = dgvTablaRKF.Rows.Add();
                    DataGridViewRow row = dgvTablaRKF.Rows[idx];

                    row.Cells[0].Value = r.Iteracion;
                    row.Cells[1].Value = r.H.ToString("F8");
                    row.Cells[2].Value = r.T.ToString("F8");

                    // Solo mostramos K si no es la fila de inicio
                    if (r.Aceptado != "Inicio")
                    {
                        row.Cells[3].Value = r.K1.ToString("F8");
                        row.Cells[4].Value = r.K2.ToString("F8");
                        row.Cells[5].Value = r.K3.ToString("F8");
                        row.Cells[6].Value = r.K4.ToString("F8");
                        row.Cells[7].Value = r.K5.ToString("F8");
                        row.Cells[8].Value = r.K6.ToString("F8");
                        row.Cells[9].Value = r.W4.ToString("F8");
                        row.Cells[10].Value = r.W5.ToString("F8");
                        row.Cells[11].Value = r.R.ToString("F8"); // Notacion cientifica para error
                        row.Cells[12].Value = r.Aceptado;
                        row.Cells[13].Value = r.ParteFormula.ToString("F8");
                        row.Cells[14].Value = r.Q.ToString("F8");
                        row.Cells[15].Value = r.QH.ToString("F8");
                    }
                    else
                    {
                        row.Cells[9].Value = r.W4; // Valor inicial
                        row.Cells[12].Value = "INICIO";
                    }

                    // Colorear filas para que se vea aca duro (Si ya habia dedicado mucho tiempo, al menos iba a quedar bienxd)
                    if (r.Aceptado.StartsWith("No"))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                    else if (r.Aceptado == "Si")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvTablaRKF.Rows.Clear();
            txtEcuacion.Clear();
            txtFactor.Clear();
            txtH.Clear();
            txtT0.Clear();
            txtW0.Clear();
            txtTFinal.Clear();
            txtTolerancia.Clear();

        }
    }
}
