namespace ConsoleAppAula24._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string arquivo = "D:\\Downloads\\arquivo.txt";

            List<Pessoa> pessoas = new List<Pessoa>();
            List<Aluno> alunos = new List<Aluno>();

            using (StreamReader reader = new StreamReader(arquivo))
            {
                string line;
                while ((line = reader.ReadLine()) != null)//enquanto tiver linhasno arquivo
                {
                    if (line.StartsWith("Z-"))//se z entao pessoa
                    {
                        string[] pessoaData = line.Split('-');
                        string nome = pessoaData[1];//numeros indicando a posicao da informacao no vetor
                        string cpf = pessoaData[4];
                        string cidade = pessoaData[2];
                        string rg = pessoaData[3];
                        string cep = pessoaData[5];


                        pessoas.Add(new Pessoa(nome, cpf, cidade, rg, cep));
                    }
                    else if (line.StartsWith("Y-"))//se y entao aluno
                    {
                        string[] alunoData = line.Split('-');
                        string matricula = alunoData[1];// numeros indicando a posicao na informacao
                        string codigoCurso = alunoData[2];
                        string nomeCurso = alunoData[3];

                        alunos.Add(new Aluno("", "", "", "", "", matricula, codigoCurso, nomeCurso));
                    }
                }
            }

            Console.WriteLine("Quantidade de  pessoa criados: " + pessoas.Count);// contando quantidade de pessoas/listaspessoas
            Console.WriteLine("Quantidade de  aluno criados: " + alunos.Count);

            Console.WriteLine();

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Curso do Aluno:");
                Console.WriteLine("Matrícula: " + aluno.Matricula);
                Console.WriteLine("Código do Curso: " + aluno.CodigoCurso);
                Console.WriteLine("Nome do Curso: " + aluno.NomeCurso);
                Console.WriteLine();
            }
        }

    }
}