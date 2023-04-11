namespace ConsoleAppAula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i, op = 0;
            //for(i = 0; i < 10; i++)
            //{
            //    if (i == 3)
            //    {
            //        continue;
            //    }
            //    if (i == 7)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("I vale " + i);
            //}
            //voce pode colocar i do meio como true

            //int i, op = 0;
            //for (i = 0; i  < 100; i++)
            //{
            //    Console.WriteLine("Digite 1 para continuar e 0 para parar");
            //    op = int.Parse(Console.ReadLine());
            //    if (op == 0)
            //    {
            //        break; 
            //    }
            //}

            //int i, op;
            //while (true)
            //{
            //    Console.WriteLine("Digite 1 para continuar e 0 para parar");
            //    op = int.Parse(Console.ReadLine());
            //    if (op > 4 || op < 1)
            //    {
            //        Console.WriteLine("Digite um valor entre 1 e 4");
            //        op = int.Parse(Console.ReadLine());
            //    }
            //}
            //switch (op)
            //{
            //    case1:
            //    Console.WriteLine();
            //    break;

            //}
            //int i, op = 0; while (true)//for(; ;)
            //{ Console.WriteLine("Digite 0 ou 1 ou 2 ou 3 ou 4"); 
            //op = int.Parse(Console.ReadLine()); 
            //if (op > 4 || op < 1) { Console.WriteLine("Digite um valor válido entre 1 e 4"); 
            //continue; 
            //} else 
            //{ Console.WriteLine("Opção "+op+" escolhida!"); 
            //break; 
            //} 
            //} switch (op) 
            //{ case 1: Console.WriteLine("Primeira opção!"); 
            //break; 
            //case 2: 
            //Console.WriteLine("Segunda opção!");
            //break; 
            //case 3: Console.WriteLine("Terceira opção!"); 
            //break; case 4: Console.WriteLine("Quarta opção!"); 
            //break; 
            //} 

            //int i, j, k, l; 
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("i " + i); 
            //    for (j = 0; j < 5; j++) 
            //    { 
            //        Console.WriteLine(" j " + j); 
            //        for (k = 0; k < 3; k++) 
            //        { Console.WriteLine(" k " + k); 
            //            for (l = 0; l < 2; l++) 
            //            { Console.WriteLine(" l " + l); }
            //        } 
            //    }
            //}

            //int numero;

            //while (true)
            //{
            //    Console.Write("Digite um número (0 para sair): ");
            //    if (!int.TryParse(Console.ReadLine(), out numero))
            //    {
            //        Console.WriteLine("Entrada inválida. Tente novamente.");
            //        continue;
            //    }

            //    if (numero == 0)
            //    {
            //        break;
            //    }

            //    Console.WriteLine($"O número {numero} é {(numero % 2 == 0 ? "par" : "ímpar")}.");

            //    bool ehPrimo = true;
            //    for (int i = 2; i < numero; i++)
            //    {
            //        if (numero % i == 0)
            //        {
            //            ehPrimo = false;
            //            break;
            //        }
            //    }

            //    Console.WriteLine($"O número {numero} é {(ehPrimo ? "primo" : "não primo")}.");
            //}

            //Console.WriteLine("Programa encerrado.");


            //int votosJoao = 0, votosZeca = 0, votosBranco = 0;
            //string voto;

            //Console.WriteLine("Digite JOAO, ZECA ou BRANCO para escolher um voto. Digite FIM para encerrar");

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
            //    }
            //    else if (voto == "ZECA")
            //    {
            //        votosZeca++;
            //    }
            //    else if (voto == "BRANCO")
            //    {
            //        votosBranco++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Voto inválido. Tente novamente.");
            //    }
            //}

            //Console.WriteLine("Resultado da votação:");
            //Console.WriteLine($"João: {votosJoao} votos");
            //Console.WriteLine($"Zeca: {votosZeca} votos");
            //Console.WriteLine($"Branco: {votosBranco} votos");

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

            //int idade;

            //do
            //{
            //    Console.Write("Digite sua idade: ");
            //    idade = int.Parse(Console.ReadLine());
            //} while (idade <= 0);

            //Console.WriteLine($"Sua idade é {idade}");

            //string nome;
            //int idade;
            //double salario;

            //do
            //{
            //    Console.Write("Digite o nome: ");
            //    nome = Console.ReadLine();
            //    if (string.IsNullOrEmpty(nome) || int.TryParse(nome, out _))
            //    {
            //        Console.WriteLine("Nome incorreto. Tente novamente.");
            //        return;
            //    }
            //} while (string.IsNullOrEmpty(nome));

            //// Solicita a idade, testando se o valor informado é válido
            //do
            //{
            //    Console.Write("Digite a idade: ");
            //    if (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
            //    {
            //        Console.WriteLine("Idade incorreta. Tente novamente.");
            //        return;
            //    }
            //} while (idade <= 0);

            //// Solicita o salário, testando se o valor informado é válido
            //do
            //{
            //    Console.Write("Digite o salário: ");
            //    if (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0)
            //    {
            //        Console.WriteLine("Salário incorreto. Tente novamente.");
            //        return;
            //    }
            //} while (salario <= 0);

            //// Exibe as informações coletadas
            //Console.WriteLine("Nome: {0}", nome);
            //Console.WriteLine("Idade: {0}", idade);
            //Console.WriteLine("Salário: {0}", salario);

            //bool repetir = true;

            //do
            //{
            //    int numero;

            //    do
            //    {
            //        Console.Write("Digite um número inteiro: ");
            //    } while (!int.TryParse(Console.ReadLine(), out numero));

            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine("O número é par.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("O número é ímpar.");
            //    }

            //    Console.Write("Deseja repetir o programa? (S/N): ");
            //    string resposta = Console.ReadLine().ToUpper();

            //    if (resposta == "N")
            //    {
            //        repetir = false;
            //    }

            //} while (repetir);

            //int pessoasCom1a3Filhos = 0;
            //int pessoasCom4a7Filhos = 0;
            //int pessoasComMaisDe8Filhos = 0;
            //int pessoasSemFilhos = 0;

            //for (int i = 1; i <= 30; i++)
            //{
            //    Console.Write($"Quantos filhos a pessoa {i} tem? ");
            //    int numFilhos;
            //    while (!int.TryParse(Console.ReadLine(), out numFilhos) || numFilhos < 0)
            //    {
            //        Console.Write("Quantidade inválida. Informe novamente: ");
            //    }

            //    if (numFilhos >= 1 && numFilhos <= 3)
            //    {
            //        pessoasCom1a3Filhos++;
            //    }
            //    else if (numFilhos >= 4 && numFilhos <= 7)
            //    {
            //        pessoasCom4a7Filhos++;
            //    }
            //    else if (numFilhos > 8)
            //    {
            //        pessoasComMaisDe8Filhos++;
            //    }
            //    else if (numFilhos == 0)
            //    {
            //        pessoasSemFilhos++;
            //    }
            //}

            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine($"Quantidade de pessoas com 1 a 3 filhos: {pessoasCom1a3Filhos}");
            //Console.WriteLine($"Quantidade de pessoas com 4 a 7 filhos: {pessoasCom4a7Filhos}");
            //Console.WriteLine($"Quantidade de pessoas com mais de 8 filhos: {pessoasComMaisDe8Filhos}");
            //Console.WriteLine($"Quantidade de pessoas sem filhos: {pessoasSemFilhos}");



            //int masculino = 0, feminino = 0, idadeTotalMulheres = 0, abaixo30 = 0, acima60 = 0;
            //double mediaIdadeMulheres = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    Console.WriteLine($"Digite as informações da {i}ª pessoa:");
            //    Console.Write("Nome: ");
            //    string nome = Console.ReadLine();

            //    Console.Write("Sexo (M/F): ");
            //    char sexo = Console.ReadKey().KeyChar;
            //    Console.WriteLine();

            //    Console.Write("Idade: ");
            //    int idade;
            //    while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
            //    {
            //        Console.WriteLine("Idade inválida. Digite novamente.");
            //        Console.Write("Idade: ");
            //    }

            //    if (sexo == 'M' || sexo == 'm')
            //    {
            //        masculino++;
            //    }
            //    else if (sexo == 'F' || sexo == 'f')
            //    {
            //        feminino++;
            //        idadeTotalMulheres += idade;
            //    }

            //    if (idade < 30)
            //    {
            //        abaixo30++;
            //    }
            //    else if (idade > 60)
            //    {
            //        acima60++;
            //    }
            //}

            //if (feminino > 0)
            //{
            //    mediaIdadeMulheres = idadeTotalMulheres / (double)feminino;
            //}
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine($"Número de pessoas do sexo masculino: {masculino}");
            //Console.WriteLine($"Número de pessoas do sexo feminino: {feminino}");
            //Console.WriteLine($"Número de pessoas com idade inferior a 30 anos: {abaixo30}");
            //Console.WriteLine($"Número de pessoas com idade superior a 60 anos: {acima60}");
            //Console.WriteLine($"Média de idade das mulheres: {mediaIdadeMulheres:F2}");

            //Console.ReadKey();

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

            //int soma = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    soma += i;
            //}
            //Console.WriteLine("A soma dos cem primeiros números inteiros é: " + soma);

            //int soma = 0;
            //for (int i = 1; i <= 500; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        soma += i;
            //    }
            //}

            //Console.WriteLine("A soma dos valores pares entre 1 e 500 é: " + soma);

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(Math.Pow(2, i));
            //}

            //Console.Write("Digite a primeira nota: ");
            //double nota1 = double.Parse(Console.ReadLine());

            //Console.Write("Digite a segunda nota: ");
            //double nota2 = double.Parse(Console.ReadLine());

            //Console.Write("Digite a terceira nota: ");
            //double nota3 = double.Parse(Console.ReadLine());

            //Console.Write("Digite a quarta nota: ");
            //double nota4 = double.Parse(Console.ReadLine());

            //double media = (nota1 * 2 + nota2 * 1 + nota3 * 2 + nota4 * 4) / 9;

            //if (media >= 7.0)
            //{
            //    Console.WriteLine("Aluno aprovado com média: " + media.ToString("F1"));
            //}
            //else
            //{
            //    Console.WriteLine("Aluno reprovado com média: " + media.ToString("F1"));
            //}
            //int n;
            //do
            //{
            //    Console.Write("Digite um número inteiro menor ou igual a 50: ");
            //} while (!int.TryParse(Console.ReadLine(), out n) || n > 50);

            //int produto = n;

            //while (produto < 250)
            //{
            //    Console.WriteLine(produto);
            //    produto *= 3;
            //}

            //for (int i = 15; i <= 200; i++)
            //{
            //    int quadrado = i * i;
            //    Console.WriteLine("O quadrado de {0} é {1}", i, quadrado);
            //}

            //Console.Write("Digite a base: ");
            //double baseNum = double.Parse(Console.ReadLine());

            //Console.Write("Digite o expoente: ");
            //double expoente = double.Parse(Console.ReadLine());

            //double resultado = Math.Pow(baseNum, expoente);

            //Console.WriteLine("{0} elevado a {1} é igual a {2}", baseNum, expoente, resultado);
        }
    }
}



 
