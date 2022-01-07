using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_EF6_CodeFirst
{
    class Post
    {

        #region Properties
        // properties
        public int PostId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(200)]
        public string Content { get; set; }
        
        public int BlogId { get; set; }

        //public DateTime PostDate { get; set; }

        // navigation property
        // 1 post pode ter somente 1 blog
        public virtual Blog Blog { get; set; }
        #endregion

        #region Methods

        public static void InsertPost()
        {
            using (var db = new BlogContext())
            {
                
                //1. Listar os blogs
                Console.WriteLine("------Lista de blogs------");
                Blog.ListBlog();

                // 2. Pedir ao user para escolher 1 blog pelo nª
                Console.Write("\nEscolha o blog:");
                var blogNr = Convert.ToInt32(Console.ReadLine());
                
                // 3. Verificar se esse nº de blog existe
                /*if (blogNr == 0)
                {
                    Console.WriteLine("Blog inexistente");
                }
                else
                {
                    
                }
                */

                // 3.1. Se não existir
                //      Obrigar o user a escolher um nº de blog existente (while)
                //      OU
                //      Sair e pedir ao user para repetir a operação

                // 3.2. Se existir, pedir os outros dados do post e gravar


                Console.Write("Título do post: ");
                var title = Console.ReadLine();
                Console.Write("Conteúdo do post: ");
                var content = Console.ReadLine();

                /*
                Console.Write("ID do blog: ");
                var blogId = Convert.ToInt32(Console.ReadLine());
                */


                var post = new Post();

                post.Title = title;
                post.Content = content;
                post.BlogId = 1; // Atenção! Implementar

                db.Post.Add(post);

                db.SaveChanges();

            }
        }

        public static void ListPost()
        {
            using (var db = new BlogContext())
            {
                var query = db.Post.Select(p => p).OrderBy(p => p.PostId);

                Console.WriteLine("\n\n-------------\nTodos os posts\n-------------");

                foreach (var item in query)
                {
                    Console.WriteLine($"{item.PostId} - {item.Title}");
                    Console.WriteLine(item.Content);
                }

                Console.ReadKey();

            }
        }

        #endregion


    }
}
