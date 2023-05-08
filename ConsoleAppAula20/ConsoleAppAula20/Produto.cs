using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula20
{
    internal class Produto
    {
        private string nome;
        private Fabricante fabricante;
        private decimal preco;

        public string Nome
        {
            get { return nome; }
            set { nome = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Nome não pode ser vazio"); }
        }

        public Fabricante Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public decimal Preco
        {
            get { return preco; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("Preço deve ser positivo");
                }
                preco = value;
            }
        }
    }
}
