using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoas_v2
{
    class FuncionarioNormal : Funcionario
    {
        public string Departamento { get; set; }
        public int ID { get; set; }

        public string ListarDepartamento(string departamento)
        {
            Console.WriteLine("Em desenvolvimento.");
            return departamento;
        }

        public int VerificarID(int id)
        {
            Console.WriteLine("Em desenvolvimento.");
            return id;
        }
    }
}
