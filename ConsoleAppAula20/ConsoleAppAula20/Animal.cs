using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula20
{
    internal class Animal
    {
        String som;
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("O som do animal é: ");
            som = Console.ReadLine();
        }
    }
}
