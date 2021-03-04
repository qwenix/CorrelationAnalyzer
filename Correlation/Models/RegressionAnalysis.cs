using Correlation.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using DataManipulator = Correlation.Data.DataManipulator;

namespace Correlation.Models {
    public class RegressionAnalysis : IAppModel {
        private const string COLUMNS_DATA = "vote_average";
        private const string ROWS_DATA = "runtime";

        private CrossTable<double> _dataTable;

        public RegressionAnalysis(MainForm view) {
            View = view;
            View.Model = this;

            _dataTable = new CrossTable<double>();

            CreateDataTable();
            SetCorrelationSpecifications();
            HandleResidues();

            view.Draw();
        }

        public MainForm View { get; set; }

        #region Regression specifications

        /// <summary>
        /// X and Y data
        /// </summary>
        public double[] XData {
            get {
                return _dataTable.RowHeaders
                    .Select(h => Convert.ToDouble(h))
                    .ToArray();
            }
        }

        public double[] YData {
            get {
                double[] arr = new double[_dataTable.Height];

                for (int i = 0; i < _dataTable.Height; i++) {
                    int counter = 0;
                    for (int j = 0; j < _dataTable.Width; j++) {
                        //counter += _dataTable[i, j];
                        arr[i] += _dataTable[i, j] * Convert.ToDouble(_dataTable.ColumnHeaders[j]);
                    }
                    arr[i] /= counter;
                }
                return arr;
            }
        }

        public List<double>[] XYData {
            get {
                List<double> XAxis = new List<double>();
                List<double> YAxis = new List<double>();

                for (int i = 0; i < _dataTable.Height; i++) {
                    for (int j = 0; j < _dataTable.Width; j++) {
                        if (_dataTable[i, j] != 0) {
                            XAxis.Add(Convert.ToDouble(_dataTable.ColumnHeaders[j]));
                            YAxis.Add(Convert.ToDouble(_dataTable.RowHeaders[i]));
                        }
                    }
                }

                return new List<double>[] { XAxis, YAxis };
            }
        }

        /// <summary>
        /// Freedom degrees
        /// </summary>
        public int FreedomDegree {
            get {
                return _dataTable.Width *_dataTable.Height - 2;
            }
        }

        public double StudentFactRatio {
            get {
                return CorRatio * Math.Sqrt(FreedomDegree) / 
                    Math.Sqrt(1 - Math.Pow(CorRatio, 2));
            }
        }

        public double StudentCritRatio {
            get {
                return 1.96;
                // TO DO
            }
        }

        /// <summary>
        /// Expectations
        /// </summary>
        public double XMu { get; private set; }
        public double YMu { get; private set; }
        public double SqrXMu { get; private set; }
        public double SqrYMu { get; private set; }
        public double XYMu { get; private set; }

        /// <summary>
        /// Variances and deviations
        /// </summary>
        public double XVar { get; private set; }
        public double YVar { get; private set; }
        public double XDev { get => Math.Sqrt(XVar); }
        public double YDev { get => Math.Sqrt(YVar); }

        /// <summary>
        /// Covariation, correlation and determination ratios
        /// </summary>
        public double CovRatio { get; private set; }
        public double CorRatio { get; private set; }
        public double DetRatio { get => Math.Pow(CorRatio, 2); }

        /// <summary>
        /// Correlation info
        /// </summary>
        public string[] CorInfo {
            get {
                string[] info = new string[2];
                info[0] = "слабкий";
                info[1] = "позитивний";

                double abs = Math.Abs(CorRatio);

                if (CorRatio < 0)
                    info[1] = "негативний";
                if (abs > 0.3 && abs <= 0.5)
                    info[0] = "помірний";
                else if (abs > 0.5 && abs <= 0.7)
                    info[0] = "помітний";
                else if (abs > 0.7 && abs <= 0.9)
                    info[0] = "досить тісний";
                else if (abs > 0.9 && abs <= 0.99)
                    info[0] = "надто тісний";

                return info;
            }
        }

        /// <summary>
        /// Regression equation specifications
        /// </summary>
        public double REqB { get => CorRatio * YDev / XDev; }
        public double REqA { get => YMu - REqB * XMu; }
        public double REqBInvers { get => CorRatio * XDev / YDev; }
        public double REqAInvers { get => XMu - REqBInvers * YMu; }

        public double Equation(double x) => REqB * x + REqA;
        public double InverseEquation(double y) => REqAInvers + REqBInvers * y;

        /// <summary>
        /// Residues of regression analysis.
        /// </summary>
        public Dictionary<double, int> ResiduesFreq { get; private set; }
        public double RMu { get; set; }

        #endregion

        private void CreateDataTable() {
            IEnumerable<DataRow> full = DataManipulator
                .GetDataTable(DataPaths.MOVIES_DATA_PATH)
                .AsEnumerable();

            // Data headers.
            foreach (var row in full) {
                bool flag = true; 

                string rowData = row[ROWS_DATA]?.ToIntString();
                string colData = row[COLUMNS_DATA]?.ToIntString();

                if (!string.IsNullOrEmpty(rowData) && rowData != "0") {
                    int runtime = Convert.ToInt32(rowData);
                    _dataTable.RowHeaders.Add(runtime.ToString());
                    _dataTable.Total++;
                    flag = false;
                }
                if (!string.IsNullOrEmpty(colData) && colData != "0") {
                    //int runtime = Convert.ToInt32(colData).RoundToDecimal();
                    _dataTable.ColumnHeaders.Add(colData);
                    if (flag)
                        _dataTable.Total++;
                }
            }
            // Initialize table.
            _dataTable.Initialize();

            // Fill table data
            for (int i = 0; i < _dataTable.Height; i++) {
                for (int j = 0; j < _dataTable.Width; j++) {
                    _dataTable[i, j] = full.Where(e => {
                        string colData = e[COLUMNS_DATA]?.ToIntString();
                        string rowData = e[ROWS_DATA]?.ToIntString();
                        if (!string.IsNullOrEmpty(colData) && !string.IsNullOrEmpty(rowData) &&
                        rowData != "0" && colData != "0") {
                            //return Convert.ToInt32(colData).RoundToDecimal().ToString() ==
                            //    _dataTable.ColumnHeaders[j] && rowData == _dataTable.RowHeaders[i];                            
                            return Convert.ToInt32(rowData).ToString() == _dataTable.RowHeaders[i] && 
                                colData == _dataTable.ColumnHeaders[j];
                        }
                        return false;
                        })
                        .Count();
                    _dataTable[i, j] = _dataTable[i, j] / _dataTable.Total;
                }
            }
        }

        private void SetCorrelationSpecifications() {
            for (int i = 0; i < _dataTable.Height; i++) {
                double r = Convert.ToDouble(_dataTable.RowHeaders[i]);
                for (int j = 0; j < _dataTable.Width; j++) {
                    double n = _dataTable[i, j];
                    double c = Convert.ToDouble(_dataTable.ColumnHeaders[j]);

                    // Count expectation.
                    XMu +=  c * n;
                    SqrXMu += c * c * n;
                    YMu +=  r * n;
                    SqrYMu += r * r * n;
                    XYMu += c * r * n;
                }
            }

            int total = _dataTable.Height * _dataTable.Width;

            // Count variances.
            XVar = SqrXMu - Math.Pow(XMu, 2);
            YVar = SqrYMu - Math.Pow(YMu, 2);

            // Count covariation and correlation.
            CovRatio = XYMu - XMu * YMu;
            CorRatio = CovRatio / (XDev * YDev);
        }

        private void HandleResidues() {
            ResiduesFreq = new Dictionary<double, int>();
            for (int i = 0; i < _dataTable.Height; i++) {
                for (int j = 0; j < _dataTable.Width; j++) {
                    if (_dataTable[i, j] != 0) {
                        double x = Convert.ToDouble(_dataTable.ColumnHeaders[j]);
                        double y = Convert.ToDouble(_dataTable.RowHeaders[i]);
                        double defY = Equation(x);

                        double delta = (defY - y).RoundToHalfDecimal();
                        int val = (int)(_dataTable[i, j] * _dataTable.Total);
                        RMu += val * (defY - y);

                        if (!ResiduesFreq.ContainsKey(delta))
                            ResiduesFreq.Add(delta, val);
                        else
                            ResiduesFreq[delta] += val;
                    }
                }
            }
            RMu /= _dataTable.Total;
        }
    }
}
