﻿using System;
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
        static public int totalOperaciones = 0;
        static public List<CuentaAhorros> cuentas = new List<CuentaAhorros>();

        public Form1()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtNumCuenta.Text = "";
            txtNomTitular.Text = "";
            txtIdTitular.Text = "";
            txtSaldo.Text = "";
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

        private void consultarEstadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumCuenta.Text == "" || txtNomTitular.Text == "" || txtIdTitular.Text == ""
                || txtSaldo.Text == "")
                {
                    throw new Exception("Por favor ingrese todos los datos");
                }
                else
                {
                    string numCuenta = txtNumCuenta.Text;
                    string nomTitular = txtNomTitular.Text;
                    string idTitular = txtIdTitular.Text;
                    double saldo = Convert.ToDouble(txtSaldo.Text);

                    if (saldo < 0) {
                        throw new Exception("Por favor ingrese un saldo mayor a 0");
                    }

                    if (numCuenta.Length != 11) 
                    {
                        throw new Exception("Por favor ingrese un número de cuenta válido");
                    }

                    if (idTitular.Length != 10)
                    {
                        throw new Exception("Por favor ingrese un número de identificación " +
                            "válido");
                    }

                    if (saldo >= 2000000)
                    {
                        saldo += (saldo * 0.05);
                    }

                    CuentaAhorros nuevaCuenta = new CuentaAhorros(numCuenta, nomTitular, idTitular, saldo);
                    cuentas.Add(nuevaCuenta);
                    MessageBox.Show("La información ha sido guardada exitosamente", "" ,
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
