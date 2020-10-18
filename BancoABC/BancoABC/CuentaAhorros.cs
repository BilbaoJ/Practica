﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoABC
{
    public class CuentaAhorros
    {
        private string numCuenta;
        private string nomTitular;
        private string identificacion;
        private double saldo;

        public CuentaAhorros(string numCuenta, string nomTitular, string identificacion, double saldo)
        {
            this.numCuenta = numCuenta;
            this.nomTitular = nomTitular;
            this.identificacion = identificacion;
            this.saldo = saldo;
        }

        public string NumCuenta { get => numCuenta; set => numCuenta = value; }
        public string NomTitular { get => nomTitular; set => nomTitular = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public void consignar(double monto) {
            saldo += monto;
        }

        public void retirar(double monto) {
            saldo -= monto;
        }
    }
}
