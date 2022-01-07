using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoas
{
    interface IPessoa
    {
        #region Properties
        string Nome { get; }
        string Sobrenome { get; }
        int Idade { get; }
        string Email { get; }
        int Telefone { get; }
        #endregion

        #region Methods
        string ListarNomes(string nome);
        string ListarSobrenomes(string sobrenome);
        string ListarNomeCompleto(string nome, string sobrenome, string nomecompleto);
        string ListarEmails(string email);
        #endregion
    }
}
