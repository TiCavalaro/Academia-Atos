using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula24._1
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Cidade { get; set; }
        public string RG { get; set; }
        public string CEP { get; set; }

        public Pessoa(string nome, string cpf, string cidade, string rg, string cep)
        {
            Nome = nome;
            CPF = cpf;
            Cidade = cidade;
            RG = rg;
            CEP = cep;
        }

    }
}

