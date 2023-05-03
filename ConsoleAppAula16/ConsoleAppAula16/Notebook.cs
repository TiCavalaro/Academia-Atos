using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula16
{
    internal class Notebook
    {

        public string marca,modelo,tipo;
        public int preco;


        public Notebook()
        {

        }


        public Notebook(String marca, String modelo, String tipo, int preco)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.tipo = tipo;
            this.preco = preco;

        }


        public void exibeDados()
        {
            Console.WriteLine("Marca " + this.marca);
            Console.WriteLine("Modelo " + this.modelo);
            Console.WriteLine("tipo " + this.tipo);
            Console.WriteLine("Preco " + this.preco);
        }
    }
}
