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
    public partial class Form3 : Form
    {
        static public double valorTotalRetiros = 0;
        public Form3()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtCuentaRet.Text = "";
            txtMontoRet.Text = "";
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCuentaRet.Text == "" || txtMontoRet.Text == "")
                {
                    throw new Exception("Por favor ingrese todos los datos");
                }
                else
                {
                    string numCuenta = txtCuentaRet.Text;
                    double monto = Convert.ToDouble(txtMontoRet.Text);

                    if (numCuenta.Length != 11)
                    {
                        throw new Exception("Por favor ingrese un número de cuenta válido");
                    }

                    bool encontrado = false;
                    foreach (CuentaAhorros cuenta in Form1.cuentas)
                    {
                        if (cuenta.NumCuenta == numCuenta)
                        {
                            encontrado = true;
                            cuenta.retirar(monto);
                            valorTotalRetiros += monto;
                            Form1.totalOperaciones++;
                        }
                    }

                    if (encontrado == false)
                    {
                        throw new Exception("La cuenta ingresada no existe");
                    }
                    MessageBox.Show("Se ha realizado la transacción exitosamente", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
            
        }
    }
}
