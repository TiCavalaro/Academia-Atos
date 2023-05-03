using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula16
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public DateTime DataNascimento { get; set; }
        public int AnoIngresso { get; set; }

        // Construtor que recebe nome e matrícula
        public Aluno(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
            Console.WriteLine($"Nome: {Nome} - Matrícula: {Matricula}");
        }

        // Construtor que recebe apenas a data de nascimento
        public Aluno(DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
            Console.WriteLine($"Data de Nascimento: {DataNascimento.ToShortDateString()}");
        }

        // Construtor que recebe nome, data de nascimento e ano de ingresso
        public Aluno(string nome, DateTime dataNascimento, int anoIngresso)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            AnoIngresso = anoIngresso;
            Console.WriteLine($"Nome: {Nome} - Data de Nascimento: {DataNascimento.ToShortDateString()} - Ano de Ingresso: {AnoIngresso}");
        }
    }
}
