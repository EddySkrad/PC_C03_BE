using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_CalculadoraInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraSimples cs = new CalculadoraSimples();
            CalculadoraCientifica cc = new CalculadoraCientifica();

            Console.WriteLine(cs.Soma(1, 2));
            Console.WriteLine(cs.Soma(1, 2, 3));
            Console.WriteLine(cs.Subtracao(1, 2));
            Console.WriteLine(cs.Multiplicacao(1, 2));
            Console.WriteLine(cs.Multiplicacao(1, 2, 3));
            Console.WriteLine(cs.Multiplicacao(1, 2, 3, 4));
            Console.WriteLine(cs.Divisao(1, 2));

            Console.WriteLine("\n\n");

            Console.WriteLine(cc.Soma(1, 2));
            Console.WriteLine(cc.Subtracao(1, 2));
            Console.WriteLine(cc.Multiplicacao(1, 2));
            Console.WriteLine(cc.Divisao(1, 2));
            Console.WriteLine(cc.RaizQuadrada(9));
            Console.WriteLine(cc.ValorAbsoluto(-10));

            Console.ReadKey();
        }
    }
}
