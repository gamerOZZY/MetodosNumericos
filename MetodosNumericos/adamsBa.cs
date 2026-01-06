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
    
            cboOrden.Items.Clear();
            cboOrden.Items.Add("4 Pasos (Orden 4)"); 
            cboOrden.Items.Add("5 Pasos (Orden 5)"); 
            cboOrden.SelectedIndex = 0; 
            cboOrden.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvTablaAdams.AllowUserToAddRows = false;
            dgvTablaAdams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTablaAdams.Columns.Clear();


            dgvTablaAdams.Columns.Add("i", "Iteracion");
            dgvTablaAdams.Columns.Add("t", "ti");
            dgvTablaAdams.Columns.Add("w", "wi");
            dgvTablaAdams.Columns.Add("metodo", "Metodo");
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

                int pasos = cboOrden.SelectedIndex + 4;


                var resultados = puente.ResolverBashforth(txtEcuacion.Text, t0, w0, h, tf, pasos);


                dgvTablaAdams.Rows.Clear();
                foreach (var r in resultados)
                {
                    int idx = dgvTablaAdams.Rows.Add();
                    DataGridViewRow row = dgvTablaAdams.Rows[idx];

                    row.Cells[0].Value = r.Iteracion;
                    row.Cells[1].Value = r.T.ToString("F8");
                    row.Cells[2].Value = r.W.ToString("F8");
                    row.Cells[3].Value = r.Metodo;

                    if (r.Metodo.Contains("RK4")) /*puse la inicializacion de otro color gg*/
                    {
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
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
