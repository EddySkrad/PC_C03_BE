using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_CalculadoraInterface
{
    interface ICalculadora
    {
        #region Properties
        double Valor1 { get; }
        double Valor2 { get; }
        double Resultado { get; }
        #endregion

        #region Methods

        double Soma(double v1, double v2);
        double Subtracao(double v1, double v2);
        double Multiplicacao(double v1, double v2);
        double Divisao(double v1, double v2);

        #endregion
    }
}
