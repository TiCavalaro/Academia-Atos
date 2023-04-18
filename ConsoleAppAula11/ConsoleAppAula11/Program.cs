using System;
using System.Runtime.Intrinsics.X86;

namespace ConsoleAppAula11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("\nDigite 1 para jogar com outro Player");
                Console.WriteLine("\nInsira 2 para jogar com o computador");
                Console.WriteLine("\nInsira 3 para finalizar o programa:");

                int opcao;
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Player();
                            break;
                        case 2:
                            Computador();
                            break;
                        case 3:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Digite um número inteiro.");
                }
            }
        }



        public static void Player()
        {
            bool jogarNovamente = true;

            while (jogarNovamente)
            {
                char[,] matriz = new char[3, 3];
                int linha, coluna, contador;

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("\t.");
                        matriz[i, j] = '.';
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }

                // Primeiro jogador sempre será 'X' e o segundo sempre será 'O';
                for (contador = 0; contador < 9; contador++)
                {
                    Console.WriteLine($"\nJogador {(contador % 2) + 1} escolha a posição (linha, coluna) para jogar:");

                    try
                    {
                        Console.Write("Linha: ");
                        linha = int.Parse(Console.ReadLine()) - 1;

                        Console.Write("Coluna: ");
                        coluna = int.Parse(Console.ReadLine()) - 1;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nEntrada inválida para a linha ou coluna, tente novamente\n");
                        contador--;
                        continue;
                    }

                    if (linha < 0 || linha > 2 || coluna < 0 || coluna > 2)
                    {
                        Console.WriteLine("\nLinha ou coluna inválida, tente novamente\n");
                        contador--;
                        continue;
                    }

                    Console.WriteLine();
                    if (matriz[linha, coluna] == '.')
                    {
                        matriz[linha, coluna] = contador % 2 == 1 ? 'O' : 'X';
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write($"\t{matriz[i, j]}");
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        if ((matriz[0, 0] == matriz[0, 1] && matriz[0, 0] == matriz[0, 2] && matriz[0, 0] != '.') ||
                            (matriz[0, 0] == matriz[1, 1] && matriz[0, 0] == matriz[2, 2] && matriz[0, 0] != '.') ||
                            (matriz[0, 0] == matriz[1, 0] && matriz[0, 0] == matriz[2, 0] && matriz[0, 0] != '.') ||
                            (matriz[0, 1] == matriz[1, 1] && matriz[0, 1] == matriz[2, 1] && matriz[0, 1] != '.') ||
                            (matriz[0, 2] == matriz[1, 2] && matriz[0, 2] == matriz[2, 2] && matriz[0, 2] != '.') ||
                            (matriz[1, 0] == matriz[1, 1] && matriz[1, 0] == matriz[1, 2] && matriz[1, 0] != '.') ||
                            (matriz[2, 0] == matriz[2, 1] && matriz[2, 0] == matriz[2, 2] && matriz[2, 0] != '.') ||
                            (matriz[2, 0] == matriz[1, 1] && matriz[2, 0] == matriz[0, 2] && matriz[2, 0] != '.'))
                        {
                            Console.WriteLine($"\nJogador {(contador % 2) + 1} ganhou!");
                            jogarNovamente = false;
                            break;
                        }
                    }
                    else if (matriz[linha, coluna] != '.')
                    {
                        Console.WriteLine("\nO espaço escolhido já está ocupado, repita a operação para um espaço válido\n");
                        contador--;
                    }
                    // Verificar se ocorreu um empate após a última jogada
                    if (contador == 8)
                    {
                        Console.WriteLine("\nEmpate!");
                        jogarNovamente = false;
                        break;
                    }
                }

            }
        }


        public static void Computador()
        {
            bool jogarNovamente = true;

            while (jogarNovamente)
            {
                char[,] matriz = new char[3, 3];
                int linha, coluna, contador;

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("\t.");
                        matriz[i, j] = '.';
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }

                Random rnd = new Random();

                // O jogador sempre será 'X' e o computador sempre será 'O';
                for (contador = 0; contador < 9; contador++)
                {
                    if (contador % 2 == 0)
                    {
                        Console.WriteLine($"\nEscolha a posição (linha, coluna) para jogar:");

                        try
                        {
                            Console.Write("Linha: ");
                            linha = int.Parse(Console.ReadLine()) - 1;

                            Console.Write("Coluna: ");
                            coluna = int.Parse(Console.ReadLine()) - 1;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nEntrada inválida para a linha ou coluna, tente novamente\n");
                            contador--;
                            continue;
                        }

                        if (linha < 0 || linha > 2 || coluna < 0 || coluna > 2)
                        {
                            Console.WriteLine("\nLinha ou coluna inválida, tente novamente\n");
                            contador--;
                            continue;
                        }

                        Console.WriteLine();
                        if (matriz[linha, coluna] == '.')
                        {
                            matriz[linha, coluna] = 'X';
                        }
                        else if (matriz[linha, coluna] != '.')
                        {
                            Console.WriteLine("\nO espaço escolhido já está ocupado, repita a operação para um espaço válido\n");
                            contador--;
                            continue;
                        }
                    }
                    else
                    {
                        linha = rnd.Next(0, 3);
                        coluna = rnd.Next(0, 3);

                        while (matriz[linha, coluna] != '.')
                        {
                            linha = rnd.Next(0, 3);
                            coluna = rnd.Next(0, 3);
                        }

                        Console.WriteLine($"\nO computador jogou na posição ({linha + 1}, {coluna + 1})");
                        matriz[linha, coluna] = 'O';
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine();
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write($"\t{matriz[i, j]}");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    }

                    if ((matriz[0, 1] == matriz[1, 1] && matriz[0, 1] == matriz[2, 1] && matriz[0, 1] != '.') ||
                        (matriz[1, 0] == matriz[1, 1] && matriz[1, 0] == matriz[1, 2] && matriz[1, 0] != '.') ||
                        (matriz[0, 0] == matriz[1, 0] && matriz[0, 0] == matriz[2, 0] && matriz[0, 0] != '.') ||
                        (matriz[2, 0] == matriz[2, 1] && matriz[2, 0] == matriz[2, 2] && matriz[2, 0] != '.') ||
                        (matriz[0, 2] == matriz[1, 2] && matriz[0, 2] == matriz[2, 2] && matriz[0, 2] != '.') ||
                        (matriz[0, 0] == matriz[1, 0] && matriz[0, 0] == matriz[2, 0] && matriz[0, 0] != '.') ||
                        (matriz[0, 2] == matriz[1, 1] && matriz[0, 2] == matriz[2, 0] && matriz[0, 2] != '.') ||
                        (matriz[0, 1] == matriz[1, 0] && matriz[0, 1] == matriz[2, 2] && matriz[0, 1] != '.'))
                    {
                        if (contador % 2 == 0)
                        {
                            Console.WriteLine("\nO computador venceu!");
                        }
                        else
                        {
                            Console.WriteLine("\nVocê venceu!");
                        }
                        break;
                    }
                    if (contador == 8)
                    {
                        Console.WriteLine("\nDeu velha!");
                    }
                }

                Console.WriteLine("\nDeseja jogar novamente? (S/N)");
                string resposta = Console.ReadLine();

                if (resposta.ToUpper() != "S")
                {
                    jogarNovamente = false;
                }
            }

        }

    }
}