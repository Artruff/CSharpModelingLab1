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
        Interfaces.IFunctionDensity densityNormal;
        Interfaces.IFunctionDensity densityFunc;
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
           
            densityNormal = new Classes.NormalDistribution(expectation,devitation);
            Classes.RandomValueGenerator valueGenerator = new Classes.RandomValueGenerator(densityNormal, leftBoard, rightBoard);
            distributionGenerator = new Classes.DistributionGenerator(valueGenerator);
            distributionGenerator.Generate(NormalBox, NormalChart, count);

            funcRandomVariables func = delegate (double x)
            {
                return 2d*x-1;
            };
            densityFunc = new Classes.FunctionDistribution(func);
            valueGenerator = new Classes.RandomValueGenerator(densityFunc, leftBoard, rightBoard);
            distributionGenerator = new Classes.DistributionGenerator(valueGenerator);
            distributionGenerator.Generate(FunctionBox, FunctionChart, count);
        }

        private void CheckSelectionsButton_Click(object sender, EventArgs e)
        {
            CheckSelections();
        }
        private void CheckSelections()
        {
            double criterion = Convert.ToDouble(SmirnovTextBox.Text);
            double[] xNormal = new double[NormalBox.Items.Count],
                xFunc = new double[FunctionBox.Items.Count];
            for (int i = 0; i < NormalBox.Items.Count; i++)
                xNormal[i] = Convert.ToDouble(NormalBox.Items[i]);
            for (int i = 0; i < FunctionBox.Items.Count; i++)
                xFunc[i] = Convert.ToDouble(FunctionBox.Items[i]);

            Classes.SmirnovCriterion smirnovCriterion = new Classes.SmirnovCriterion(xNormal, xFunc);

            if (smirnovCriterion.CheckingAgreement(densityNormal, densityFunc, criterion))
                MessageBox.Show("Выборки однородны");
            else
                MessageBox.Show("Выборки не однородны");
        }
    }
}
