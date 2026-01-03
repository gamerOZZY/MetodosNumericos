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
    public partial class adamsBa : Form
    {
        PythonBridge puente;
        private void ConfigurarFormulario()
        {

            cboPasos.Items.Add("2 Pasos (Orden 2)");
            cboPasos.Items.Add("3 Pasos (Orden 3)");
            cboPasos.Items.Add("4 Pasos (Orden 4)");
            cboPasos.Items.Add("5 Pasos (Orden 5)");
            cboPasos.SelectedIndex = 2; 
            cboPasos.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvTablaAdams.AllowUserToAddRows = false;
            dgvTablaAdams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTablaAdams.Columns.Add("i", "Iteración");
            dgvTablaAdams.Columns.Add("t", "ti");
            dgvTablaAdams.Columns.Add("w", "wi");
            dgvTablaAdams.Columns.Add("metodo", "Metodo Usado");
        }
        public adamsBa()
        {
            InitializeComponent();
            puente = new PythonBridge();
            ConfigurarFormulario();
        }

        private void adamsBa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEcuacion.Text)) throw new Exception("Ingresa ecuacion.");

                double t0 = double.Parse(txtT0.Text);
                double w0 = double.Parse(txtW0.Text);
                double h = double.Parse(txtH.Text);
                double tf = double.Parse(txtTFinal.Text);

                // Determinar pasos (El indice 0 corresponde a 2 pasos, etc.)
                int pasos = cboPasos.SelectedIndex + 2;

                var resultados = puente.ResolverAdams(txtEcuacion.Text, t0, w0, h, tf, pasos);

                dgvTablaAdams.Rows.Clear();
                foreach (var r in resultados)
                {
                    int idx = dgvTablaAdams.Rows.Add();
                    DataGridViewRow row = dgvTablaAdams.Rows[idx];

                    row.Cells[0].Value = r.Iteracion;
                    row.Cells[1].Value = r.T.ToString("F4");
                    row.Cells[2].Value = r.W.ToString("F6");
                    row.Cells[3].Value = r.Metodo;

                    // Estilo visual: Diferenciar RK4 de Adams
                    if (r.Metodo.Contains("RK4"))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightYellow; // Color rk4
                    }
                    else if (r.Metodo.Contains("Adams"))
                    {
                        row.DefaultCellStyle.BackColor = Color.White; // Color normal
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray; // Inicio
                        row.DefaultCellStyle.Font = new Font(dgvTablaAdams.Font, FontStyle.Bold);
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
            dgvTablaAdams.Rows.Clear();
            txtEcuacion.Clear();
            txtT0.Clear();
            txtW0.Clear();
            txtH.Clear(); 
            txtTFinal.Clear();
        }
    }
}
