using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_CalculadoraAbstract
{
    abstract class Calculadora
    {
        #region Properties
        public abstract double Valor1 { get; set; }
        public abstract double Valor2 { get; set; }
        public abstract double Resultado { get; set; }
        #endregion

        #region Methods

        public abstract double Soma(double v1, double v2);

        public abstract double Subtracao(double v1, double v2);

        public abstract double Multiplicacao(double v1, double v2);

        public abstract double Divisao(double v1, double v2);

        #endregion

    }
}
