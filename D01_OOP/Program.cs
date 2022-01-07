using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Inheritance
            /*
            #region Create objects
            Person person01 = new Person();
            Person person02 = new Person("f", "rc");
            Student student01 = new Student();
            Student student02 = new Student("m", "cr");
            Student student03 = new Student("filipe", "rocha cruz", "power code", "porto");
            #endregion

            #region Call methods
            person02.ListFullName();
            student03.ListAll();
            #endregion
            */
            #endregion

            #region Encapsulation
            /*
            Encapsulation encapsulation01 = new Encapsulation();

            encapsulation01.Name = "f";
            encapsulation01.Surname = "rc";
            encapsulation01.List01();
            */
            #endregion

            #region Polimorphism
            /*
            Polimorphism baseClass = new Polimorphism();
            PolimorphismDerived derivedClass = new PolimorphismDerived();

            baseClass.ListFullName();
            baseClass.ListFullName("f", "rc");
            baseClass.ListFullNameUS("rc", "f");
            baseClass.ListAll("f", "rc", "porto");
            derivedClass.ListAll("f", "rc", "porto");

            */
            #endregion

            #region Abstraction
            VertebrateAnimal vertebrateAnimal = new VertebrateAnimal();
            InvertebrateAnimal invertebrateAnimal = new InvertebrateAnimal();

            vertebrateAnimal.Register();
            vertebrateAnimal.List("Gato");

            invertebrateAnimal.Register();
            invertebrateAnimal.List("Polvo");

            #endregion


            Console.ReadKey();

        }
    }
}
