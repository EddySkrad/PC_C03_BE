using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoas_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Estagiario estagiario01 = new Estagiario();
            FuncionarioNormal funcionario01 = new FuncionarioNormal();
            Cliente cliente01 = new Cliente();

            Console.WriteLine(estagiario01.ListarCurso("-"));
            Console.WriteLine(estagiario01.ListarEmails("-"));
            Console.WriteLine(estagiario01.ListarNomes("-"));
            Console.WriteLine(estagiario01.ListarSobrenomes("-"));
            Console.WriteLine(estagiario01.ListarNomeCompleto("-", "-", "-"));

            Console.WriteLine("\n");

            Console.WriteLine(funcionario01.ListarEmails("-"));
            Console.WriteLine(funcionario01.ListarNomes("-"));
            Console.WriteLine(funcionario01.ListarSobrenomes("-"));
            Console.WriteLine(funcionario01.ListarNomeCompleto("-", "-", "-"));
            Console.WriteLine(funcionario01.ListarDepartamento("-"));
            Console.WriteLine(funcionario01.VerificarID(1));

            Console.WriteLine("\n");

            Console.WriteLine(cliente01.ListarEmails("-"));
            Console.WriteLine(cliente01.ListarNomes("-"));
            Console.WriteLine(cliente01.ListarSobrenomes("-"));
            Console.WriteLine(cliente01.ListarNomeCompleto("-", "-", "-"));
            Console.WriteLine(cliente01.ListarMorada("-"));


            Console.ReadKey();

        }
    }
}
