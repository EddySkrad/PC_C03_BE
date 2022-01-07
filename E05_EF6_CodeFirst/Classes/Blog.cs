using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_EF6_CodeFirst
{
    class Blog
    {

        #region Properties
        // properties
        public int BlogId { get; set; } // PK + Identity

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        // navigation property
        // 1 blog pode ter uma lista (n) de posts
        public virtual List<Post> Posts { get; set; }
        #endregion

        #region Methods

        public static void InsertBlog()
        {
            using (var db = new BlogContext())
            {

                // Create and save a new Blog
                Console.Write("Nome do novo blog: ");
                var name = Console.ReadLine();

                var blog = new Blog();

                blog.Name = name;

                db.Blog.Add(blog);

                db.SaveChanges();
            }
        }

        public static void ListBlog()
        {
            using (var db = new BlogContext())
            {
                // Display all blogs from the database
                var query = db.Blog.Select(b => b).OrderBy(b => b.BlogId);

                Console.WriteLine("\n\n-------------\nTodos os blogs\n-------------");

                foreach (var item in query)
                {
                    Console.WriteLine($"{item.BlogId} - {item.Name}");
                }

                //Console.ReadKey();
            }
        }

        #endregion


    }
}
