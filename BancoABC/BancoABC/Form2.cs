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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConsignar_Click(object sender, EventArgs e)
        {
            if (txtCuentaCon.Text == "" || txtMontoCon.Text == "")
            {
                MessageBox.Show("Por favor ingrese todos los datos");
            }
            else {
                int numCuenta = Convert.ToInt32(txtCuentaCon.Text);
                double monto = Convert.ToDouble(txtMontoCon.Text);

               // foreach (CuentaAhorros cuenta in Form1.) 
            }
        }
    }
}
