namespace ShapeChecker
{
    partial class Display
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StatusProgramm = new System.Windows.Forms.Label();
            this.Graphips = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Graphips)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusProgramm
            // 
            this.StatusProgramm.AutoSize = true;
            this.StatusProgramm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusProgramm.Location = new System.Drawing.Point(12, 588);
            this.StatusProgramm.Name = "StatusProgramm";
            this.StatusProgramm.Size = new System.Drawing.Size(121, 25);
            this.StatusProgramm.TabIndex = 1;
            this.StatusProgramm.Text = "Результат:";
            // 
            // Graphips
            // 
            this.Graphips.CausesValidation = false;
            chartArea1.Name = "ChartArea1";
            this.Graphips.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graphips.Legends.Add(legend1);
            this.Graphips.Location = new System.Drawing.Point(0, -1);
            this.Graphips.Name = "Graphips";
            this.Graphips.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Lines";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Points";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.ForestGreen;
            series3.MarkerSize = 10;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "TargetPoint";
            this.Graphips.Series.Add(series1);
            this.Graphips.Series.Add(series2);
            this.Graphips.Series.Add(series3);
            this.Graphips.Size = new System.Drawing.Size(1273, 586);
            this.Graphips.TabIndex = 2;
            this.Graphips.Text = "chart1";
            this.Graphips.Enter += new System.EventHandler(this.Graphips_Enter);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1272, 622);
            this.Controls.Add(this.Graphips);
            this.Controls.Add(this.StatusProgramm);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1288, 661);
            this.MinimumSize = new System.Drawing.Size(1288, 661);
            this.Name = "Display";
            this.Text = "ShapeChecker";
            this.Load += new System.EventHandler(this.Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Graphips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label StatusProgramm;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graphips;
    }
}

