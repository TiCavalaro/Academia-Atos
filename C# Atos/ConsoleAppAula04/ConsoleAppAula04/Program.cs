namespace onsoleAppAula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comando de selecao multipla switch
            //Console.WriteLine("Digite um numero interi");
            //int i = int.Parse(Console.ReadLine());

            //switch (i)
            //{
            //    case 1:
            //        Console.WriteLine("Digitou 1");
            //        break;

            //    case 2:
            //        Console.WriteLine("Digitou 2");
            //        break;
            //    default://opcao default
            //        Console.WriteLine("Voce nao digitou nenhu, numero valido");
            //        break;
            //}

            //double num1, num2, result;
            //char i;

            //Console.WriteLine("Calculadora");

            //Console.Write("Escolha um numero : ");
            //num1 = double.Parse(Console.ReadLine());

            //Console.Write("Escolha uma opcao (+, -, *, /): ");
            //i = char.Parse(Console.ReadLine());

            //Console.Write("Escolha outro numero: ");
            //num2 = double.Parse(Console.ReadLine());

            //switch (i)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine($"{num1} + {num2} = {result}");
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine($"{num1} - {num2} = {result}");
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine($"{num1} * {num2} = {result}");
            //        break;
            //    case '/':
            //        if (num2 == 0)
            //        {
            //            Console.WriteLine("Nao pode ser divido por 0");
            //        }
            //        else
            //        {
            //            result = num1 / num2;
            //            Console.WriteLine($"{num1} / {num2} = {result}");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Operacao invalida");
            //        break;
            //}

            //?pode ser usado

            //int x = 0, i;
            //i = int.Parse(Console.ReadLine());
            ////x = (i % 2 == 0) ? x = 1 : x = 2;
            ////Console.WriteLine("Resultado" +x);
            //Console.WriteLine(i +  "e " + (i % 2 == 0 ? "par" : "impar"));



            //int codigo = int.Parse(Console.ReadLine());
            //int horas = int.Parse(Console.ReadLine());
            //double salario = horas * 10;
            //double extra = (horas > 50) ? (horas - 50) * 20 : 0;
            //salario += extra;
            //Console.WriteLine("Salário do operário " + codigo + ": R$ " + salario.ToString("F2"));
            //Console.WriteLine("Salário excedente do operário " + codigo + ": R$ " + extra.ToString("F2"));

            //Console.Write("Digite a altura em metros: ");
            //double altura = double.Parse(Console.ReadLine());//use virgula

            //double pesoH = (72.7 * altura) - 58;
            //double pesoM = (62.1 * altura) - 44.7;

            //Console.WriteLine($"Peso ideal para homem: {pesoH:F2} kg");
            //Console.WriteLine($"Peso ideal para mulher: {pesoM:F2} kg");

            //Console.Write("Digite o tamanho do arquivo em MB: ");
            //double tamanhoArquivo = double.Parse(Console.ReadLine());

            //Console.Write("Digite a velocidade da conexão de Internet em Mbps: ");
            //double velocidadeInternet = double.Parse(Console.ReadLine());


            //Console.WriteLine($"Tempo aproximado de download:" + (tamanhoArquivo * 8) / (velocidadeInternet * 60) + "minutos");


            //const int LITROS_POR_LATA = 18;
            //const double PRECO_POR_LATA = 80.0;

            //Console.Write("Digite o tamanho da área a ser pintada em metros quadrados: ");
            //double tamanhoArea = double.Parse(Console.ReadLine());

            //int quantidadeLatas = (int)Math.Ceiling(tamanhoArea / 3 / LITROS_POR_LATA);
            //double precoTotal = quantidadeLatas * PRECO_POR_LATA;

            //Console.WriteLine($"Quantidade de latas de tinta: " +quantidadeLatas);
            //Console.WriteLine($"Preço total: R$" + precoTotal);


            //Console.Write("Digite o lado a do triângulo: ");
            //double a = double.Parse(Console.ReadLine());

            //Console.Write("Digite o lado b do triângulo: ");
            //double b = double.Parse(Console.ReadLine());

            //Console.Write("Digite o lado c do triângulo: ");
            //double c = double.Parse(Console.ReadLine());

            //if (a + b > c && a + c > b && b + c > a)
            //{
            //    if (a == b && b == c)
            //        Console.WriteLine("O triângulo é equilátero.");
            //    else if (a == b || a == c || b == c)
            //        Console.WriteLine("O triângulo é isósceles.");
            //    else
            //        Console.WriteLine("O triângulo é escaleno.");
            //}
            //else
            //    Console.WriteLine("Os lados informados não formam um triângulo.");

            //Console.Write("Digite o primeiro valor: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Digite o segundo valor: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("Digite o terceiro valor: ");
            //int c = int.Parse(Console.ReadLine());

            //int maior = a > b ? (a > c ? a : c) : (b > c ? b : c);

            //Console.WriteLine($"O maior valor é {maior}");


            //Console.Write("Digite o primeiro valor: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Digite o segundo valor: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("Digite o terceiro valor: ");
            //int c = int.Parse(Console.ReadLine());

            //List<int> valores = new List<int> { a, b, c };
            //valores.Sort();

            //Console.WriteLine("Os valores em ordem crescente são:");
            //foreach (int valor in valores)
            //{
            //    Console.WriteLine(valor);
            //}

            //Random rand = new Random();
            //int secreto = rand.Next(1, 11); 
            //int tentativa = 3; 
            //int palpite = 0;

            //Console.WriteLine("Bem-vindo ao jogo de adivinhação do número secreto!");
            //Console.WriteLine("Você tem 3 tentativas para adivinhar o número secreto, que está entre 1 e 10.");
            //Console.WriteLine();

            //while (tentativa > 0)
            //{
            //    Console.Write("Tentativa " +tentativa + " Digite um número: ", 4 - tentativa);
            //    palpite = int.Parse(Console.ReadLine());

            //    if (palpite == secreto)
            //    {
            //        Console.WriteLine("Parabéns! Você acertou o número secreto!");
            //        return; 
            //    }
            //    else if (palpite < secreto)
            //    {
            //        Console.WriteLine("O número secreto é maior.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("O número secreto é menor.");
            //    }

            //    tentativa--;
            //}

            //Console.WriteLine("Suas tentativas acabaram. O número secreto era " + secreto);

            //Console.WriteLine("Selecione a unidade de medida de entrada:");
            //Console.WriteLine("1 - Metros");
            //Console.WriteLine("2 - Centímetros");
            //Console.WriteLine("3 - Polegadas");
            //Console.WriteLine("4 - Pés");

            //int unidadeEntrada = int.Parse(Console.ReadLine());

            //Console.WriteLine("Selecione a unidade de medida de saída:");
            //Console.WriteLine("1 - Metros");
            //Console.WriteLine("2 - Centímetros");
            //Console.WriteLine("3 - Polegadas");
            //Console.WriteLine("4 - Pés");

            //int unidadeSaida = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor a ser convertido:");
            //double valorEntrada = double.Parse(Console.ReadLine());

            //double valorSaida = valorEntrada;

            //switch (unidadeEntrada)
            //{
            //    case 1:
            //        valorSaida *= 100;
            //        break;
            //    case 2: 
            //        break;
            //    case 3:
            //        valorSaida *= 2.54;
            //        break;
            //    case 4: 
            //        valorSaida *= 30.48;
            //        break;
            //    default:
            //        Console.WriteLine("Unidade de medida de entrada inválida.");
            //        return;
            //}

            //switch (unidadeSaida)
            //{
            //    case 1: 
            //        valorSaida /= 100;
            //        break;
            //    case 2: 
            //        break;
            //    case 3: 
            //        valorSaida /= 2.54;
            //        break;
            //    case 4: 
            //        valorSaida /= 30.48;
            //        break;
            //    default:
            //        Console.WriteLine("Unidade de medida de saída inválida.");
            //        return;
            //}

            //Console.WriteLine($"Valor convertido: {valorSaida} {(unidadeSaida == 2 ? "cm" : unidadeSaida == 3 ? "pol" : unidadeSaida == 4 ? "pés" : "m")}");
        }
    }
}

