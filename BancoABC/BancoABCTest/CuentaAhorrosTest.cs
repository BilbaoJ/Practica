using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BancoABC;

namespace BancoABCTest
{
    [TestClass]
    public class CuentaAhorrosTest
    {
        [TestMethod]
        public void TestMethodConsignacion()
        {
            double saldo = 5000000;
            double valorEsperado = 9000000;
            double valorConsignar = 4000000;
            CuentaAhorros cuenta = new CuentaAhorros("12345678901", "Maria", "1234570236", saldo);

            cuenta.consignar(valorConsignar);

            double nuevoSaldo = cuenta.Saldo;
            Assert.AreEqual(valorEsperado, nuevoSaldo, "No se hizo la consignación correctamente");

        }

        [TestMethod]
        public void TestMethodRetiro()
        {
            double saldo = 5000000;
            double valorEsperado = 1000000;
            double valorRetirar = 4000000;
            CuentaAhorros cuenta = new CuentaAhorros("12345678901", "Maria", "1234570236", saldo);

            cuenta.retirar(valorRetirar);

            double nuevoSaldo = cuenta.Saldo;
            Assert.AreEqual(valorEsperado, nuevoSaldo, "No se hizo el retiro correctamente");

        }

        [TestMethod]
        public void TestMethodTransferir()
        {
            double valorEsperado = 2500000;
            double monto = 500000;
            CuentaAhorros cuentaUno = new CuentaAhorros("12345678901", "Maria", "1234570236", 4000000);
            CuentaAhorros cuentaDos = new CuentaAhorros("12345678902", "Carlos", "1234570237", 2000000);
            Form1.cuentas.Add(cuentaUno);
            Form1.cuentas.Add(cuentaDos);
            Form4.transferir("12345678901", "12345678902", monto);

            double nuevoSaldo = cuentaDos.Saldo;
            Assert.AreEqual(valorEsperado, nuevoSaldo, "No se hizo la transferencia correctamente");

        }
    }
}
