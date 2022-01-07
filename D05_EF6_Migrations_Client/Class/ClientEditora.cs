using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D05_EF6_Migrations_DAL;

namespace D05_EF6_Migrations_Client
{
    class ClientEditora
    {
        #region Methods
        public static void InserirEditora()
        {
            var editora = new Editora
            {
                EditoraNome = "Teste"
            };
            using (var context = new BibliotecaContext())
            {
                context.Editora.Add(editora);
                context.SaveChanges();
            }
        }

        #endregion

    }
}
