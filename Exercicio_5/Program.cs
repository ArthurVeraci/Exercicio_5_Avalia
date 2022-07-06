using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros de 1 a 50: ");
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i * 2);
            }
            Console.ReadKey();
        }
    }
}
