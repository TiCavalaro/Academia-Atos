namespace ConsoleAppAula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine(2 + 2);

            //String nome= "Cavalaro";
            //Console.WriteLine("Digite seu nome");  
            // nome = Console.ReadLine();

            //Console.WriteLine("Seu nome e " + nome); //se valor nao atribuido, diferente de c++, o codigo nao acontece
            //string s; //texto
            //char x; //caractere
            //int z; //numeros inteiros
            //long l; //numeros inteiros
            //float y; //numeros reais
            //double d; //numeros reais
            //bool f; //logico


            //int idade = 32;
            //int dinheiro = 31;
            //int soma;
            //soma = idade + dinheiro;
            //Console.WriteLine("Sua idade e de " + (idade + dinheiro)+ " anos" + soma);

            //float k, j;
            //k = 1;
            //j = 2;
            //Console.WriteLine(k - j);
            //Console.WriteLine(k * j);
            //Console.WriteLine((double)k / (double)j);  //cast  
            //Console.WriteLine("A divisao entre " + k + " e " +  j + " resulta em " + k/j);
            //double a, b;//define a mudanca depois
            //double div = (double)a / (double)b;
            //double div = Convert.ToDouble(a) / Convert.ToDouble(b);

            // Console.Write("Digite o primeiro numero ");
            //a = double.Parse(Console.ReadLine());

            //Console.Write("Digite o segundo numero");
            //b = double.Parse(Console.ReadLine());

            //Console.WriteLine("ola " + nome +  "a  media aritmetica simples foi:  " + (a + b)/2);
            //Console.WriteLine("Digite os graus em C para descobrir em F");
            //double c,f;
            //c = double.Parse(Console.ReadLine());
            //f = 1.8 * c + 32;
            //Console.WriteLine("De C para F seria: " + f);

            double a, b, c;
            Console.Write("Digite o primeiro numero ");
            a = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o segundo numero ");
            b = double.Parse(Console.ReadLine());

             Console.WriteLine("Os valores digitados em ordem foram: " + a + " e "+ b);

            c = a;
            a = b;
            b = c;

           Console.WriteLine("Os valores digitados invertidos foram " + a + " e " + b);

        }
    }
}