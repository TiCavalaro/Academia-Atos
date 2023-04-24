namespace ConsoleAppAula03
{
    internal class Program
    {

        //and &&
        //or ||
        //not !
        static void Main(string[] args)
        {
            //int a = 4, b = 5, c = 9, d = 1;
            //Console.WriteLine("Exemplo!");//operadores logicos exemplos
            //if ((a == 0) || b == 5)
            //{
            //    Console.WriteLine("Digite");            
            //}
            //if (a > 3 || d == 1)
            //{
            //    Console.WriteLine("Entrei como verdadeiro 2");
            //}
            //if(( a>3||d <3)&&!(b<c && b > c))
            //{
            //    Console.WriteLine("Entrei como verdadeiro 3");
            //}
            //if((b != 0 || a>4) || (d<3 && c >= 8)){
            //    Console.WriteLine("Entrei como verdadeiro 4");
            //}
            //if (((a > 3 || a < d || a == 4) || (!(b == 5 && b > c))))
            //{
            //    Console.WriteLine("entrei como verdadeiro 5");
            //}

            //double sal;

            //Console.Write("Digite o salário fixo: R$ ");
            //sal = double.Parse(Console.ReadLine());
            //if (sal <= 900)
            //{
            //    Console.Write("O salario " + sal+ " mais 5%: " + sal*1.05 + " R$ ");

            //}else if (sal>900 && sal < 1400)
            //{
            //    Console.Write("O salario: " + sal + " mais 8%: " + sal * 1.08 + " R$ ");

            //}
            //else
            //{
            //    Console.Write("O salario: " + sal + " mais 10%: " +  sal * 1.10 + " R$ ");

            //}

            //Console.WriteLine("Digite o valor do primeiro lado 1:");
            //double a = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor do segundo lado 2");
            //double b = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor do terceiro lado 3:");
            //double c = double.Parse(Console.ReadLine());

            //if (a < b + c && b < a + c && c < a + b)
            //{
            //    if (a == b && b == c)
            //    {
            //        Console.WriteLine("Triangulo equilatero");
            //    }
            //    else if (a == b || a == c || b == c)
            //    {
            //        Console.WriteLine("Triangulo isosceles");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Triangulo escaleno");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Triangulo inexistente.");
            //}

            //Console.WriteLine("Digite o valor da base: ");
            //double baseTriangulo = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor da altura: ");
            //double alturaTriangulo = double.Parse(Console.ReadLine());

            //if (baseTriangulo == 0 || alturaTriangulo == 0)
            //{
            //    Console.WriteLine("A base ou a altura não podem ser iguais a zero!");
            //}
            //else
            //{
            //    double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
            //    Console.WriteLine("A área do triângulo é: " + areaTriangulo);
            //}


            //double v1, v2, v3, v4;
            //double media, soma;

            //Console.WriteLine("Digite o primeiro :");
            //v1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo :");
            //v2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o terceiro :");
            //v3 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o quarto :");
            //v4 = double.Parse(Console.ReadLine());

            //soma = v1 + v2 + v3 + v4;
            //media = soma / 4;

            //Console.WriteLine("A média dos valores é: " + media);

            //Console.WriteLine("Valores acima da média:");

            //if (v1 > media)
            //{
            //    Console.WriteLine(v1);
            //}

            //if (v2 > media)
            //{
            //    Console.WriteLine(v2);
            //}

            //if (v3 > media)
            //{
            //    Console.WriteLine(v3);
            //}

            //if (v4 > media)
            //{
            //    Console.WriteLine(v4);
            //}

            //double n1, n2;
            //double media, exam;

            //Console.Write("Digite a primeira nota: ");
            //n1 = double.Parse(Console.ReadLine());

            //Console.Write("Digite a segunda nota: ");
            //n2 = double.Parse(Console.ReadLine());

            //media = (n1 + n2) / 2;

            //if (media > 7)
            //{
            //    Console.Write("Aluno aprovado ");


            //}
            //else
            //{
            //    Console.Write("Aluno reprovado ");
            //    Console.Write("Digite a nota do exame ");
            //    exam = double.Parse(Console.ReadLine());

            //    media = (exam + (n1 + n2)/2)/2;
            //       if (exam>=5){


            //        Console.Write("Aluno aprovado ");

            //        }
            //        else
            //        {
            //            Console.Write("Aluno reprovado em definitivo ");

            //        }
            //}

            //string nome;
            //double alt, peso, imc;

            //Console.Write("Digite a altura da pessoa em metros: ");
            //alt = double.Parse(Console.ReadLine());

            //Console.Write("Digite o peso da pessoa em kg: ");
            //peso = double.Parse(Console.ReadLine());

            //imc = peso / (alt * alt);

            //Console.WriteLine(" seu IMC é" + imc);

            //if (imc < 18)
            //{
            //    Console.WriteLine("Baixo peso");
            //}
            //else if (imc < 25)
            //{
            //    Console.WriteLine("Peso normal");
            //}
            //else if (imc < 30)
            //{
            //    Console.WriteLine("Sobrepeso");
            //}
            //else if (imc < 35)
            //{
            //    Console.WriteLine("Obesidade");
            //}
            //else
            //{
            //    Console.WriteLine("Obesidade grau sério");
            //}
            //Console.Write("Digite um número inteiro: ");
            //int num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("O número é par.");
            //}
            //else
            //{
            //    Console.WriteLine("O número é ímpar.");
            //}

            //Console.ReadKey();

            //string frase, palavra;
            //bool encontrou = false;

            //Console.Write("Digite uma frase grande: ");
            //frase = Console.ReadLine();

            //Console.Write("Digite uma palavra para ver se estava na frase: ");
            //palavra = Console.ReadLine();

            //string[] palavras = frase.Split(' ');

            //// Buscando a palavra
            //foreach (string p in palavras)
            //{
            //    if (p == palavra)
            //    {
            //        encontrou = true;
            //        break;
            //    }
            //}
            //if (encontrou)
            //{
            //    Console.WriteLine("A palavra " + palavra + " se encontra na frase.");
            //}
            //else
            //{
            //    Console.WriteLine("A palavra " + palavra + " não se encontra na frase.");
            //}

            //int codigo;
            //string nome;
            //double salarioBase, totalVendas, salarioFinal;

            //Console.Write("Digite o código do funcionário: ");
            //codigo = int.Parse(Console.ReadLine());

            //Console.Write("Digite o nome do funcionário: ");
            //nome = Console.ReadLine();

            //Console.Write("Digite o salário base do funcionário: ");
            //salarioBase = double.Parse(Console.ReadLine());

            //Console.Write("Digite o total de vendas do funcionário: ");
            //totalVendas = double.Parse(Console.ReadLine());

            //salarioFinal = salarioBase;

            //if (totalVendas > 500)
            //{
            //    salarioFinal += totalVendas * 0.05;
            //}

            //if (totalVendas > 1000)
            //{
            //    salarioFinal += totalVendas * 0.07;
            //}

            //if (totalVendas > 5000)
            //{
            //    salarioFinal += totalVendas * 0.1;
            //}

            //Console.WriteLine("Código do funcionário: " + codigo);
            //Console.WriteLine("Nome do funcionário: " + nome);
            //Console.WriteLine("Salário base do funcionário: " + salarioBase.ToString("F2"));
            //Console.WriteLine("Total de vendas do funcionário: " + totalVendas.ToString("F2"));
            //Console.WriteLine("Salário final do funcionário: " + salarioFinal.ToString("F2"));

            //double g1, g2, g3;

            //Console.Write("Digite o valor da primeira medição de glicemia em jejum: ");
            //g1 = double.Parse(Console.ReadLine());

            //Console.Write("Digite o valor da segunda medição de glicemia em jejum: ");
            //g2 = double.Parse(Console.ReadLine());

            //Console.Write("Digite o valor da terceira medição de glicemia em jejum: ");
            //g3 = double.Parse(Console.ReadLine());

            //if (g1 < 65)
            //{
            //    Console.WriteLine("Atenção! Você corre risco de hipoglicemia na primeira medição.");
            //}
            //else if (g1 > 250)
            //{
            //    Console.WriteLine("Atenção! Você corre risco de hiperglicemia na primeira medição.");
            //}

            //if (g2 < 65)
            //{
            //    Console.WriteLine("Atenção! Você corre risco de hipoglicemia na segunda medição.");
            //}
            //else if (g2 > 250)
            //{
            //    Console.WriteLine("Atenção! Você corre risco de hiperglicemia na segunda medição.");
            //}

            //if (g3 < 65)
            //{
            //    Console.WriteLine("Atenção! Você corre risco de hipoglicemia na terceira medição.");
            //}
            //else if (g3 > 250)
            //{
            //    Console.WriteLine("Atenção! Você corre risco de hiperglicemia na terceira medição.");
            //}

            // Declaração das variáveis para o primeiro atleta
            //string n1;
            //int id1;
            //double altura1;

            //// Leitura dos dados do primeiro atleta
            //Console.WriteLine("Digite os dados do primeiro atleta:");
            //Console.Write("Nome: ");
            //n1 = Console.ReadLine();
            //Console.Write("Idade: ");
            //id1 = int.Parse(Console.ReadLine());
            //Console.Write("Altura: ");
            //altura1 = double.Parse(Console.ReadLine());

            //string n2;
            //int id2;
            //double altura2;

            //Console.WriteLine("Digite os dados do segundo atleta:");
            //Console.Write("Nome: ");
            //n2 = Console.ReadLine();
            //Console.Write("Idade: ");
            //id2 = int.Parse(Console.ReadLine());
            //Console.Write("Altura: ");
            //altura2 = double.Parse(Console.ReadLine());

            //string maisNovo;
            //if (id1 < id2)
            //{
            //    maisNovo = n1;
            //}
            //else
            //{
            //    maisNovo = n2;
            //}

            //// Verificação do atleta mais alto
            //string maisAlto;
            //if (altura1 > altura2)
            //{
            //    maisAlto = n1;
            //}
            //else
            //{
            //    maisAlto = n2;
            //}

            //// Impressão dos resultados
            //Console.WriteLine("O atleta mais novo é: " + maisNovo);
            //Console.WriteLine("O atleta mais alto é: " + maisAlto);
        }
    }
}