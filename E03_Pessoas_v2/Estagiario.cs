using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoas_v2
{
    class Estagiario : Funcionario
    {
        public string Curso { get; set; }

        public string ListarCurso(string curso)
        {
            Console.WriteLine("Em desenvolvimento.");
            return curso;
        }
    }
}
