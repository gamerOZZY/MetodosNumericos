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
    public partial class lol : Form
    {
        PythonBridge puente;
        TextBox[] txtEcuaciones;
        TextBox[] txtValores;
        Label[] lblTitulos;
        private void ActualizarInputs(int n)
        {
            // Muestra u Oculta filas según el número seleccionado
            for (int i = 0; i < 4; i++)
            {
                bool visible = i < n;
                txtEcuaciones[i].Visible = visible;
                txtValores[i].Visible = visible;
                lblTitulos[i].Visible = visible;
            }
        }
        private void ConfigurarForm()
        {
            dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            numEcuaciones.Value = 2; // Valor por defecto
            ActualizarInputs(2);
        }
        public lol()
        {
            InitializeComponent();
            puente = new PythonBridge();

            // Mapeamos los controles creados en el diseñador a arreglos
            txtEcuaciones = new TextBox[] { txtEc1, txtEc2, txtEc3, txtEc4 };
            txtValores = new TextBox[] { txtVal1, txtVal2, txtVal3, txtVal4 };
            lblTitulos = new Label[] { lblU1, lblU2, lblU3, lblU4 };

            ConfigurarForm();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener parámetros generales
                if (!double.TryParse(txtT0.Text, out double t0)) throw new Exception("T0 inválido");
                if (!double.TryParse(txtTf.Text, out double tf)) throw new Exception("Tf inválido");
                if (!double.TryParse(txtH.Text, out double h)) throw new Exception("h inválido");

                int n = (int)numEcuaciones.Value;
                List<string> ecuaciones = new List<string>();
                List<double> valoresIniciales = new List<double>();

                // 2. Obtener ecuaciones y valores iniciales
                for (int i = 0; i < n; i++)
                {
                    string ec = txtEcuaciones[i].Text.Trim();
                    if (string.IsNullOrEmpty(ec)) throw new Exception($"Falta ecuación u{i + 1}'");

                    if (!double.TryParse(txtValores[i].Text, out double val))
                        throw new Exception($"Valor inicial u{i + 1}(0) inválido");

                    ecuaciones.Add(ec);
                    valoresIniciales.Add(val);
                }

                // 3. Llamar al Backend
                List<List<double>> resultados = puente.ResolverSistemaRK4(ecuaciones, valoresIniciales, t0, tf, h);

                // 4. Mostrar en DataGridView
                dgvTabla.Rows.Clear();
                dgvTabla.Columns.Clear();

                // Crear columnas: t, u1, u2 ...
                dgvTabla.Columns.Add("t", "Tiempo");
                for (int i = 0; i < n; i++)
                {
                    dgvTabla.Columns.Add($"u{i + 1}", $"u{i + 1}");
                }

                // Llenar filas
                foreach (var filaDatos in resultados)
                {
                    // filaDatos es [t, u1, u2...]
                    // Convertimos a object[] para agregar al grid
                    object[] filaObj = new object[filaDatos.Count];
                    for (int j = 0; j < filaDatos.Count; j++)
                    {
                        filaObj[j] = filaDatos[j].ToString("F5"); // Formato a 5 decimales
                    }
                    dgvTabla.Rows.Add(filaObj);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvTabla.Rows.Clear();
            dgvTabla.Columns.Clear();
            txtT0.Clear(); txtTf.Clear(); txtH.Clear();
            foreach (var t in txtEcuaciones) t.Clear();
            foreach (var v in txtValores) v.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numEcuaciones_ValueChanged(object sender, EventArgs e)
        {
            ActualizarInputs((int)numEcuaciones.Value);
        }
    }
}
