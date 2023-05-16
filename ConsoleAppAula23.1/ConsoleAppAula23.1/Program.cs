namespace ConsoleAppAula23._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo!");
            IMotor motor;

            MotorEletrico me = new MotorEletricoEletrico();

            Console.WriteLine("Digite 1 para ligar o motor eletrico e 2 para ligar a combustao");
            int op = int.Parse(Console.ReadLine());

            if(op== 1)
            {
                motor = new MotorEletrico();
                motor.Ligar();

                motor.Desligar();
            }
            else if( op== 2)
            {
                motor = new MotorCombustao();
            }




        }
    }
}