using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula20
{
    internal class Fabricante
    {
        private string nome;
        private string endereco;
        private string cidade;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (nome == null)
                {
                    Console.WriteLine("O nome nao pode ser vazio");
                }

            }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
    }
}
