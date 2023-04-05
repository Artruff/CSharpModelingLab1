using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpModelingLab1
{
    public partial class Modeling : Form
    {
        Classes.DistributionGenerator distributionGenerator;
        public Modeling()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Generate();
        }
        private void Generate()
        {
            int count = Convert.ToInt32(countTextBox.Text);
            double leftBoard = Convert.ToDouble(LeftBoardTextBox.Text), 
                rightBoard = Convert.ToDouble(RightBoardTextBox.Text),
                expectation = Convert.ToDouble(expectationTextBox.Text), devitation = Convert.ToDouble(squarDeviationTextBox.Text);
           
            Interfaces.IFunctionDensity density = new Classes.NormalDistribution(expectation,devitation);
            Classes.RandomValueGenerator valueGenerator = new Classes.RandomValueGenerator(density, leftBoard, rightBoard);
            distributionGenerator = new Classes.DistributionGenerator(valueGenerator);
            distributionGenerator.Generate(NormalBox, NormalChart, count);
        }
    }
}
