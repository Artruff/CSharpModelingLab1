using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab1.Classes
{
    class RandomValueGenerator
    {
        Interfaces.IFunctionDensity _density;
        double _leftBorder, _rightBorder;
        public RandomValueGenerator(Interfaces.IFunctionDensity density, double leftBorder, double rightBorder)
        {
            _density = density;
            _leftBorder = leftBorder;
            _rightBorder = rightBorder;
        }
        public double Next()
        {
            Random random = new Random();
            double x;
            if (_leftBorder == 0 && _rightBorder == 1)
                x = random.NextDouble();
            else
                x = random.NextDouble()*random.Next((int)_leftBorder, (int)_rightBorder);
            return _density.Density(x);
        }
    }
}
