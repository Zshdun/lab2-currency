namespace WindowsFormsApp5
{
    partial class Form1
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Currency2 = new System.Windows.Forms.TextBox();
            this.Currency1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ForecastLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateForecast = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(284, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Начальные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Курс 2 валюты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Курс 1 валюты";
            // 
            // Currency2
            // 
            this.Currency2.Location = new System.Drawing.Point(348, 44);
            this.Currency2.Name = "Currency2";
            this.Currency2.Size = new System.Drawing.Size(100, 20);
            this.Currency2.TabIndex = 20;
            // 
            // Currency1
            // 
            this.Currency1.Location = new System.Drawing.Point(116, 44);
            this.Currency1.Name = "Currency1";
            this.Currency1.Size = new System.Drawing.Size(100, 20);
            this.Currency1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Долгота прогноза";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ForecastLength
            // 
            this.ForecastLength.Location = new System.Drawing.Point(596, 44);
            this.ForecastLength.Name = "ForecastLength";
            this.ForecastLength.Size = new System.Drawing.Size(100, 20);
            this.ForecastLength.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(330, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Прогноз";
            // 
            // CreateForecast
            // 
            this.CreateForecast.Location = new System.Drawing.Point(483, 100);
            this.CreateForecast.Name = "CreateForecast";
            this.CreateForecast.Size = new System.Drawing.Size(75, 23);
            this.CreateForecast.TabIndex = 31;
            this.CreateForecast.Text = "Создать";
            this.CreateForecast.UseVisualStyleBackColor = true;
            this.CreateForecast.Click += new System.EventHandler(this.CreateForecast_Click);
            // 
            // chart1
            // 
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.AxisX.Title = "Время с начала прогноза (дни)";
            chartArea1.AxisY.Title = "Курс";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(93, 171);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Валюта1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Валюта2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(592, 300);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 668);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.CreateForecast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ForecastLength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Currency2);
            this.Controls.Add(this.Currency1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Currency2;
        private System.Windows.Forms.TextBox Currency1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ForecastLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateForecast;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

