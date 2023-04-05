
namespace CSharpModelingLab1
{
    partial class Modeling
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.NormalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FunctionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NormalBox = new System.Windows.Forms.ListBox();
            this.FunctionBox = new System.Windows.Forms.ListBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.squarDeviationLabel = new System.Windows.Forms.Label();
            this.expectationLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.squarDeviationTextBox = new System.Windows.Forms.TextBox();
            this.expectationTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.leftBoardLabel = new System.Windows.Forms.Label();
            this.rightBoardLabel = new System.Windows.Forms.Label();
            this.LeftBoardTextBox = new System.Windows.Forms.TextBox();
            this.RightBoardTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NormalChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // NormalChart
            // 
            chartArea1.Name = "ChartArea1";
            this.NormalChart.ChartAreas.Add(chartArea1);
            this.NormalChart.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.NormalChart.Legends.Add(legend1);
            this.NormalChart.Location = new System.Drawing.Point(467, 12);
            this.NormalChart.Name = "NormalChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.NormalChart.Series.Add(series1);
            this.NormalChart.Size = new System.Drawing.Size(321, 196);
            this.NormalChart.TabIndex = 0;
            this.NormalChart.Text = "NormalChart";
            // 
            // FunctionChart
            // 
            chartArea2.Name = "ChartArea1";
            this.FunctionChart.ChartAreas.Add(chartArea2);
            this.FunctionChart.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.Name = "Legend1";
            this.FunctionChart.Legends.Add(legend2);
            this.FunctionChart.Location = new System.Drawing.Point(467, 214);
            this.FunctionChart.Name = "FunctionChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.FunctionChart.Series.Add(series2);
            this.FunctionChart.Size = new System.Drawing.Size(321, 196);
            this.FunctionChart.TabIndex = 1;
            this.FunctionChart.Text = "FunctionChart";
            // 
            // NormalBox
            // 
            this.NormalBox.FormattingEnabled = true;
            this.NormalBox.Location = new System.Drawing.Point(12, 12);
            this.NormalBox.Name = "NormalBox";
            this.NormalBox.Size = new System.Drawing.Size(217, 251);
            this.NormalBox.TabIndex = 2;
            // 
            // FunctionBox
            // 
            this.FunctionBox.FormattingEnabled = true;
            this.FunctionBox.Location = new System.Drawing.Point(244, 12);
            this.FunctionBox.Name = "FunctionBox";
            this.FunctionBox.Size = new System.Drawing.Size(217, 251);
            this.FunctionBox.TabIndex = 3;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(37, 398);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(132, 23);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Сгенерировать числа";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // squarDeviationLabel
            // 
            this.squarDeviationLabel.AutoSize = true;
            this.squarDeviationLabel.Location = new System.Drawing.Point(10, 279);
            this.squarDeviationLabel.Name = "squarDeviationLabel";
            this.squarDeviationLabel.Size = new System.Drawing.Size(94, 13);
            this.squarDeviationLabel.TabIndex = 5;
            this.squarDeviationLabel.Text = "Сред. квад. откл.";
            // 
            // expectationLabel
            // 
            this.expectationLabel.AutoSize = true;
            this.expectationLabel.Location = new System.Drawing.Point(10, 304);
            this.expectationLabel.Name = "expectationLabel";
            this.expectationLabel.Size = new System.Drawing.Size(77, 13);
            this.expectationLabel.TabIndex = 6;
            this.expectationLabel.Text = "Матожидание";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(10, 327);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(66, 13);
            this.countLabel.TabIndex = 7;
            this.countLabel.Text = "Количество";
            // 
            // squarDeviationTextBox
            // 
            this.squarDeviationTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.squarDeviationTextBox.Location = new System.Drawing.Point(110, 276);
            this.squarDeviationTextBox.Name = "squarDeviationTextBox";
            this.squarDeviationTextBox.Size = new System.Drawing.Size(186, 20);
            this.squarDeviationTextBox.TabIndex = 8;
            // 
            // expectationTextBox
            // 
            this.expectationTextBox.Location = new System.Drawing.Point(110, 302);
            this.expectationTextBox.Name = "expectationTextBox";
            this.expectationTextBox.Size = new System.Drawing.Size(186, 20);
            this.expectationTextBox.TabIndex = 9;
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(110, 328);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(186, 20);
            this.countTextBox.TabIndex = 10;
            // 
            // leftBoardLabel
            // 
            this.leftBoardLabel.AutoSize = true;
            this.leftBoardLabel.Location = new System.Drawing.Point(13, 355);
            this.leftBoardLabel.Name = "leftBoardLabel";
            this.leftBoardLabel.Size = new System.Drawing.Size(83, 13);
            this.leftBoardLabel.TabIndex = 11;
            this.leftBoardLabel.Text = "Левая граница";
            // 
            // rightBoardLabel
            // 
            this.rightBoardLabel.AutoSize = true;
            this.rightBoardLabel.Location = new System.Drawing.Point(107, 355);
            this.rightBoardLabel.Name = "rightBoardLabel";
            this.rightBoardLabel.Size = new System.Drawing.Size(89, 13);
            this.rightBoardLabel.TabIndex = 12;
            this.rightBoardLabel.Text = "Правая граница";
            // 
            // LeftBoardTextBox
            // 
            this.LeftBoardTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LeftBoardTextBox.Location = new System.Drawing.Point(16, 372);
            this.LeftBoardTextBox.Name = "LeftBoardTextBox";
            this.LeftBoardTextBox.Size = new System.Drawing.Size(80, 20);
            this.LeftBoardTextBox.TabIndex = 13;
            // 
            // RightBoardTextBox
            // 
            this.RightBoardTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.RightBoardTextBox.Location = new System.Drawing.Point(110, 372);
            this.RightBoardTextBox.Name = "RightBoardTextBox";
            this.RightBoardTextBox.Size = new System.Drawing.Size(86, 20);
            this.RightBoardTextBox.TabIndex = 14;
            // 
            // Modeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.RightBoardTextBox);
            this.Controls.Add(this.LeftBoardTextBox);
            this.Controls.Add(this.rightBoardLabel);
            this.Controls.Add(this.leftBoardLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.expectationTextBox);
            this.Controls.Add(this.squarDeviationTextBox);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.expectationLabel);
            this.Controls.Add(this.squarDeviationLabel);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.FunctionBox);
            this.Controls.Add(this.NormalBox);
            this.Controls.Add(this.FunctionChart);
            this.Controls.Add(this.NormalChart);
            this.Name = "Modeling";
            this.Text = "Сравнение выборок";
            ((System.ComponentModel.ISupportInitialize)(this.NormalChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart NormalChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart FunctionChart;
        private System.Windows.Forms.ListBox NormalBox;
        private System.Windows.Forms.ListBox FunctionBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label squarDeviationLabel;
        private System.Windows.Forms.Label expectationLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox squarDeviationTextBox;
        private System.Windows.Forms.TextBox expectationTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Label leftBoardLabel;
        private System.Windows.Forms.Label rightBoardLabel;
        private System.Windows.Forms.TextBox LeftBoardTextBox;
        private System.Windows.Forms.TextBox RightBoardTextBox;
    }
}

