using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_Interfaces
{

    /* não se usam os access modifiers: public, private, static, internal, ...
    não implementam propriedades, não podem ter set
    não implementam métodos, não podem ter corpo (chavetas) */
    interface IAuthentication
    {
        #region Properties
        string UserName { get; }
        string UserPassword { get; }
        #endregion

        #region Methods
        bool Validate(string userName, string userPassword);

        void Exit();

        void Message(string message, string startLine = "", string endLine = "");

        #endregion


    }
}
