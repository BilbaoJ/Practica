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
        static public double valorTotalConsignaciones = 0;
        static public string nomClienteMayorConsignacion = "";
        static public double mayorConsignacion = 0;
        public Form2()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtCuentaCon.Text = "";
            txtMontoCon.Text = "";
        }

        private void btnConsignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCuentaCon.Text == "" || txtMontoCon.Text == "")
                {
                    throw new Exception("Por favor ingrese todos los datos");
                }
                else
                {
                    string numCuenta = txtCuentaCon.Text;
                    double monto = Convert.ToDouble(txtMontoCon.Text);

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
                            cuenta.consignar(monto);
                            valorTotalConsignaciones += monto;
                            Form1.totalOperaciones++;
                            if (monto > mayorConsignacion)
                            {
                                nomClienteMayorConsignacion = cuenta.NomTitular;
                            }
                        }
                    }

                    if (encontrado == false) 
                    {
                        throw new Exception("La cuenta ingresada no existe");
                    }

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
