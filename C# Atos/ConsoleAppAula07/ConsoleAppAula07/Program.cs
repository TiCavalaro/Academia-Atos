using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppAula07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int opcao = 1;
            //while (opcao != 0)
            //{

            //int valor;
            //for (; ; )
            //{
            //    Console.WriteLine("Digite um numero inteiro e positivo");
            //    valor = int.Parse(Console.ReadLine());

            //    if (valor >= 0)
            //    {
            //        break;
            //    }
            //}
            //for (int i = 1; i < valor; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i + " , ");
            //    }
            //}

            //Console.WriteLine("Digite nao zero para continuar");
            //opcao = int.Parse(Console.ReadLine());
            //}

            //explicacao While
            //tem o do while tambem faz uma antes de verificiar
            //int x = 0;
            //while(x <= 0)

            //{
            //    Console.WriteLine("Informe um numero");
            //    x = int.Parse(Console.ReadLine());
            //}


            //int maiorIdade = 0;
            //int qtdMulheres = 0;

            //while (true)
            //{
            //    Console.Write("Digite o sexo (M/F): ");
            //    char sexo = Console.ReadKey().KeyChar;
            //    Console.WriteLine();

            //    Console.Write("Digite a cor dos olhos (A/V/C): ");
            //    char olhos = Console.ReadKey().KeyChar;
            //    Console.WriteLine();

            //    Console.Write("Digite a cor dos cabelos (L/C/P): ");
            //    char cabelos = Console.ReadKey().KeyChar;
            //    Console.WriteLine();

            //    Console.Write("Digite a idade: ");
            //    int idade = int.Parse(Console.ReadLine());

            //    if (idade == -1)
            //    {
            //        break;
            //    }

            //    if (idade > maiorIdade)
            //    {
            //        maiorIdade = idade;
            //    }

            //    if (sexo == 'F' && idade >= 18 && idade <= 35 && olhos == 'V' && cabelos == 'L')
            //    {
            //        qtdMulheres++;
            //    }
            //}

            //Console.WriteLine($"Maior idade: {maiorIdade}");
            //Console.WriteLine($"Qtd mulheres: {qtdMulheres}");

            //int opcao = 1;
            //while (opcao != 0)
            //{

            //    int valor;
            //    for (; ; )
            //    {
            //        Console.WriteLine("Digite um numero inteiro e positivo");
            //        valor = int.Parse(Console.ReadLine());

            //        if (valor >= 0)
            //        {
            //            break;
            //        }
            //    }
            //    for (int i = 1; i < valor; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i + " , ");
            //        }
            //    }

            //    Console.WriteLine("Digite nao zero para continuar");
            //    opcao = int.Parse(Console.ReadLine());
            //}

            //int votosJoao = 0, votosZeca = 0, votosBranco = 0, votosNulos = 0, totalVotos = 0;
            //string voto;

            //Console.WriteLine("Digite JOAO, ZECA, BRANCO ou NULO para votar. Digite FIM para encerrar a votação.");

            //while (true)
            //{
            //    voto = Console.ReadLine().ToUpper();

            //    if (voto == "FIM")
            //    {
            //        break;
            //    }
            //    else if (voto == "JOAO")
            //    {
            //        votosJoao++;
            //        totalVotos++;
            //    }
            //    else if (voto == "ZECA")
            //    {
            //        votosZeca++;
            //        totalVotos++;
            //    }
            //    else if (voto == "BRANCO")
            //    {
            //        votosBranco++;
            //        totalVotos++;
            //    }
            //    else
            //    {
            //        votosNulos++;
            //        totalVotos++;
            //    }
            //}

            //Console.WriteLine("Resultado da votação:");
            //Console.WriteLine($"João: {votosJoao} votos");
            //Console.WriteLine($"Zeca: {votosZeca} votos");
            //Console.WriteLine($"Branco: {votosBranco} votos");
            //Console.WriteLine($"Nulo: {votosNulos} votos");
            //Console.WriteLine($"Total de votos: {totalVotos}");

            //if (votosJoao > votosZeca)
            //{
            //    Console.WriteLine("João venceu a eleição.");
            //}
            //else if (votosZeca > votosJoao)
            //{
            //    Console.WriteLine("Zeca venceu a eleição.");
            //}
            //else
            //{
            //    Console.WriteLine("A eleição terminou em empate.");
            //}

            //int count = 0;
            //double totalSalary = 0.0, averageSalary = 0.0, maxSalary = double.MinValue;
            //int totalChildren = 0, averageChildren = 0, countSalaryUpTo100 = 0;

            //while (true)
            //{
            //    Console.Write("Digite o salário (ou um valor negativo para sair): ");
            //    double salary = double.Parse(Console.ReadLine());

            //    if (salary < 0)
            //    {
            //        break;
            //    }

            //    Console.Write("Digite o número de filhos: ");
            //    int children = int.Parse(Console.ReadLine());

            //    count++;
            //    totalSalary += salary;
            //    totalChildren += children;

            //    if (salary > maxSalary)
            //    {
            //        maxSalary = salary;
            //    }

            //    if (salary <= 100)
            //    {
            //        countSalaryUpTo100++;
            //    }
            //}

            //if (count > 0)
            //{
            //    averageSalary = totalSalary / count;
            //    averageChildren = totalChildren / count;

            //    Console.WriteLine("Média do salário: " + averageSalary.ToString("F2"));
            //    Console.WriteLine("Média do número de filhos: " + averageChildren.ToString("F2"));
            //    Console.WriteLine("Maior salário: " + maxSalary.ToString("F2"));
            //    Console.WriteLine("Percentual de pessoas com salário até R$ 100,00: "
            //                      + (100.0 * countSalaryUpTo100 / count).ToString("F2") + "%");
            //}
            //else
            //{
            //    Console.WriteLine("Nenhum dado foi informado.");
            //}

            //int contador = 0;
            //float nota, soma = 0, media;
            //float notaMinima = float.MaxValue;
            //float notaMaxima = float.MinValue;

            //Console.WriteLine("Digite as notas (digite -1 para encerrar):");

            //do
            //{
            //    Console.Write("Nota: ");
            //    if (!float.TryParse(Console.ReadLine(), out nota))
            //    {
            //        Console.WriteLine("Nota inválida, digite novamente.");
            //        continue;
            //    }

            //    if (nota == -1)
            //    {
            //        break;
            //    }

            //    soma += nota;
            //    contador++;

            //    if (nota < notaMinima)
            //    {
            //        notaMinima = nota;
            //    }

            //    if (nota > notaMaxima)
            //    {
            //        notaMaxima = nota;
            //    }

            //} while (true);

            //if (contador > 0)
            //{
            //    media = soma / contador;
            //    Console.WriteLine("Média: " + media.ToString("F2"));
            //    Console.WriteLine("Nota mínima: " + notaMinima);
            //    Console.WriteLine("Nota máxima: " + notaMaxima);
            //    Console.WriteLine("Quantidade de alunos: " + contador);
            //}
            //else
            //{
            //    Console.WriteLine("Nenhum aluno foi inserido.");
            //}
        }
    }  
}
    
