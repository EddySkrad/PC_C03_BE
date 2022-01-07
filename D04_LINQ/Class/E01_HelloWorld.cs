using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_LINQ //pode-se retirar o .Class pra ficar com a mesma namespace do program
{

    // Escrever o Hello World em LINQ, usando query e method syntax

    class HelloWorld //pode-se mudar aqui o nome da classe
    {

        #region Method Syntax
        public void HelloWorldMethodSyntax()
        {

            // 1. Array de strings

            string[] words =
            {
                "method",
                "hello",
                "wonderful",
                "linq",
                "beautiful",
                "world"

            };

            // 2. Filtrar: palavras de comprimento igual a 5
            var shortWords = words.Where(w => w.Length == 5); // w de word
            //var shortWords = words.Select(w => w).Where(w => w.Length == 5); // é igual à linha de cima, mas em LINQ, não é preciso fazer Select
            //var shortWords = words.Where(w => w.Length == 5).OrderByDescending(w => w);

            // 3. Listar o array filtrado
            foreach (var item in shortWords)
            {
                Console.WriteLine(item.ToUpper());
            }

        }


        #endregion

        #region Query Syntax
        public void HelloWorldQuerySyntax()
        {

            // 1. Array de strings

            string[] words =
            {
                "method",
                "hello",
                "wonderful",
                "linq",
                "beautiful",
                "world"

            };

            // 2. Filtrar: palavras de comprimento igual a 5
            var shortWords =
                from w in words
                where w.Length == 5
                //orderby w descending
                select w;
            
            // 3. Listar o array filtrado
            foreach (var item in shortWords)
            {
                Console.WriteLine(item.ToUpper());
            }

        }

        #endregion

    }
}
