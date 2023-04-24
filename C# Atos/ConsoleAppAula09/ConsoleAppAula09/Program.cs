using System.Collections.Generic;
using System;

namespace ConsoleAppAula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++{
                vetor[i] = gerador.Next(10, 50);
            }

            for (int i = 0; i < vetorI.Lenght; i++)
            {
                Console.WriteLine(vetorI[i]);
            }

            //matriz de duas dimensoes linha por coluna
            //int[,] matrizI = new int[3,4];
            //string[,] matrizS = new string[2,3];


          //  MATRIZES 0 1 2 3

          // 1 DIMENSÃO->vetorI[1 8 9 98] vetorS["Ana" "Bia" "Carlos", "Pedro"] vetorD[3.8, 8.9, 9.8, 5.7]

          ////declaração
          //int[] vetorI = new int[4];
          //  string[] vetorS = new string[4];
          //  double[] vetorD = new double[4];

          //  //acesso direto ou randomizável
          //  vetorI[0] = 15
          //if (vetorS[1] == "Bia")
          //  {

          //  }
          //  vetorD[3] = vetorD[3] * 2.4;

          //  //percorrer 
          //  for (int i = 0; i < vetorI.length; i++)
          //  {
          //      Console.WriteLine(vetorI[i]);
          //  }

          //  //Listas = Coleções com características de vetores dinâmicos
          //  Exemplos:
          //      -List
          //      - LinkedList
          //      - Hash
          //      2 DIMENSÕES->comumente chamado de matriz ou array - relação de linhas por colunas matrizI[1 5 4 8 33 6 1 7 98 4 2 9]

          //matrizS
          //[
          //    "ana"   "pedro" "sofia"
          //    "bruno" "rafa"  "joa"
          //]


          //    //declaração
          //    int[,] matrizI = new int[3, 4];
          //      string[,] matrizS = new string[2, 3];

          //      //acessando direto a linha 1 e coluna 3
          //      matrizI[1, 3] = 999;

          //      if (matrizS[0, 1] == "joca")
          //      {

          //      }


          //  //
          //  matrizI
          //  [
          //      0  0   0  0
          
          //      0  0   0  0
          
          //      0  0   0  0
          //  ]
          //Random gerador = new Random();
          //  for (int i = 0; i < 3; i++)
          //  {       //for externo é para as linhas
          //      for (int j = 0; j < 4; j++)
          //      {   //for interno é para as colunas
          //          matrizI[i, j] = matriz[i, j] * 3;
          //      }
          //  }


          //  int[,] matriz = new int[5, 3];

          //  for (int i = 0; i < 5; i++)
          //  {
          //      for (int j = 0; j < 3; j++)
          //      {
          //          matriz[i, j] = 0;
          //      }
          //  }

          //  for (int linha = 0; linha < 5; linha++)
          //  {
          //      Console.WriteLine("Digite um valor para a primeira coluna: ");
          //      matroz[linha, 0] = int.Par(Console.readline());
          //      matriz[linha, 1] = matriz[linha, 0] + 10;
          //      matriz[linha, 2] = matriz[linha, 0] * 2;

          //  }


            // 1) Crie uma Matriz 5x3. Na primeira coluna,
            // solicite que o usuário preencha.
            // A 2ª coluna, some 10 aos elementos da
            // 1ª coluna. Na 3º coluna, armazene o dobro
            // dos elementos da 1ª coluna.
            // 5   15   10   
            // 3   0   0
            // 2   0   0
            // 6   0   0
            // 4   0   0
            //padrão de preenchimento de matrizes: linha X coluna
            //declaracao
            //int[,] matriz = new int[5, 3];
            //for (int linha = 0; linha < 5; linha++)
            //{
            //    Console.Write("Digite um valor para a primeira coluna: ");
            //    matriz[linha, 0] = int.Parse(Console.ReadLine());
            //    matriz[linha, 1] = matriz[linha, 0] + 10;
            //    matriz[linha, 2] = matriz[linha, 0] * 2;
            //}
            //for (int linha = 0; linha < 5; linha++)
            //{
            //    for (int coluna = 0; coluna < 3; coluna++)
            //    {
            //        Console.Write(matriz[linha, coluna] + "\t");
            //    }
            //    Console.WriteLine();
        //    }
        }
    }
}