using Correlation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Correlation.Data;
using DataManipulator = Correlation.Data.DataManipulator;

namespace Correlation {
    public partial class MainForm : Form, IAppView {
        public MainForm() {
            InitializeComponent();
        }

        public RegressionAnalysis Model { get; set; }

        public void Draw() {
            #region Plots configuration

            // Regression plot.
            regPlot.ChartAreas[0].AxisX.Minimum = 0;
            regPlot.ChartAreas[0].AxisY.Minimum = 0;

            regPlot.ChartAreas[0].AxisX.Maximum = 10;
            regPlot.ChartAreas[0].AxisY.Maximum = 240;

            regPlot.ChartAreas[0].AxisX.Interval = 1;
            regPlot.ChartAreas[0].AxisY.Interval = 30;

            // Correlation plot.
            corPlot.ChartAreas[0].AxisX.Minimum = 0;
            corPlot.ChartAreas[0].AxisY.Minimum = 0;

            corPlot.ChartAreas[0].AxisX.Maximum = 10;
            corPlot.ChartAreas[0].AxisY.Maximum = 240;

            corPlot.ChartAreas[0].AxisX.Interval = 1;
            corPlot.ChartAreas[0].AxisY.Interval = 30;

            // Regression analysis and correlation plots.
            regPlot.Series["Series1"].Points.DataBindXY(Model.XYData[0], Model.XYData[1]);
            corPlot.Series["Series1"].Points.DataBindXY(Model.XYData[0], Model.XYData[1]);
            
            // Trend line.
            regPlot.Series["Series2"].Points.DataBindXY(new double[] { 2, 9 },
                new double[] { Model.Equation(2), Model.Equation(9) });

            #endregion
            #region Fill correlation tab

            StringBuilder sb = new StringBuilder();
            sb.Append($"Коефіцієнт коваріації:  {Model.CovRatio}\n");
            sb.Append($"Коефіцієнт кореляції:  {Model.CorRatio}\n");
            sb.Append($"Кореляційний зв'язок: {Model.CorInfo[1]}, {Model.CorInfo[0]}\n\n");
            sb.Append($"Перевіряємо гіпотезу про наявність лінійного кореляційного зв'язку:\n\n");
            sb.Append($"Розподіл Стьюдента з k = {Model.FreedomDegree + 2} - 2 = {Model.FreedomDegree} ступенями свободи та рівнем значущості 0.05:\n");
            sb.Append($"t(спост) = {Model.StudentFactRatio}\n\n");
            sb.Append($"Критеріальне значення розподілу Стьюдента:\n");
            sb.Append($"t(кр) = {Model.StudentCritRatio}");

            corrInfo.Text = sb.ToString();

            if (Model.StudentFactRatio > Model.StudentCritRatio) {
                corrPosConcl.Visible = true;
                corrNegConcl.Visible = false;
            }
            else {
                corrPosConcl.Visible = false;
                corrNegConcl.Visible = true;
            }

            #endregion
            #region Fill regression tab

            sb = new StringBuilder();
            sb.Append($"Коефіцієнт коваріації:  {Model.CovRatio}\n");
            sb.Append($"Коефіцієнт кореляції:  {Model.CorRatio}\n");
            sb.Append($"Кореляційний зв'язок: {Model.CorInfo[1]}, {Model.CorInfo[0]}\n\n");
            sb.Append($"Пряме рівняння регресії:\n");
            sb.Append($"y = {Math.Round(Model.REqA, 4)}x + {Math.Round(Model.REqB, 4)}\n\n");
            sb.Append($"Коефіцієнт детермінації:\n");
            sb.Append($"R ^ 2 = {Model.CorRatio} ^ 2 = {Model.DetRatio}\n");

            regInfo.Text = sb.ToString();
            regConcl.Text = $"Тобто в {Math.Round(Model.DetRatio * 100, 2)}% випадків зміни Х призводять до зміни Y";

            #endregion
        }

        public void ShowMessage() {
            throw new NotImplementedException();
        }

        private void OpenForm_Click(object sender, EventArgs e) {
            ResidueAnalysis ra = new ResidueAnalysis(this);
            ra.Show();
        }
    }
}
