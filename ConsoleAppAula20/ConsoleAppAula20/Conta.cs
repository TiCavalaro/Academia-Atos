using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula20
{
    internal class Conta
    {
        private readonly int numero;
        private double saldo;
        private double limite;

        public Conta(int numero)
        {
            this.numero = numero;
        }

        public int Numero
        {
            get { return numero; }
        }

        public double Saldo
        {
            get { return saldo; }
        }

        public double Limite
        {
            get { return limite; }
            set { limite = value > 0 ? value : 0; }
        }

        public void DefinirSaldoInicial(double saldoInicial)
        {
            saldo = saldoInicial >= 0 ? saldoInicial : 0;
        }

        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= (saldo + limite))
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

