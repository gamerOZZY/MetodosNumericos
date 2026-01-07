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
    public partial class minimosCuadrados : Form
    {
        PythonBridge puente;
        List<double> listaX;
        List<double> listaY;
        private void ConfigurarCosoEste()
        {

            cboTipo.Items.AddRange(new string[] { "Polinomial", " y = ae^bx", "y = ax^b" });
            cboTipo.SelectedIndex = 0;
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;


            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.Columns.Add("X", "X");
            dgvDatos.Columns.Add("Y", "Y Observada");
            dgvDatos.Columns.Add("YCalc", "Y Modelo");
            dgvDatos.Columns.Add("Err", "Error Abs");

            pbGrafica.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public minimosCuadrados()
        {
            InitializeComponent();
            puente = new PythonBridge();
            listaX = new List<double>();
            listaY = new List<double>();

            ConfigurarCosoEste();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                double valX = double.Parse(txtX.Text);
                double valY = double.Parse(txtY.Text);

                listaX.Add(valX);
                listaY.Add(valY);

                dgvDatos.Rows.Add(valX, valY, "", "");

                txtX.Clear();
                txtY.Clear(); 
            }
            catch { MessageBox.Show("Numeros invalidos."); }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaX.Count < 2) throw new Exception("Ingresa al menos 2 puntos.");

                string tipo = cboTipo.SelectedItem.ToString();
                int grado = (int)numGrado.Value;


                var resultado = puente.ResolverMinimosCuadrados(listaX, listaY, tipo, grado);

                //  Mostrar Ecuacion
                lblEcuacion.Text = $"f(x) = {resultado.Ecuacion}";

                //  Mostrar Grafica (por alguna razon esta linea me dio muchos errores y eso que casi que
                // hice copy-paste de las lineas de graficas de otros metodos pero ok, nunca supe cual era el
                // error pero solo con modificar el nombre de las variables, se solucionoxd. Es casi que ironico
                // que no haya entendido el error tomando en cuenta que puse ThrowExceptions cada que podia
                // para, segun yo, siempre saber donde estaba y cual era el errorxd)
                if (pbGrafica.Image != null) pbGrafica.Image.Dispose(); 
                pbGrafica.Image = resultado.Grafica;

                //  Llenar tabla con evaluaciones
                dgvDatos.Rows.Clear();
                for (int i = 0; i < listaX.Count; i++)
                {
                    double yObs = listaY[i];
                    double yCalc = resultado.Y_Evaluadas[i];
                    double error = Math.Abs(yObs - yCalc);

                    dgvDatos.Rows.Add(
                        listaX[i],
                        yObs,
                        yCalc.ToString("F8"),
                        error.ToString("F8")
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
            listaX.Clear();
            listaY.Clear();
            dgvDatos.Rows.Clear();
            pbGrafica.Image = null;
            lblEcuacion.Text = "_________";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            numGrado.Enabled = cboTipo.SelectedItem.ToString() == "Polinomial";
        }
    }
}
