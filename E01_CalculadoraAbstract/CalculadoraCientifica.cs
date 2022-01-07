using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_CalculadoraAbstract
{
    class CalculadoraCientifica : Calculadora
    {
        #region Properties
        public override double Valor1 { get; set; }
        public override double Valor2 { get; set; }
        public override double Resultado { get; set; }

        #endregion

        #region Methods

        public override double Soma(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 + v2;
            return Resultado;
        }

        public override double Subtracao(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 - v2;
            return Resultado;
        }

        public override double Multiplicacao(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 * v2;
            return Resultado;
        }

        public override double Divisao(double v1, double v2)
        {

            Valor1 = v1;
            Valor2 = v2;
            if (v2 == 0)
            {
                Resultado = 0;
            }
            else
            {
                Resultado = v1 / v2;
            }
            return Resultado;
        }

        public double RaizQuadrada(double v1)
        {
            Valor1 = v1;
            Resultado = Math.Sqrt(Valor1);
            return Resultado;
        }

        public double ValorAbsoluto(double v1)
        {
            Valor1 = v1;
            Resultado = Math.Abs(Valor1);
            return Resultado;
        }

        #endregion
    }
}
