using System;

namespace EjercicioWeb3
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = 1;
            string cOperacion = "";
            string cResultado = "";
            
            Console.WriteLine("Introduce un número");

            var numero = Console.ReadLine();
            var num = byte.Parse(numero);

            cOperacion = numero + "! = " + numero;
            cResultado = numero + "! = ";

            for (int i = 1; i <= num; i++)
            {
                result = result * i;
                if ((num - i) == 0) { break; }
                cOperacion += "*" + (num - i);
            }

            Console.WriteLine("El factorial de {0} es {1}", num, result);
            Console.WriteLine("Cálculo del factorial de {0}", numero);
            Console.WriteLine(cOperacion);
            Console.WriteLine(cResultado + result);
            Console.Write("Tecle para continuar");
            Console.ReadLine();
        }
    }
}
