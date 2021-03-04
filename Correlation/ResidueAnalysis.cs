using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correlation {
    public partial class ResidueAnalysis : Form {
        public ResidueAnalysis(MainForm main) {
            InitializeComponent();
            ConfigurateResiduesPlot();

            resMu.Text = $"Математичне очікування:\n{Math.Round(main.Model.RMu, 6)}";
            resPlot.Series["Series1"].Points.DataBindXY(
                main.Model.ResiduesFreq.Keys,
                main.Model.ResiduesFreq.Values);
        }

        private void ConfigurateResiduesPlot() {
            resPlot.ChartAreas[0].AxisX.Minimum = -100;
            resPlot.ChartAreas[0].AxisX.Maximum = 100;
            resPlot.ChartAreas[0].AxisX.Interval = 20;
        }
    }
}
