using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula20
{
    internal class Pessoa
    {
        //private String nome;
        //private int idade;

        //public Pessoa(String nome, int idade)
        //{
        //    this.nome = nome;
        //    this.idade = idade;

        //    Console.WriteLine("Nome: "+ nome + "Idade: "+idade);

        //}
        //public Pessoa(int idade)
        //{
        //    this.idade = idade;

        //}


        //public Pessoa()
        //{
        //    //this.nome = "Ricador";
        //}

        //public string Nome
        //{
        //    get { return nome; }  
        //    set { nome = value; }
        //}

        private string nome;
        private int idade;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("A idade não pode ser menor que 0.");
                }
                idade = value;
            }
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
        }

        public Pessoa(int idade)
        {
            Idade = idade;
            Console.WriteLine("Idade: " + Idade);
        }
    }
}
