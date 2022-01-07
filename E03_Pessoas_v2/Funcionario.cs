using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoas_v2
{
    class Funcionario : IPessoa
    {
        #region Properties
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }

        #endregion

        #region Methods
        public string ListarEmails(string email)
        {
            Console.WriteLine("Em desenvolvimento.");
            return email;
        }

        public string ListarNomeCompleto(string nome, string sobrenome, string nomecompleto)
        {
            Console.WriteLine("Em desenvolvimento.");
            return nomecompleto;
        }

        public string ListarNomes(string nome)
        {
            Console.WriteLine("Em desenvolvimento.");
            return nome;
        }

        public string ListarSobrenomes(string sobrenome)
        {
            Console.WriteLine("Em desenvolvimento.");
            return sobrenome;
        }
        #endregion
    }
}
