using System;

namespace MinhaCalculadoraDeSignos
{
    class Program
    {
        private static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                Console.WriteLine("Em que mês você nasceu?");
                string str1 = Console.ReadLine();
                if (Convert.ToInt32(str1) > 12)
                    Console.WriteLine("Digite mês válido");
                string str2;
                while (true)
                {
                    Console.WriteLine("Em que dia você nasceu?");
                    str2 = Console.ReadLine();
                    if (Convert.ToInt32(str2) > 31)
                        Console.WriteLine("Digite dia válido");
                    else if (Convert.ToInt32(str1) == 2 && Convert.ToInt32(str2) > 29)
                        Console.WriteLine("Digite dia válido para esse mês");
                    else
                        break;
                }
                num1 = Convert.ToInt32(str2);
                num2 = Convert.ToInt32(str1);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }
            Signo signo = new InterpretadorSigno().Interpretar(Convert.ToInt32(num2), Convert.ToInt32(num1));
            if (signo != null)
                Console.WriteLine("Seu signo é " + signo.nome + " " + signo.caracteristicas);
            else
                Console.WriteLine("Não foi possível interpretar o seu signo. Tente novamente");
            Console.ReadLine();
        }
    }
}


