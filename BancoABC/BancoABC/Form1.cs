using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoABC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void consignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void retirarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void transferirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
