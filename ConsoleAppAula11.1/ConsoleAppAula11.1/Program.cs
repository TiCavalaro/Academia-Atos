namespace ConsoleAppAula11._1
{
        internal class Program
        {
            public static void subtrai()
            {
                Console.WriteLine("Aqui eu estou na função subtrai");
            }
            public static void soma(double num1, double num2)
            {
                double resultado;
                resultado = num1 + num2;
                Console.WriteLine(num1 + "+" + num2 + "=" + resultado);
            }
            public static void divide()
            {
                Console.WriteLine("Aqui eu estou na função divide");
            }
            public static double multiplica(double num1, double num2)
            {
                double resultado;
                resultado = num1 * num2;
                return resultado;
            }
            static void Main(string[] args)
            {
                double n1, n2, res;
                Console.WriteLine("Digite dois numeros: ");
                n1 = double.Parse(Console.ReadLine());
                n2 = double.Parse(Console.ReadLine());
                soma(n1, n2);
                res = multiplica(n1, n2);
                Console.WriteLine(n1 + "*" + n2 + "=" + res);
                subtrai();
                divide();
            }
        }
    }