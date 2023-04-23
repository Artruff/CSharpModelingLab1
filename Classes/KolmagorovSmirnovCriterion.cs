using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab1.Classes
{
    class KolmagorovSmirnovCriterion
    {

        public bool CheckingAgreement(double[] randomValue, Interfaces.IFunctionDensity density, double theoreticLambda)
        {
            return Agreement(randomValue, density) < theoreticLambda;

        }
        public double Agreement(double[] randomValue,  Interfaces.IFunctionDensity density)
        {
            double D = 0, Dm = 0, Dp = 0;
            //Проверяем гипотезу
            for (int i = 0; i < randomValue.Length; i++)
            {
                //Ищем максимальное отклонение
                Dp = Math.Max(Dp, Math.Abs((Convert.ToDouble(i) / randomValue.Length) - density.Density(randomValue[i])));
                Dm = Math.Max(Dm, Math.Abs(density.Density(randomValue[i]) - (Convert.ToDouble(i) - 1) / randomValue.Length));

                D = Math.Max(D, Math.Abs(Dp - Dm));
            }

            //Вычисляем лямбду для гипотезы
            return D * Math.Sqrt(randomValue.Length);
        }
    }
}
