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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtCuentaOrigen.Text = "";
            txtCuentaDestino.Text = "";
            txtMontoTrans.Text = "";
        }

        static public void transferir(string cuentaOrigen, string cuentaDestino, double monto) {
            CuentaAhorros origen = null;
            CuentaAhorros destino = null;
            foreach (CuentaAhorros cuenta in Form1.cuentas)
            {
                if (cuenta.NumCuenta == cuentaOrigen)
                {
                    origen = cuenta;
                }

                if (cuenta.NumCuenta == cuentaDestino)
                {
                    destino = cuenta;
                }
            }

            if (origen != null && destino != null)
            {
                origen.retirar(monto);
                destino.consignar(monto);
                Form1.totalOperaciones++;
            }
            else if (origen == null)
            {
                throw new Exception("La cuenta de origen no existe");
            }
            else
            {
                throw new Exception("La cuenta de destino no existe");
            }

        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCuentaDestino.Text == "" || txtMontoTrans.Text == "" ||
                txtCuentaOrigen.Text == "")
                {
                    throw new Exception("Por favor ingrese todos los datos");
                }
                else
                {
                    string cuentaOrigen = txtCuentaOrigen.Text;
                    string cuentaDestino = txtCuentaDestino.Text;
                    double monto = Convert.ToDouble(txtMontoTrans.Text);

                    if (cuentaDestino.Length != 11 || cuentaOrigen.Length != 11)
                    {
                        throw new Exception("Por favor ingrese un número de cuenta válido");
                    }

                    transferir(cuentaOrigen, cuentaDestino, monto);
                    /*
                    CuentaAhorros origen = null;
                    CuentaAhorros destino = null;
                    foreach (CuentaAhorros cuenta in Form1.cuentas)
                    {
                        if (cuenta.NumCuenta == cuentaOrigen)
                        {
                            origen = cuenta;
                        }

                        if (cuenta.NumCuenta == cuentaDestino)
                        {
                            destino = cuenta;
                        }
                    }

                    if (origen != null && destino != null)
                    {
                        origen.retirar(monto);
                        destino.consignar(monto);
                        Form1.totalOperaciones++;
                    }
                    else if (origen == null) {
                        throw new Exception("La cuenta de origen no existe");
                    }
                    else
                    {
                        throw new Exception("La cuenta de destino no existe");
                    }
                    */

                    limpiar();
                }

            }
            catch (ArgumentOutOfRangeException x)
            {
                MessageBox.Show(x.Message);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }
    }
}
