using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    class Inheritance
    {

        #region Properties
        public string Name { get; set; }
        #endregion

        #region Methods

        public void ListName()
        {
            Console.WriteLine($"Name: {Name}");
        }

        #endregion

    }

    class InheritanceChild : Inheritance
    {

        #region Properties
        public string Surname { get; set; }
        #endregion

        #region Methods

        public void ListSurname()
        {
            Console.WriteLine($"Surname: {Surname}");
        }

        #endregion

    }


    // properties: name, surname, fullname
    // constructors: 1 vazio, 1 a passar todos os valores
    // methods: ListFullName
    class Person
    {

        #region Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        #endregion

        #region Constructors
        public Person()
        {
            Name = string.Empty;
            Surname = string.Empty;
            FullName = string.Empty;

        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            FullName = $"{Name} {Surname}";

        }

        #endregion

        #region Methods

        public void ListFullName()
        {
            Console.WriteLine($"Full Name: {FullName}");
        }

        #endregion

    }

    // properties: Course, Location
    // methods: ListAll
    class Student : Person
    {
        #region Properties
        public string Course { get; set; }
        public string Location { get; set; }
        #endregion

        #region Constructors
        // mapear este construtor para o 1º da classe base
        public Student() : base()
        {
        }

        // mapear este construtor para o 2º da classe base
        public Student(string name, string surname) : base(name, surname)
        {
        }

        public Student(string name, string surname, string course, string location)
        {
            Name = name;
            Surname = surname;
            FullName = $"{Name} {Surname}";
            Course = course;
            Location = location;
        }

        #endregion

        #region Methods

        public void ListAll()
        {
            Console.WriteLine($"O formando {FullName} frequenta o curso {Course} e mora na localidade {Location}");
        }

        #endregion

    }

    

}
