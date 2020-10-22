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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnTotalConsig_Click(object sender, EventArgs e)
        {
            txtTotalConsig.Text = Form2.valorTotalConsignaciones.ToString();
        }

        private void btnTotalRetiros_Click(object sender, EventArgs e)
        {
            txtTotalRetiros.Text = Form3.valorTotalRetiros.ToString();
        }

        private void btnTotalOperaciones_Click(object sender, EventArgs e)
        {
            txtTotalOperaciones.Text = Form1.totalOperaciones.ToString();
        }

        private void btnMayorConsig_Click(object sender, EventArgs e)
        {
            txtMayorConsig.Text = Form2.nomClienteMayorConsignacion;
        }
    }
}
