using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_EF6_FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Usar a ConnectionString
            using (var db = new GestaoFormacaoDBEntities()) // classe que herda o DbContext
            {

            

                #region AreaCurso
                AreaCurso _areaCurso = new AreaCurso();
                // areaCurso01.AreaCursoID = 3;  // É identity, logo não se pode inserir nem manipular
                _areaCurso.Area = "Soft skills";
                db.AreaCurso.Add(_areaCurso);
                db.SaveChanges();
                _areaCurso.Area = "Artes";
                db.AreaCurso.Add(_areaCurso);
                db.SaveChanges();

                // 1. Instanciamos a classe
                // 2. preenchemos as propriedades
                // 3. adicionamos o objecto ao dbset (que representa a tabela da bd em memória)
                // 4. gravar as alterações no contexto

                #endregion

                #region Subarea

                #endregion

                #region Curso

                #endregion

                Console.ReadKey();

            }

        }
    }
}
