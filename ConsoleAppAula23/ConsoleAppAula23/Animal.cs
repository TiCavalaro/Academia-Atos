using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula23
{
    internal class Animal
    {
        public string nome { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, int idade)
        {
            nome = nome;
            Idade = idade;


        }

        public abstract void emitirSom();
    }
}
