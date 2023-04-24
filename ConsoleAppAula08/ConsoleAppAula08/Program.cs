using System.Diagnostics;

namespace ConsoleAppAula08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //int n;
            //do
            //{
            //    Console.Write("Digite um número inteiro menor ou igual a 50: ");
            //    n = int.Parse(Console.ReadLine());
            //} while (n > 50);

            //int produto = n;

            //while (produto < 250)
            //{
            //    Console.WriteLine(produto);
            //    produto *= 3;
            //} mudei levemente meu exercicio

            //int[] vetor = new int[3];
            ////int[] vetor2 = { 1, 2, 3 };
            ////int[] vetor3 = new int[3] { 1, 2, 3 };

            //vetor[0] = int.Parse(Console.ReadLine());
            //vetor[1] = vetor[0] * 2;
            //vetor[2] = vetor[1] * 2;

            //Console.WriteLine(vetor[1]);

            //int[] vetor = new int[3];
            //for (int i = 0; i<vetor.Length; i++)
            //{
            //    Console.WriteLine("Informe um valor para a posicao " + i + " :");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.WriteLine("O valor informado na posicao  " + i + " foi " vetor[i]);
            //}


            //int[] vetor = new int[10];
            //int Par=0, Impar=0;

            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.WriteLine("Informe um valor para a posição " + i + ":");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}


            //for (int i = 0; i < vetor.Length; i++)
            //{

            //    if (vetor[i] % 2 == 0)
            //    {
            //        Par++;
            //    }
            //    else
            //    {
            //        Impar++;
            //    }
            //}
            //Console.WriteLine("Foram digitadorr " + Par + " pares e " + Impar + " impares");

            //int[] vetor = new int[5];


            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.WriteLine("Informe um valor para a posição " + i + " do vetor ");
            //    vetor[i] = int.Parse(Console.ReadLine());

            //}
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    if (vetor[i] <= 1)
            //    {
            //        Console.WriteLine("Voce digitou um numero menor ou igual a 1 ");
            //    }
            //    for ( i = 0; i < vetor.Length; i++)
            //    {
            //        if (vetor[i] % vetor[i] == 0)
            //        {
            //            Console.WriteLine("Divisivel por um valor diferente de 1 e ele mesmo ");
            //        }
            //    }
            //    Console.WriteLine("O numero da posicao " + i + " e primo ");

            //}

            //int[] vetor = new int[5];
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.WriteLine("Informe um valor ");
            //    vetor[i] = int.Parse(Console.ReadLine());



            //}
            //Console.WriteLine("O vetor invertido fica ");

            //for (int i = vetor.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(vetor[i]);
            //}

            //int[] vetor = new int[5]; 
            //int[] pares = new int[5]; 
            //int[] impares = new int[5];
            //int[] vetor2 = new int[5];

            //// lê os números e os armazena no vetor original
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.Write(" digite o " + i + " número: ");
            //    vetor[i] = int.Parse(Console.ReadLine());//vetor[0]=2
            //}

            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    if (vetor[i] % 2 == 0)
            //    { 
            //        pares[i] = pares[i] + vetor[i];
            //    }
            //    else
            //    { 
            //        impares[i] = vetor[i]; // adiciona o número no vetor de ímpares
            //        pares[i] = 0;

            //    }
            //}
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.Write(vetor2[i]);
            //}
            //float[] vetor = new float[5];

            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.Write(" digite o " + i + " número: ");
            //    vetor[i] = float.Parse(Console.ReadLine());//


            //}
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    if (vetor[i] > 0)
            //    {
            //        Console.Write( i);

            //    }


            //}
            //float[] vetor = new float[5];

            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.Write(" digite o " + i + " número: ");
            //    vetor[i] = float.Parse(Console.ReadLine());//


            //}
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    if (vetor[i] > 0)
            //    {
            //        Console.Write(i);

            //    }


            //}

            //int[] vetor = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < vetor.Length - 1; i++)
            //{
            //    int indiceMenor = i;
            //    for (int j = i + 1; j < vetor.Length; j++)
            //    {
            //        if (vetor[j] < vetor[indiceMenor])
            //        {
            //            indiceMenor = j;
            //        }
            //    }
            //    if (indiceMenor != i)
            //    {
            //        int temp = vetor[i];
            //        vetor[i] = vetor[indiceMenor];
            //        vetor[indiceMenor] = temp;
            //    }
            //}

            //// Exibe o vetor ordenado
            //Console.WriteLine("Vetor ordenado em ordem crescente:");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(vetor[i]);
            //}
            //int[] vetor1 = new int[5];
            //int[] vetor2 = new int[5];

            //Console.WriteLine("Digite 20 valores para o vetor:");
            //for (int i = 0; i < vetor1.Length; i++)
            //{
            //    vetor1[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < vetor1.Length; i++)
            //{
            //    if (vetor1[i] == 0)
            //    {
            //        vetor2[i] = 2;
            //    }
            //    else
            //    {
            //        vetor2[i] = vetor1[i];
            //    }
            //}


            //Console.WriteLine("Vetor:");
            //for (int i = 0; i < vetor1.Length; i++)
            //{
            //    Console.WriteLine(vetor2[i]);
            //}

            //int[] vetor = new int[5];

            //Console.WriteLine("Digite 20 valores para o vetor:");
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.Write(vetor[i]);
            //}
            //    Console.WriteLine("");
            //for (int i = vetor.Length - 1; i >= 0; i--)
            //{
            //   Console.Write(vetor[i]);
            //}

            //int[] vetor = new int[5];
            //int pesquisa;
            //int con=0;
            //Console.WriteLine("Digite 5 valores para o vetor:");
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Agora digite um numero para ser pesquiasado");
            //pesquisa = int.Parse(Console.ReadLine());
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    if (vetor[i]== pesquisa)
            //    {
            //        Console.Write("Numero encontrado na posicao " + i);
            //        con = 1;
            //    }

            //}
            //if (con!=1)
            //{
            //    Console.Write("Numero nao encotnrado");

            //}

            //int[] vetor = new int[10];
            //int count2 = 0, count4 = 0, count8 = 0;
            //int i = 0;

            //// Lê os valores do vetor até que -1 seja digitado ou o vetor esteja cheio
            //while (i < vetor.Length)
            //{
            //    Console.WriteLine("Digite um número positivo (ou -1 para sair):");
            //    int num = int.Parse(Console.ReadLine());
            //    if (num == -1)
            //    {
            //        break;
            //    }
            //    else if (num <= 0)
            //    {
            //        Console.WriteLine("Número inválido. Digite um número positivo.");
            //    }
            //    else
            //    {
            //        vetor[i] = num;
            //        i++;
            //    }
            //}
            //for (int j = 0; j < i; j++)
            //{
            //    if (vetor[j] == 2)
            //    {
            //        count2++;
            //    }
            //    else if (vetor[j] == 4)
            //    {
            //        count4++;
            //    }
            //    else if (vetor[j] == 8)
            //    {
            //        count8++;
            //    }
            //}

            //Console.WriteLine("O número 2 aparece {0} vezes.", count2);
            //Console.WriteLine("O número 4 aparece {0} vezes.", count4);
            //Console.WriteLine("O número 8 aparece {0} vezes.", count8);

            //int[] vetor = new int[5];
            //int codigo;


            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}
            //do
            //{
            //    Console.WriteLine("Digite o código (0 para sair, 1 para mostrar o vetor na ordem em que foi lido, 2 para mostrar o vetor na ordem inversa):");
            //    codigo = int.Parse(Console.ReadLine());

            //    switch (codigo)
            //    {
            //        case 0:
            //            Console.WriteLine("Encerrado.");
            //            break;
            //        case 1:
            //            Console.WriteLine("Vetor na ordem em que foi lido:");
            //            for (int i = 0; i < vetor.Length; i++)
            //            {
            //                Console.Write("{0} ", vetor[i]);
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 2:
            //            Console.WriteLine("Vetor na ordem inversa:");
            //            for (int i = vetor.Length - 1; i >= 0; i--)
            //            {
            //                Console.Write("{0} ", vetor[i]);
            //            }
            //            Console.WriteLine();
            //            break;
            //        default:
            //            Console.WriteLine("Código inválido. Digite novamente.");
            //            break;
            //    }
            //} while (codigo != 0);


            //int[] vetor = new int[5];
            //int[] vetor1 = new int[5];


            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    vetor1[i] = vetor[5 - i - 1];
            //}

            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.Write(vetor1[i]);
            //}


            //int[] vetor = new int[3];
            //int[] vetor1 = new int[3];


            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.WriteLine("Digite para o vetor 1 na posicao" + i);
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.WriteLine("Digite para o vetor 2 na posicao" + i);
            //    vetor1[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.Write("A soma das posicoes dos vetores da posicao " + i + " e " + (vetor[i] + vetor1[i]));
            //    Console.WriteLine("");
            //    Console.WriteLine("");

            //}

            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.Write("A multiplicacao dasvetores da posicao " + i + " e " + (vetor[i] * vetor1[i]));
            //    Console.WriteLine("");
            //    Console.WriteLine("");

            //}

            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    if (vetor[i] == vetor1[i])
            //    {
            //        Console.WriteLine("Intersecao na posicao " + i);
            //    }
            //}


            int[] vetor = new int[3];


            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o valor do indice [{i}] do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("### Índices que possuem valores com números primos: ###");
            for (int i = 0; i < vetor.Length; i++)
            {
                bool numeroPrimo = true;
               
                for (int j = 2; j < vetor[i]; j++) 
                {
                    if (vetor[i] % j == 0)
                    {
                        numeroPrimo = false;
                        break;
                    }
                }
                if (numeroPrimo)
                {
                    Console.WriteLine($"Índice {i} contém o número primo {vetor[i]}");
                }
            }

        }
    }
}