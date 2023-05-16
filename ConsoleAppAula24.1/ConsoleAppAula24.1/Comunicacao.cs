using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula24._1
{
    internal class Comunicacao
    {
        public static bool validaNome(string nome)
        {
            string[] vetor = nome.Split();
            if (vetor.Length < 2)
            {
                return false;
            }
            return true;
        }

        public static void listar(List<Pessoa> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public static void excluir(List<Pessoa> lista, string NomeArquivo)
        {
            string nome;
            Console.Write("Digite nome a ser excluido: ");
            nome = Console.ReadLine();

            bool removeu = false;
            foreach (var item in lista)
            {
                if (nome == item.Nome)
                {
                    lista.Remove(item);
                    removeu = true;
                    break;
                }
            }
            if (removeu)
            {
                Persistencia.gravarListaArquivo(lista, "dados.dat");
            }
        }
        public static void cadastrar(List<Pessoa> lista, string nomeArquivo)
        {
            string nome;
            string dataNascimento;
            Pessoa pessoa;

            do
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine().ToUpper();
            } while (!validaNome(nome));

            Console.Write("Data Nascimento: ");
            dataNascimento = Console.ReadLine();

            pessoa = new Pessoa(nome, dataNascimento);

            if (!lista.Contains(pessoa))
            {
                lista.Add(pessoa);
                Persistencia.atualizarPessoaArquivo(pessoa, "dados.dat");
            }
            else
            {
                Console.WriteLine("Pessoa com este email já na base de dados");
            }
        }
    }
}