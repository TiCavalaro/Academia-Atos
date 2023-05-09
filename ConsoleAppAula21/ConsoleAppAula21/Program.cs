using Aua0905;

namespace ConsoleAppAula21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aluno aluno = new Aluno();

            //Console.WriteLine("Digite o nome do aluno:");
            //aluno.Nome = Console.ReadLine();

            //Console.WriteLine("Digite a nota 1:");
            //aluno.Nota1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a nota 2:");
            //aluno.Nota2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a nota 3:");
            //aluno.Nota3 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Média: " + aluno.Media());
            //Console.WriteLine("Situação: " + aluno.VerificarAprovacao());



            //Carro carro = new Carro();

            //Console.WriteLine("Digite o modelo do carro:");
            //carro.Modelo = Console.ReadLine();

            //Console.WriteLine("Digite o ano do carro:");
            //carro.Ano = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a velocidade inicial do carro:");
            //carro.Velocidade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite 'acelerar' para acelerar o carro ou qualquer outra coisa para não acelerar:");
            //string escolha = Console.ReadLine();

            //if (escolha == "acelerar")
            //{
            //    carro.Acelerar();
            //}

            //Console.WriteLine("Velocidade atual do carro: " + carro.Velocidade);

            Pessoa p1 = new Pessoa();
            p1.Nome = "Ricardo Frohlich";
            p1.Email = "ricardo@frohlich.br";
            /*Console.WriteLine("Nome: "+p1.Nome);
            Console.WriteLine("E-mail: "+p1.Email);*/
            p1.End = new Endereco();
            p1.End.Rua = "Rua dos Andradas";
            p1.End.Num = 1614;
            p1.End.Complemento = "Conjunto I - UFN";
            /*Console.WriteLine("Endereço:\nRua: "+p1.End.Rua);
            Console.WriteLine("Número: "+p1.End.Num);
            Console.WriteLine("Complemento: "+p1.End.Complemento);*/
            Pessoa p2 = new Pessoa();
            p2.Nome = "Fabricio";
            p2.Email = "fabricio@ufn.edu.br";
            p2.End = new Endereco();
            p2.End.Rua = "Rua dos Andradas";
            p2.End.Num = 1614;
            p2.End.Complemento = "Conjunto I - UFN";
            Pessoa p3 = new Pessoa();
            p3.Nome = "Alexandre";
            p3.Email = "alexandre@ufn.edu.br";
            p3.End = new Endereco();
            p3.End.Rua = "Rua dos Andradas";
            p3.End.Num = 1614;
            p3.End.Complemento = "Conjunto I - UFN";


            List<Pessoa> listaPessoas = new List<Pessoa>();
            listaPessoas.Add(p1);
            listaPessoas.Add(p2);
            listaPessoas.Add(p3);

            foreach (Pessoa pessoa in listaPessoas)
            {
                Console.WriteLine("Nome: " + pessoa.Nome);
                Console.WriteLine("E-mail: " + pessoa.Email);
                Console.WriteLine("Rua: " + pessoa.End.Rua);
                Console.WriteLine("Número: " + pessoa.End.Num);
                Console.WriteLine("Complemento: " + pessoa.End.Complemento);
            }

            for (int i = 0; i < listaPessoas.Count; i++)
            {
                Console.WriteLine("Elemento " + i + " Nome: " + listaPessoas[i].Nome);
            }

        }
    }
}
