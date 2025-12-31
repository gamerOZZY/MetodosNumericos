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
    public partial class menuInterpolacion : Form
    {
        public menuInterpolacion()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diferenciasDivididas f = new diferenciasDivididas();
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            neville neville = new neville();
            neville.Show();
            neville.WindowState = FormWindowState.Maximized;
        }
    }
}
