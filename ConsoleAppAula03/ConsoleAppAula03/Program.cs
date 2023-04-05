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

            string nome;
            double alt, peso, imc;

            Console.Write("Digite a altura da pessoa em metros: ");
            alt = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso da pessoa em kg: ");
            peso = double.Parse(Console.ReadLine());

            imc = peso / (alt * alt);

            Console.WriteLine(" seu IMC é" + imc);

            if (imc < 18)
            {
                Console.WriteLine("Baixo peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc < 35)
            {
                Console.WriteLine("Obesidade");
            }
            else
            {
                Console.WriteLine("Obesidade grau sério");
            }
        }
    }
}