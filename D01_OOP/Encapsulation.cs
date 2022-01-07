using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    // access modifiers: public, private
    // por defeito, as classes são public -> podem ser usadas noutras classes

    // Encapsulation:
    //      propriedades e métodos: public
    //      variáveis e fields: private
    class Encapsulation
    {
        #region Variáveis (públicas à classe, privadas fora da classe)
        int value01 = 0;
        #endregion

        #region Fields (variável privada de suporte à propriedade)
        private string name;
        #endregion

        #region Properties
        // classic (obrigam à criação de um field privado de suporte)

                //Surname = "dhdhfjf";            // set -> é para escrever o valor da propriedade
                //Console.WriteLine(Surname);     // get -> é para ler o valor da propriedade

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        // Auto-implemented
        public string Surname { get; set; }
        
        // Bodied-expression (lambda operator =>)
        #endregion

        #region Methods
        public void List01()
        {
            Console.WriteLine($"{Name} {Surname}");
        }

        // por omissão do access modifier, o método é private
        // No entanto, o método devia ser public
        void List02()
        {

        }
        #endregion

    }
}
