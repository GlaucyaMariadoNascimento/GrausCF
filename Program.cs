using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double c = 0;
            double f = 0;

            Console.Write("Entre com a temperatura na escala celsius: ");

            c = double.Parse(Console.ReadLine());

            f = (double)  c * 18 / 10 + 32;

            Console.Write("Temperatura convertida em fahrenheit  é : " + f);
            Console.ReadKey();
        }
    }
}
