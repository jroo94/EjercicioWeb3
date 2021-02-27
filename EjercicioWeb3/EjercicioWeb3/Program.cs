using System;

namespace EjercicioWeb3
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = 1;
            
            Console.WriteLine("Introduce un número");

            var numero = Console.ReadLine();
            var num = byte.Parse(numero);            

            for (int i = 2; i <= num; i++)
            {
                result = result * i;
            }

            Console.WriteLine("El factorial de {0} es {1}", num, result);
            Console.Write("Tecle para continuar");
            Console.ReadLine();
        }
    }
}
