using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    class Polimorphism
    {
        #region Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Location { get; set; }
        #endregion

        #region Methods

        // Overloading de métodos -> mesmo método com assinaturas diferentes
        public void ListFullName()
        {
            Console.WriteLine($"Full Name: {Name} {Surname}");
        }

        public void ListFullName(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Console.WriteLine($"Full Name: {Name} {Surname}");
        }

        public void ListFullNameUS(string surname, string name)
        {
            Name = name;
            Surname = surname;
            Console.WriteLine($"Full Name: {Surname}, {Name}");
        }

        // marcar o método para overriding com virtual (classe base)
        public virtual void ListAll(string name, string surname, string location)
        {
            Name = name;
            Surname = surname;
            Location = location;
            Console.WriteLine($"{Name} {Surname} mora em {Location}.");
        }

        #endregion
    }

    class PolimorphismDerived : Polimorphism
    {
        //Overriding de métodos
        //métodos com a mesma assinatura, mas diferentes implementações

        #region Methods
        // marcar o método para overriding com override (classe derivada)
        public override void ListAll(string name, string surname, string location)
        {
            Name = name;
            Surname = surname;
            Location = location;
            Console.WriteLine($"{Name} {Surname} lives in {Location}.");
        }
        #endregion

    }
}
