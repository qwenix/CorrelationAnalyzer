namespace Correlation {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.regPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.corPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.corrNegConcl = new System.Windows.Forms.Label();
            this.corrPosConcl = new System.Windows.Forms.Label();
            this.corrInfo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.regConcl = new System.Windows.Forms.Label();
            this.openForm = new System.Windows.Forms.Button();
            this.regInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.regPlot)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corPlot)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // regPlot
            // 
            chartArea1.Name = "ChartArea1";
            this.regPlot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.regPlot.Legends.Add(legend1);
            this.regPlot.Location = new System.Drawing.Point(7, 6);
            this.regPlot.Name = "regPlot";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Black;
            series1.IsVisibleInLegend = false;
            series1.LabelBorderWidth = 5;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 4;
            series1.MarkerSize = 6;
            series1.Name = "Series1";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.regPlot.Series.Add(series1);
            this.regPlot.Series.Add(series2);
            this.regPlot.Size = new System.Drawing.Size(776, 587);
            this.regPlot.TabIndex = 0;
            this.regPlot.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Регресійний аналіз";
            title2.DockedToChartArea = "ChartArea1";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Title2";
            title2.Text = "Тривалість фільму";
            title3.DockedToChartArea = "ChartArea1";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.IsDockedInsideChartArea = false;
            title3.Name = "Title3";
            title3.Text = "Рейтинг фільму";
            this.regPlot.Titles.Add(title1);
            this.regPlot.Titles.Add(title2);
            this.regPlot.Titles.Add(title3);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1331, 621);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.corPlot);
            this.tabPage1.Controls.Add(this.corrNegConcl);
            this.tabPage1.Controls.Add(this.corrPosConcl);
            this.tabPage1.Controls.Add(this.corrInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1323, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кореляційний зв\'язок";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // corPlot
            // 
            chartArea2.Name = "ChartArea1";
            this.corPlot.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.corPlot.Legends.Add(legend2);
            this.corPlot.Location = new System.Drawing.Point(7, 6);
            this.corPlot.Name = "corPlot";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Black;
            series3.IsVisibleInLegend = false;
            series3.LabelBorderWidth = 5;
            series3.Legend = "Legend1";
            series3.MarkerBorderWidth = 4;
            series3.MarkerSize = 6;
            series3.Name = "Series1";
            series4.BorderWidth = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.corPlot.Series.Add(series3);
            this.corPlot.Series.Add(series4);
            this.corPlot.Size = new System.Drawing.Size(776, 587);
            this.corPlot.TabIndex = 3;
            this.corPlot.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "Title1";
            title4.Text = "Кореляція";
            title5.DockedToChartArea = "ChartArea1";
            title5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title5.IsDockedInsideChartArea = false;
            title5.Name = "Title2";
            title5.Text = "Тривалість фільму";
            title6.DockedToChartArea = "ChartArea1";
            title6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title6.IsDockedInsideChartArea = false;
            title6.Name = "Title3";
            title6.Text = "Рейтинг фільму";
            this.corPlot.Titles.Add(title4);
            this.corPlot.Titles.Add(title5);
            this.corPlot.Titles.Add(title6);
            // 
            // corrNegConcl
            // 
            this.corrNegConcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.corrNegConcl.Location = new System.Drawing.Point(827, 348);
            this.corrNegConcl.Name = "corrNegConcl";
            this.corrNegConcl.Size = new System.Drawing.Size(479, 203);
            this.corrNegConcl.TabIndex = 2;
            this.corrNegConcl.Text = resources.GetString("corrNegConcl.Text");
            this.corrNegConcl.Visible = false;
            // 
            // corrPosConcl
            // 
            this.corrPosConcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.corrPosConcl.Location = new System.Drawing.Point(832, 348);
            this.corrPosConcl.Name = "corrPosConcl";
            this.corrPosConcl.Size = new System.Drawing.Size(474, 203);
            this.corrPosConcl.TabIndex = 1;
            this.corrPosConcl.Text = resources.GetString("corrPosConcl.Text");
            // 
            // corrInfo
            // 
            this.corrInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.corrInfo.Location = new System.Drawing.Point(827, 31);
            this.corrInfo.Name = "corrInfo";
            this.corrInfo.Size = new System.Drawing.Size(479, 317);
            this.corrInfo.TabIndex = 0;
            this.corrInfo.Text = resources.GetString("corrInfo.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.regConcl);
            this.tabPage2.Controls.Add(this.regPlot);
            this.tabPage2.Controls.Add(this.openForm);
            this.tabPage2.Controls.Add(this.regInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1323, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регресійний аналіз";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // regConcl
            // 
            this.regConcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regConcl.Location = new System.Drawing.Point(827, 235);
            this.regConcl.Name = "regConcl";
            this.regConcl.Size = new System.Drawing.Size(490, 31);
            this.regConcl.TabIndex = 6;
            this.regConcl.Text = "Тобто в 66% випадків зміни ч призводять до зміни у, або ж зміна рейтингу фільма п" +
    "ризводить до зміни тривалості.";
            // 
            // openForm
            // 
            this.openForm.Location = new System.Drawing.Point(831, 278);
            this.openForm.Name = "openForm";
            this.openForm.Size = new System.Drawing.Size(220, 31);
            this.openForm.TabIndex = 5;
            this.openForm.Text = "Переглянути аналіз залишків";
            this.openForm.UseVisualStyleBackColor = true;
            this.openForm.Click += new System.EventHandler(this.OpenForm_Click);
            // 
            // regInfo
            // 
            this.regInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regInfo.Location = new System.Drawing.Point(827, 31);
            this.regInfo.Name = "regInfo";
            this.regInfo.Size = new System.Drawing.Size(479, 219);
            this.regInfo.TabIndex = 4;
            this.regInfo.Text = resources.GetString("regInfo.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 629);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Correlation";
            ((System.ComponentModel.ISupportInitialize)(this.regPlot)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.corPlot)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart regPlot;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label corrPosConcl;
        private System.Windows.Forms.Label corrInfo;
        private System.Windows.Forms.Label regInfo;
        private System.Windows.Forms.Button openForm;
        private System.Windows.Forms.Label corrNegConcl;
        private System.Windows.Forms.Label regConcl;
        private System.Windows.Forms.DataVisualization.Charting.Chart corPlot;
    }
}

