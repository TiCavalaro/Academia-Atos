using System.Runtime.Serialization;

namespace ConsoleAppAula10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] matriz = new int[3, 3];

            //    for (int i = 0; i < 3; i++)
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            Console.Write($"Digite um número para a posição" + i + " " +  j + " : ");
            //            int num = int.Parse(Console.ReadLine());
            //            matriz[i, j] = num;
            //        }
            //    }

            //    int[] somaLinha = new int[3];
            //    for (int i = 0; i < 3; i++)
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            somaLinha[i] += matriz[i, j];
            //        }
            //    }

            //    int[] somaColuna = new int[3];
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int i = 0; i < 3; i++)
            //        {
            //            somaColuna[j] += matriz[i, j];
            //        }
            //    }

            //    Console.WriteLine("Matriz:");
            //    for (int i = 0; i < 3; i++)
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            Console.Write(matriz[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }

            //    Console.WriteLine("Soma dos elementos de cada linha:");
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.WriteLine($"Linha {i + 1}: {somaLinha[i]}");
            //    }

            //    Console.WriteLine("Soma dos elementos de cada coluna:");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("Coluna " + somaColuna[j]);
            //    }
            //}





            //int[,] matriz = new int[4, 4];

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Digite um número para a posição" + i + " " + j + " : ");
            //        int num = int.Parse(Console.ReadLine());
            //        matriz[i, j] = num;
            //    }
            //}
            //Console.WriteLine("Matriz:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Diagonal:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.WriteLine(matriz[i, j]);
            //        }
            //    }

            //}




            //int[,] matriz = new int[5, 5];

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write($"Digite um número para a posição" + i + " " + j + " : ");
            //        int num = int.Parse(Console.ReadLine());
            //        matriz[i, j] = num;
            //    }
            //}
            //Console.WriteLine("Matriz:");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int pares = 0, impares = 0, positivos = 0, negativos = 0, zeros = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (matriz[i, j] % 2 == 0)
            //        {
            //            pares++;
            //        }
            //        else
            //        {
            //            impares++;
            //        }

            //        if (matriz[i, j] > 0)
            //        {
            //            positivos++;
            //        }
            //        else if (matriz[i, j] < 0)
            //        {
            //            negativos++;
            //        }
            //        else
            //        {
            //            zeros++;
            //        }
            //    }
            //}

            //Console.WriteLine("Quantidade de números pares: " + pares);
            //Console.WriteLine("Quantidade de números ímpares: " + impares);
            //Console.WriteLine("Quantidade de números positivos: " +positivos);
            //Console.WriteLine("Quantidade de números negativos: " + negativos);
            //Console.WriteLine("Quantidade de zeros: " + zeros);

            //double[,] matriz1 = new double[2, 3];
            //double[,] matriz2 = new double[2, 3];
            //double[,] soma = new double[2, 3];

            //Console.WriteLine("Digite os valores para a primeira: ");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("Digite o valor para a posição " + i + j);
            //        matriz1[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Digite os valores para a segunda: ");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("Digite o valor para a posição " + i + j);
            //        matriz2[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        soma[i, j] = matriz1[i, j] + matriz2[i, j];
            //    }
            //}
            //Console.WriteLine("Matriz um: ");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matriz1[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Matriz dos: ");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matriz2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("Matriz resultado: ");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(soma[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] matriz = new int[4, 4];

            //Random random = new Random();

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        matriz[i, j] = random.Next(0, 10);
            //    }
            //}
            //Console.WriteLine("Matriz: ");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int maiorNumero = -1;
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (matriz[i, j] > maiorNumero)
            //        {
            //            maiorNumero = matriz[i, j];
            //        }
            //    }
            //}

            //Console.WriteLine("O maior número da matriz  e " + maiorNumero);

            //int[,] A = new int[3, 3];
            //int[,] B = new int[3, 3];
            //int[,] C = new int[3, 3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("Digite um número para a posição" + i + " " + j + " da A: ");
            //        int num = int.Parse(Console.ReadLine());
            //        A[i, j] = num;
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("Digite um número para a posição" + i + " " + j + " da B: ");
            //        int num = int.Parse(Console.ReadLine());
            //        B[i, j] = num;
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        C[i, j] = A[i, j] - B[i,j];
            //    }
            //}


            //Console.WriteLine("Matriz A:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(A[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Matriz B:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(B[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Matriz C:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(C[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] matriz = new int[4, 4];

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("Digite o elemento " + i + j +" ");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Matriz: ");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Matriz inversa:");
            //for (int i = 3; i >= 0; i--)
            //{
            //    for (int j = 3; j >= 0; j--)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] matriz = new int[3, 3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("Digite o elemento " + i + j + " ");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.Write("Digite um numero para pesquisa ");
            // int pesquisa = int.Parse(Console.ReadLine());

            //bool encontra = false;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if (matriz[i,j] == pesquisa)
            //        {
            //            encontra = true;
            //            break;
            //        }
            //    }
            //}
            //if (encontra)
            //{
            //    Console.WriteLine("O número existe na matriz.");
            //}
            //else
            //{
            //    Console.WriteLine("Número inexistente na matriz.");
            //}

            //double[,] A = new double[4, 4];
            //Console.WriteLine("Digite os elementos da matriz A:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"A[{i},{j}] = ");
            //        A[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}

            //double[,] B = new double[4, 4];
            //Console.WriteLine("Digite os elementos da matriz B:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"B[{i},{j}] = ");
            //        B[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}

            //double soma = 0;
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        soma += A[i, j] + B[i, j];
            //    }
            //}
            //double media = soma / (2 * 16);

            //int abaixo = 0;
            //int acima = 0;
            //int naMedia = 0;
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (A[i, j] < media)
            //        {
            //            abaixo++;
            //        }
            //        else if (A[i, j] > media)
            //        {
            //            acima++;
            //        }
            //        else
            //        {
            //            naMedia++;
            //        }

            //        if (B[i, j] < media)
            //        {
            //            abaixo++;
            //        }
            //        else if (B[i, j] > media)
            //        {
            //            acima++;
            //        }
            //        else
            //        {
            //            naMedia++;
            //        }
            //    }
            //}

            //Console.WriteLine("Média: " + media);
            //Console.WriteLine("Elementos abaixo da média: " + abaixo);
            //Console.WriteLine("Elementos acima da média: "  + acima);
            //Console.WriteLine("Elementos na média: " + naMedia);


            //double[,] A = new double[3, 3];
            //double[,] matrizResultante = new double[3, 3];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("Digite o valor de A" + i + j +" : ");
            //        A[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        double somaIndices = i + j;
            //        matrizResultante[i, j] = A[i, j] / somaIndices;
            //        matrizResultante[0, 0] = A[0, 0];
            //    }
            //}

            //Console.WriteLine("Matriz Resultante:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matrizResultante[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] matriz = new int[4, 3];

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("Digite o valor da posicao " + i + j + " :");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Valores com soma de índices par:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if ((i + j) % 2 == 0)
            //        {
            //            Console.WriteLine(matriz[i, j]);
            //        }
            //    }

            //}

            //int somaDiagonalPrincipal = 0;
            //int somaDiagonalSecundaria = 0;
            //int[,] matriz = new int[3, 3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("Digite o valor da posicao " + i + j + " :");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}



            //Console.WriteLine("Matriz:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    somaDiagonalPrincipal += matriz[i, i];
            //    somaDiagonalSecundaria += matriz[i, 2 - i];
            //}

            //if (somaDiagonalPrincipal == somaDiagonalSecundaria)
            //{
            //    Console.WriteLine("A soma dos elementos da diagonal e igual ao das secundaria", somaDiagonalPrincipal, somaDiagonalSecundaria);
            //}
            //else
            //{
            //    Console.WriteLine("A soma das diagonais nao e igual");
            //}


            //int[,] matriz = new int[3, 3];
            //bool iguais = true;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("Digite o valor da posição [{0},{1}]: ", i, j);
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < 3; i++)
            //{
            //    if (matriz[i, i] != matriz[i, 2 - i])
            //    {
            //        iguais = false;
            //        break;
            //    }
            //}


            //Console.WriteLine("Matriz:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //if (iguais)
            //{
            //    Console.WriteLine("As diagonais são iguais!");
            //}
            //else
            //{
            //    Console.WriteLine("As diagonais são diferentes!");
            //}


            //int[,] A = new int[4, 4];
            //int[,] B = new int[4, 4];
            //int[,] C = new int[4, 4];

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("Digite o valor da posição [{0},{1}]: ", i, j);
            //        A[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("Digite o valor da posição [{0},{1}]: ", i, j + " da matriz B");
            //        B[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Matriz A:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(A[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Matriz B:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(B[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Matriz soma:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        C[i, j] = A[i, j] + B[i, j];
            //        Console.Write(C[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //int[,] A = new int[3, 4];
            //int[,] B = new int[4, 3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("Digite o valor da posição [{0},{1}]: ", i, j);
            //        A[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Matriz A:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(A[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //       B[j, i] = A[i, j];
            //    }
            //}
            //Console.WriteLine("Matriz B:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(B[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //int[,] matriz = new int[4, 4];
            //int maiorValor = -100000000;
            //int menorValor = 100000000;
            //int linhaMenor=10000;
            //int colunaMenor=10000;

            //int linhaMaiorValor = 0;
            //int colunaMaiorValor = 0;

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("Digite o elemento [" + i + "," + j + "]: ");
            //        matriz[i, j] = int.Parse(Console.ReadLine());

            //        if (matriz[i, j] > maiorValor)
            //        {
            //            maiorValor = matriz[i, j];
            //            linhaMaiorValor = i;
            //            colunaMaiorValor = j;
            //        }
            //    }
            //}

            //Console.WriteLine("Matriz :");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = linhaMaiorValor; i <= linhaMaiorValor; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (matriz[i, j] < menorValor)
            //        {
            //            menorValor = matriz[i, j];
            //            linhaMenor = i;
            //            colunaMenor = j;
            //        }
            //    }
            //}


            //Console.WriteLine("O mair valor se encontra na linha " + linhaMaiorValor + " e na coluna " + colunaMaiorValor + " sendo ele " + maiorValor);
            //Console.WriteLine("O menor valor da linha " + linhaMaiorValor   + " se encontra na coluna " + colunaMenor + " sendo ele " + menorValor);




        }
    }
}
