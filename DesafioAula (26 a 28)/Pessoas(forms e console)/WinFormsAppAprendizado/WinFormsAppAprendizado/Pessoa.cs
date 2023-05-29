using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppAprendizado
{
    internal class Pessoa//criando classe pessoa, mudar ordem depois para facilitar main.
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Cidade { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }

        public Pessoa(string nome, string cpf, string cidade, string rg, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Cidade = cidade;
            RG = rg;
            Telefone = telefone;
        }
    }
}
