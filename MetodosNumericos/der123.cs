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
    public partial class der123 : Form
    {
        PythonBridge puente;
        // listas para guardar los puntos
        List<double> listaX = new List<double>();
        List<double> listaY = new List<double>();
        double? pasoH = null;

        // Clase auxiliar para el ComboBox (para guardar nombre visible y datos internos)
        public class MetodoInfo
        {
            public string Nombre { get; set; }
            public string Clave { get; set; } // 'adelante', 'atras', etc.
            public int Puntos { get; set; }
            public override string ToString() => Nombre;
        }


        public der123()
        {
            InitializeComponent();
            try
            {
                puente = new PythonBridge(); // Inicializa python
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error iniciando Python: " + ex.Message);
            }
        }





        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                double xNuevo = double.Parse(txtX.Text);
                string func = txtFuncion.Text;

                // 1. Validar Espaciamiento (H)
                if (listaX.Count > 0)
                {
                    double xUltimo = listaX[listaX.Count - 1];
                    double hActual = Math.Round(xNuevo - xUltimo, 4); // Redondeo a 5 decimales

                    if (hActual <= 0)
                    {
                        MessageBox.Show("El valor de X debe ser mayor al anterior.");
                        return;
                    }

                    if (pasoH == null)
                    {
                        pasoH = hActual; // Definimos H con el segundo punto
                        lblPasoH.Text = "Paso h: " + pasoH.ToString();
                    }
                    else if (Math.Abs(hActual - (double)pasoH) > 0.0001)
                    {
                        MessageBox.Show($"¡Error! Debes mantener el paso constante de {pasoH}. Intentaste usar {hActual}.");
                        return;
                    }
                }

                // 2. Calcular Y usando el Puente
                double yNuevo = puente.ObtenerY(func, xNuevo);

                // 3. Guardar y Actualizar la cajita de os puntos
                listaX.Add(xNuevo);
                listaY.Add(yNuevo);

                lstTabla.Items.Add($"[{listaX.Count - 1}] X: {xNuevo} | Y: {yNuevo:F4}");
                cboPuntos.Items.Add(xNuevo); // Agregamos al combo de seleccion

                txtX.Text = "";
                txtX.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listaX.Clear();
            listaY.Clear();
            pasoH = null;
            lstTabla.Items.Clear();
            cboPuntos.Items.Clear();
            cboMetodos.Items.Clear();
            lblPasoH.Text = "Paso h: --";
            txtFuncion.Clear();
        }



        private void cboPuntos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMetodos.Items.Clear();
            int i = cboPuntos.SelectedIndex; // El índice (0, 1, 2...)
            int n = listaX.Count; // Total de puntos

            if (i == -1) return;

            // -- Verificamos disponibilidad de vecinos --
            bool hayAdelante1 = (i + 1 < n);
            bool hayAdelante2 = (i + 2 < n);
            bool hayAdelante4 = (i + 4 < n);

            bool hayAtras1 = (i - 1 >= 0);
            bool hayAtras2 = (i - 2 >= 0);
            bool hayAtras4 = (i - 4 >= 0);

            // -- Agregamos SOLO lo que es posible -- HONESTAMENTE el codigo de esta seccion es PURA BASURA PERO FUNCIONA, no supe que hacer para que quedara mas bonito xd

            // 5 PUNTOS
            if (hayAdelante4) cboMetodos.Items.Add(new MetodoInfo { Nombre = "Adelante (5 ptos)", Clave = "adelante", Puntos = 5 });
            if (hayAtras4) cboMetodos.Items.Add(new MetodoInfo { Nombre = "Atrás (5 ptos)", Clave = "atras", Puntos = 5 });
            if (hayAdelante2 && hayAtras2) cboMetodos.Items.Add(new MetodoInfo { Nombre = "Centrada (5 ptos)", Clave = "centrada", Puntos = 5 });

            // 3 PUNTOS
            if (hayAdelante2) cboMetodos.Items.Add(new MetodoInfo { Nombre = "Adelante (3 ptos)", Clave = "adelante", Puntos = 3 });
            if (hayAtras2) cboMetodos.Items.Add(new MetodoInfo { Nombre = "Atrás (3 ptos)", Clave = "atras", Puntos = 3 });
            if (hayAdelante1 && hayAtras1) cboMetodos.Items.Add(new MetodoInfo { Nombre = "Centrada (3 ptos)", Clave = "centrada", Puntos = 3 });

            // 2 PUNTOS
            if (hayAdelante1) cboMetodos.Items.Add(new MetodoInfo { Nombre = "Adelante (2 ptos)", Clave = "adelante", Puntos = 2 });
            if (hayAtras1) cboMetodos.Items.Add(new MetodoInfo { Nombre = "Atrás (2 ptos)", Clave = "atras", Puntos = 2 });
            if (hayAdelante1 && hayAtras1) cboMetodos.Items.Add(new MetodoInfo { Nombre = "Centrada (2 ptos)", Clave = "centrada", Puntos = 2 });

            if (cboMetodos.Items.Count > 0) cboMetodos.SelectedIndex = 0;
            else lblResultado.Text = "Sin métodos disponibles (faltan puntos).";
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cboMetodos.SelectedItem == null) return;

            var metodo = (MetodoInfo)cboMetodos.SelectedItem;
            int indice = cboPuntos.SelectedIndex;

            try
            {
                // Llamamos al puente para hacer el calculo final
                double res = puente.CalcularDerivada(listaX, listaY, indice, metodo.Clave, metodo.Puntos);
                lblResultado.Text = $"Resultado: {res}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al derivar: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
