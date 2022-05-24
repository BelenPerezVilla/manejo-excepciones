using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hola
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;

            try
            {
                Console.Write("Teclee un numero entero: ");
                numero = int.Parse(Console.ReadLine());
                resultado = numero * numero;
                Console.WriteLine("El numero " + numero + "al cuadrado es: " + resultado);
            }
            catch(FormatException)
            {
                Console.WriteLine("el formato no cumple los requisitos");
            }
            catch(OverflowException a)
            {
                Console.WriteLine(a.Message);
            }
            Console.ReadKey();
        }
    }
}
