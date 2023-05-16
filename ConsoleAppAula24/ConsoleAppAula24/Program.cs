namespace ConsoleAppAula24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            Persistencia.popularArquivoLista("D:\\Desktop\\Ex Atos", listaPessoas);

            //Persistencia.exibirLista(listaPessoas);


            string nome;
            string dataNascimento;
            Pessoa pessoa;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Data Nascimento: ");
                dataNascimento = Console.ReadLine();

                pessoa = new Pessoa(nome, dataNascimento);

                if (!listaPessoas.Contains(pessoa)) //????
                {
                    listaPessoas.Add(pessoa);
                    Persistencia.atualizarPessoaArquivo(pessoa, "D:\\Desktop\\Ex Atos");
                }
                else
                {
                    Console.WriteLine("Pessoa com este email já na base de dados");
                }
            }
        }
    }
}