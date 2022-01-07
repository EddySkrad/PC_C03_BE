using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D05_EF6_Migrations_DAL;

namespace D05_EF6_Migrations_Client
{
    class ClientLivro
    {
        #region Methods
        public static void InserirLivro()
        {
            var livro = new Livro
            {
                ISBN = "123456789",
                Titulo = "Livro do teste",
                EditoraID = 1,
                Tipo = "Romance"
            };
            using (var context = new BibliotecaContext())
            {
                context.Livro.Add(livro);
                context.SaveChanges();
            }
        }

        #endregion

    }
}
