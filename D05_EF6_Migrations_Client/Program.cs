using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D05_EF6_Migrations_DAL;
using System.Data.Entity;

namespace D05_EF6_Migrations_Client
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                // 1. Inicializar a BD
                Database.SetInitializer(new NullDatabaseInitializer<BibliotecaContext>());
            
                // 2. Inserir uma editora
                ClientEditora.InserirEditora();
            
                // 3. Inserir um livro da editora
                ClientLivro.InserirLivro();
            
            
                // 4. Fim
                Console.Write("Registos inseridos com sucesso!");
            
                Console.ReadKey();

            }
            catch (Exception)
            {
                Console.WriteLine("Erro!");
                //throw;
            }

            

        }
    }
}
