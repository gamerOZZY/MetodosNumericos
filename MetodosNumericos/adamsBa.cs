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

        private void ConfigurarInicial()
        {

            cboTipoMetodo.Items.Add("Adams-Bashforth (Explicito)");
            cboTipoMetodo.Items.Add("Adams-Moulton (Predictor-Corrector)");
            cboTipoMetodo.SelectedIndex = 0;
            cboTipoMetodo.DropDownStyle = ComboBoxStyle.DropDownList;


            cboOrden.Items.Add("Orden 2");
            cboOrden.Items.Add("Orden 3");
            cboOrden.Items.Add("Orden 4");
            cboOrden.Items.Add("Orden 5");
            cboOrden.SelectedIndex = 2; 
            cboOrden.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvTablaAdams.AllowUserToAddRows = false;
            dgvTablaAdams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public adamsBa()
        {
            InitializeComponent();
            puente = new PythonBridge();
            ConfigurarInicial();

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
                // Inputs 
                if (string.IsNullOrWhiteSpace(txtEcuacion.Text)) throw new Exception("Ingresa ecuacion.");
                double t0 = double.Parse(txtT0.Text);
                double w0 = double.Parse(txtW0.Text);
                double h = double.Parse(txtH.Text);
                double tf = double.Parse(txtTFinal.Text);
                int orden = cboOrden.SelectedIndex + 2; 

                dgvTablaAdams.Columns.Clear();

                
                if (cboTipoMetodo.SelectedIndex == 0)
                {
                    // === CASO 1: BASHFORTH ===
                    // Configurar columnas para Bashforth
                    dgvTablaAdams.Columns.Add("i", "Iteracion");
                    dgvTablaAdams.Columns.Add("t", "ti");
                    dgvTablaAdams.Columns.Add("w", "wi (Aprox)");
                    dgvTablaAdams.Columns.Add("met", "Método");

                    // Llamar Python
                    var resultados = puente.ResolverBashforth(txtEcuacion.Text, t0, w0, h, tf, orden);

                    // Llenar coso dgv
                    foreach (var r in resultados)
                    {
                        int idx = dgvTablaAdams.Rows.Add();
                        var row = dgvTablaAdams.Rows[idx];
                        row.Cells[0].Value = r.Iteracion;
                        row.Cells[1].Value = r.T.ToString("F8");
                        row.Cells[2].Value = r.W.ToString("F8");
                        row.Cells[3].Value = r.Metodo;


                        if (r.Metodo.Contains("RK4")) row.DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                }
                else
                {

                    dgvTablaAdams.Columns.Add("i", "Iteracion");
                    dgvTablaAdams.Columns.Add("t", "ti");
                    dgvTablaAdams.Columns.Add("w_pred", "Prediccion (Bash)");
                    dgvTablaAdams.Columns.Add("w_corr", "Correccion (Moul)");
                    dgvTablaAdams.Columns.Add("met", "Fase");

                    // Llamar Python
                    var resultados = puente.ResolverMoulton(txtEcuacion.Text, t0, w0, h, tf, orden);

                    // Llenar coso
                    foreach (var r in resultados) 
                    /*CREO que no lo habia mencionado pero el foreach lo saque con chat pq 
                     * nomas no me salia el ciclo (fue una tortura pq realmente ni chat  sabia lo que estaba haciendo)*/
                    {
                        int idx = dgvTablaAdams.Rows.Add();
                        var row = dgvTablaAdams.Rows[idx];
                        row.Cells[0].Value = r.Iteracion;
                        row.Cells[1].Value = r.T.ToString("F8");
                        row.Cells[2].Value = r.W_Pred.ToString("F8");
                        row.Cells[3].Value = r.W_Corr.ToString("F8");
                        row.Cells[4].Value = r.Metodo;

                        // Colorama
                        if (r.Metodo.Contains("RK4"))
                        {
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            row.Cells[2].Value = "-"; 
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                        }
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
