using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_Interfaces
{
    class User : IAuthentication
    {
        #region Variables
        string message;
        #endregion

        #region Properties
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        #endregion

        #region Constructors
        public User()
        {
            UserName = string.Empty;
            UserPassword = string.Empty;
        }

        public User(string userName, string userPassword)
        {
            UserName = userName;
            UserPassword = userPassword;
        }
        #endregion

        #region Methods
        public void Exit()
        {
            message = "A sair.";
            Message(message, "\n\n");
        }

        public void Message(string message, string startLine = "", string endLine = "")
        {
            Console.Write($"{startLine}{message}{endLine}");
        }

        public bool Validate(string userName, string userPassword)
        {
            if (userName == "frc" && userPassword == "1991")
            {
                message = "Utilizador válido";
                Message(message, "", "\n");
                return true;
            }
            else
            {
                message = "Utilizador inválido";
                Message(message, "\n\n", "\n");
                return false;
            }
        }

        public void PedirUser()
        {
            Console.Write("Username: ");
            UserName = Console.ReadLine();

            Console.Write("Password: ");
            UserPassword = Console.ReadLine();
        }

        #endregion
        
    }
}
