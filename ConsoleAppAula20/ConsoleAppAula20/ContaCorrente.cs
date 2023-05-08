using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula20
{
    internal class ContaCorrente
    {
        private double saldo;
        public void DefinirSaldoInicial(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
    }
}

