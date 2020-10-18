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

                    if (monto < 0)
                    {
                        throw new Exception("Por favor ingrese un monto mayor a 0");
                    }

                    if (cuentaDestino.Length != 11 || cuentaOrigen.Length != 11)
                    {
                        throw new Exception("Por favor ingrese un número de cuenta válido");
                    }

                    bool origenEncontrado = false;
                    bool destinoEncontrado = false;
                    foreach (CuentaAhorros cuenta in Form1.cuentas)
                    {
                        if (cuenta.NumCuenta == cuentaOrigen)
                        {
                            origenEncontrado = true;
                            if (monto > cuenta.Saldo)
                            {
                                throw new Exception("Saldo insuficiente");
                            }
                            else
                            {
                                cuenta.retirar(monto);
                            }
                            
                        }

                        if (cuenta.NumCuenta == cuentaDestino)
                        {
                            destinoEncontrado = true;
                            cuenta.consignar(monto);
                        }
                    }

                    if (origenEncontrado == false)
                    {
                        throw new Exception("La cuenta de origen no existe");
                    }

                    if (destinoEncontrado == false)
                    {
                        throw new Exception("La cuenta de destino no existe");
                    }
                }

            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }
    }
}
