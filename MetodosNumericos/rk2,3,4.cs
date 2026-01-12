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
    public partial class rk2_3_4 : Form
    {
        PythonBridge puente;
        private void ConfigurarFormulario()
        {
    
            cboMetodoRK.Items.Add("RK2 (Orden 2)");
            cboMetodoRK.Items.Add("RK3 (Orden 3)");
            cboMetodoRK.Items.Add("RK4 (Orden 4)");
            cboMetodoRK.SelectedIndex = 2; 
            cboMetodoRK.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvTablaRK.Columns.Clear();
            dgvTablaRK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTablaRK.Columns.Add("i", "Iteracion");
            dgvTablaRK.Columns.Add("t", "ti");
            dgvTablaRK.Columns.Add("w", "wi");
            dgvTablaRK.Columns.Add("k1", "k1");
            dgvTablaRK.Columns.Add("k2", "k2");
            dgvTablaRK.Columns.Add("k3", "k3");
            dgvTablaRK.Columns.Add("k4", "k4");
        }

        public rk2_3_4()
        {
            InitializeComponent();
            puente = new PythonBridge();
            ConfigurarFormulario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener inputs
                if (string.IsNullOrWhiteSpace(txtEcuacion.Text)) throw new Exception("Falta la ecuación.");

                double t0 = double.Parse(txtT0.Text);
                double w0 = double.Parse(txtW0.Text);
                double h = double.Parse(txtH.Text);
                double tFinal = double.Parse(txtTFinal.Text);

                if (h <= 0) throw new Exception("El paso h debe ser positivo.");

                // 2. Determinar orden basado en seleccion del Combobots
                int orden = 0;
                switch (cboMetodoRK.SelectedIndex)
                {
                    case 0: orden = 2; break;
                    case 1: orden = 3; break;
                    case 2: orden = 4; break;
                }

                // 3. Llamada a Python
                var resultados = puente.ResolverRungeKutta(txtEcuacion.Text, t0, w0, h, tFinal, orden);

                // 4. Mostrar en Grid
                dgvTablaRK.Rows.Clear();

                foreach (var fila in resultados)
                {
                    // Preparamos los valores de K como strings
                    // Si el orden es 2, k3 y k4 seran "-"
                    string sK1 = fila.K1.ToString("F6");
                    string sK2 = fila.K2.ToString("F6");
                    string sK3 = (orden >= 3) ? fila.K3.ToString("F6") : "-";
                    string sK4 = (orden == 4) ? fila.K4.ToString("F8") : "-";

                    // La fila 0 no tiene Ks, ponemos guiones para que no se vea namas el espacio vacio gg
                    if (fila.Iteracion == 0)
                    {
                        sK1 = "-"; sK2 = "-"; sK3 = "-"; sK4 = "-";
                    }

                    dgvTablaRK.Rows.Add(
                        fila.Iteracion,
                        fila.T.ToString("F6"),
                        fila.W.ToString("F6"),
                        sK1, sK2, sK3, sK4
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEcuacion.Clear();
            txtT0.Clear(); txtW0.Clear();
            txtH.Clear(); txtTFinal.Clear();
            dgvTablaRK.Rows.Clear();
            txtEcuacion.Focus();

        }
    }
}
