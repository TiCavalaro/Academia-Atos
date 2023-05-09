using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula21
{
     internal class Aluno
     {
        private string _nome;
        private double _nota1;
        private double _nota2;
        private double _nota3;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double Nota1
        {
            get { return _nota1; }
            set { _nota1 = value; }
        }

        public double Nota2
        {
            get { return _nota2; }
            set { _nota2 = value; }
        }

        public double Nota3
        {
            get { return _nota3; }
            set { _nota3 = value; }
        }

        public double Media()
        {
            return (_nota1 + _nota2 + _nota3) / 3.0;
        }

        public string VerificarAprovacao()
        {
            if (Media() >= 6.0)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }

}
