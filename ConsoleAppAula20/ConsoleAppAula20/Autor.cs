using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula20
{
    internal class Autor
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Nome do autor não pode ser vazio");
                }
                nome = value;
            }
        }
    }
}
