namespace ConsoleAppAula24._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string arquivo = "D:\\Downloads\\arquivo.txt";

            List<Pessoa> pessoas = new List<Pessoa>();
            List<Aluno> alunos = new List<Aluno>();
            List<PessoaAluno> pessoaAlunos = new List<PessoaAluno>();

            using (StreamReader reader = new StreamReader(arquivo))
            {
                string line;
                while ((line = reader.ReadLine()) != null)//enquanto tiver linhasno arquivo
                {
                    if (line.StartsWith("Z-"))//se z entao pessoa
                    {
                        string[] pessoaData = line.Split('-');// separa pela barra
                        string nome = pessoaData[1];//numeros indicando a posicao da informacao no vetor
                        string cpf = pessoaData[4];
                        string cidade = pessoaData[3];
                        string rg = pessoaData[2];
                        string telefone = pessoaData[5]; 


                        pessoas.Add(new Pessoa(nome, cpf, cidade, rg, telefone));
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
            //caso seguido ou pessoaaluno
            using (StreamReader reader = new StreamReader(arquivo))
            {
                string line;
                PessoaAluno pessoaAlunoTemp = null;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Z-"))
                    {
                        string[] pessoaData = line.Split('-');
                        string nome = pessoaData[1];
                        string cpf = pessoaData[4];
                        string cidade = pessoaData[2];
                        string rg = pessoaData[3];
                        string telefone = pessoaData[5];

                        pessoaAlunoTemp = new PessoaAluno(new Pessoa(nome, cpf, cidade, rg, telefone));
                    }
                    else if (line.StartsWith("Y-"))
                    {
                        if (pessoaAlunoTemp != null)
                        {
                            string[] alunoData = line.Split('-');
                            string matricula = alunoData[1];
                            string codigoCurso = alunoData[2];
                            string nomeCurso = alunoData[3];

                            pessoaAlunoTemp.Aluno = new Aluno("", "", "", "", "", matricula, codigoCurso, nomeCurso);

                            pessoaAlunos.Add(pessoaAlunoTemp);
                            pessoaAlunoTemp = null;
                        }

                    }
                }
            }



            bool continuar = true;
            int opcao;
            while (continuar)
            {
                Console.WriteLine("Digite 1 para saber as pessoas que estão no sistema");
                Console.WriteLine("Insira 2 para saber as matrículas que etão no sistema");
                Console.WriteLine("Insira 3 mostrar os alunos (pessoas matriculadas)");
                Console.WriteLine("Insira 4 para finalizar o programa:");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            foreach (Pessoa pessoa in pessoas)
                            {
                                Console.WriteLine("Nome: " + pessoa.Nome);
                                Console.WriteLine("Telefone: " + pessoa.Telefone);
                                Console.WriteLine("CPF: " + pessoa.CPF);
                                Console.WriteLine("Cidade: " + pessoa.Cidade);
                                Console.WriteLine("RG: " + pessoa.RG);
                                Console.WriteLine("....................................................");
                            }
                            Console.ReadLine();
                            Console.Clear();// clear
                            break;
                        case 2:
                            foreach (Aluno aluno in alunos)
                            {
                                Console.WriteLine("Matrícula: " + aluno.Matricula);
                                Console.WriteLine("Código do Curso: " + aluno.CodigoCurso);
                                Console.WriteLine("Nome do Curso: " + aluno.NomeCurso);
                                Console.WriteLine("-----------------------------------------------");
                            }
                            Console.ReadLine();
                            Console.Clear();// clear
                            break;
                        case 3:
                            foreach (PessoaAluno pessoaAluno in pessoaAlunos)
                            {
                                Console.WriteLine("Dados da pessoa matriculada:");
                                Console.WriteLine("Nome: " + pessoaAluno.Pessoa.Nome);
                                Console.WriteLine("Telefone: " + pessoaAluno.Pessoa.Telefone);
                                Console.WriteLine("CPF: " + pessoaAluno.Pessoa.CPF);
                                Console.WriteLine("Cidade: " + pessoaAluno.Pessoa.Cidade);
                                Console.WriteLine("RG: " + pessoaAluno.Pessoa.RG);
                                Console.WriteLine("Matrícula: " + pessoaAluno.Aluno.Matricula);
                                Console.WriteLine("Código do Curso: " + pessoaAluno.Aluno.CodigoCurso);
                                Console.WriteLine("Nome do Curso: " + pessoaAluno.Aluno.NomeCurso);
                                Console.WriteLine();
                                Console.WriteLine("--------------------------------------------------------");
                            }
                            Console.ReadLine();
                            Console.Clear();// clear
                            break;
                        case 4:
                            continuar = false; // finaliza
                            break;
                        default:
                            Console.WriteLine("Opção invalida");// casi numero errado
                            Console.WriteLine("Clique ENTER para sair");
                            Console.ReadLine();
                            break;
                    }
                }
            }

        }
    }
 }


