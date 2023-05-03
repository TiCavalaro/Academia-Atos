using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula16
{
    internal class Pessoa2
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Construtor que recebe nome e idade
        public Pessoa2(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Console.WriteLine($"Nome: {Nome} - Idade: {Idade}");
        }

        // Construtor que recebe apenas a idade
        public Pessoa2(int idade)
        {
            Idade = idade;
            Console.WriteLine($"Idade: {Idade}");
        }
    }
}
