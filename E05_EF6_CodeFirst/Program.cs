using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_EF6_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                // chamar 1 método static (não podem ser usados em interfaces)
                Blog.InsertBlog();

                /*
                // chamar 1 método de instância
                Blog blog01 = new Blog();
                blog01.ListBlog();
                */
                // ToDo: implementar inserir e listar posts - Done

                Post.InsertPost();
                Post.ListPost();

            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro.");
                //throw;
                
            }
        }
    }
}
