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
    public partial class menu_Integracion : Form
    {
        public menu_Integracion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            integracion_Compuesta coso = new integracion_Compuesta();
            coso.Show();
            coso.WindowState = FormWindowState.Maximized;
        }
    }
}
