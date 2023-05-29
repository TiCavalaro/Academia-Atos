using System;

namespace WinFormsAppAprendizado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonCadastroPessoas_Click(object sender, EventArgs e)
        {

            string arquivo = "D:\\Downloads\\arquivo.txt";

            List<Pessoa> pessoas = new List<Pessoa>();

            using (StreamReader reader = new StreamReader(arquivo))
            {
                string line;
                while ((line = reader.ReadLine()) != null)//enquanto tiver linhasno arquivo
                {
                    if (line.StartsWith("Z-"))//se z entao pessoa
                    {
                        string[] pessoaData = line.Split('-');// separa pela barra
                        string nome = pessoaData[1];//numeros indicando a posicao da informacao no vetor
                        string cpf = pessoaData[5];
                        string cidade = pessoaData[3];
                        string rg = pessoaData[4];
                        string telefone = pessoaData[2];


                        pessoas.Add(new Pessoa(nome, telefone, cidade, rg, cpf));
                    }
                }
                string informacoes = "";
                foreach (Pessoa pessoa in pessoas)
                {
                    informacoes += "Nome: " + pessoa.Nome + "\n" +
                       "Telefone: " + pessoa.Telefone + "\n" +
                       "CPF: " + pessoa.CPF + "\n" +
                       "Cidade: " + pessoa.Cidade + "\n" +
                       "RG: " + pessoa.RG + "\n\n";

                }
                MessageBox.Show(informacoes);

            }
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            string arquivo = "D:\\Downloads\\arquivo.txt";
            using (StreamReader reader = new StreamReader(arquivo))
            {

                string line;
                while ((line = reader.ReadLine()) != null)//enquanto tiver linhasno arquivo
                {
                    if (line.StartsWith("Z-"))//se z entao pessoa
                    {
                        string[] pessoaData = line.Split('-');// separa pela barra
                        pessoas.Add(new Pessoa("", "", "", "", ""));
                    }

                }
            }
            MessageBox.Show("Quantidade de  pessoa criados: " + pessoas.Count);

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            string arquivo = "D:\\Downloads\\arquivo.txt";
            List<Aluno> alunos = new List<Aluno>();
            using (StreamReader reader = new StreamReader(arquivo))
            {
                string line;
                while ((line = reader.ReadLine()) != null)//enquanto tiver linhasno arquivo
                {

                    if (line.StartsWith("Y-"))//se y entao aluno
                    {
                        string[] alunoData = line.Split('-');
                        alunos.Add(new Aluno("", "", "", "", "", "", "", ""));
                    }
                }
            }
            MessageBox.Show("Quantidade de  pessoa criados: " + alunos.Count);

        }

        private void buttonCadastroAlunos_Click(object sender, EventArgs e)
        {
            string arquivo = "D:\\Downloads\\arquivo.txt";

            List<Aluno> alunos = new List<Aluno>();

            using (StreamReader reader = new StreamReader(arquivo))
            {
                string line;
                while ((line = reader.ReadLine()) != null)//enquanto tiver linhasno arquivo
                {
                    if (line.StartsWith("Y-"))//se y entao aluno
                    {
                        string[] alunoData = line.Split('-');
                        string matricula = alunoData[1];// numeros indicando a posicao na informacao
                        string codigoCurso = alunoData[2];
                        string nomeCurso = alunoData[3];

                        alunos.Add(new Aluno("", "", "", "", "", matricula, codigoCurso, nomeCurso));
                    }
                }
            }
            string informacoes = "";
            foreach (Aluno aluno in alunos)
            {
                informacoes += "Matrícula: " + aluno.Matricula + "\n" +
                     "Código do curso: " + aluno.CodigoCurso + "\n" +
                     "Nome do curso: " + aluno.NomeCurso + "\n\n";
            }
            MessageBox.Show(informacoes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string informacoes = "";
            List<PessoaAluno> pessoaAlunos = new List<PessoaAluno>();
            string arquivo = "D:\\Downloads\\arquivo.txt";

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

            foreach (PessoaAluno pessoaAluno in pessoaAlunos)
            {
                // Concatenar as informações da pessoa matriculada na variável informacoes
                informacoes +=
                               "Nome: " + pessoaAluno.Pessoa.Nome + "\n" +
                               "Telefone: " + pessoaAluno.Pessoa.Telefone + "\n" +
                               "CPF: " + pessoaAluno.Pessoa.CPF + "\n" +
                               "Cidade: " + pessoaAluno.Pessoa.Cidade + "\n" +
                               "RG: " + pessoaAluno.Pessoa.RG + "\n" +
                               "Matrícula: " + pessoaAluno.Aluno.Matricula + "\n" +
                               "Código do Curso: " + pessoaAluno.Aluno.CodigoCurso + "\n" +
                               "Nome do Curso: " + pessoaAluno.Aluno.NomeCurso + "\n\n";
            }

            // Exibir todas as informações em um único MessageBox
            MessageBox.Show(informacoes);

        }
    }
}