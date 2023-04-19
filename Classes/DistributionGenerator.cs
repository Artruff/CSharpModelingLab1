using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSharpModelingLab1.Classes
{
    class DistributionGenerator
    {
        private RandomValueGenerator _generator;
        public RandomValueGenerator generator
        {
            get => _generator;
            set => _generator = value;
        }
        public DistributionGenerator(RandomValueGenerator generator)
        {
            _generator = generator;
        }
        
        public void Generate(ListBox box, Chart chart, int count)
        {
            box.Items.Clear();
            double x;
            for (int i = 0; i < count; i++)
            {
                x = generator.Next();
                box.Items.Add(x);
                chart.Series[0].Points.Add(x);
            }
        }
    }
}
