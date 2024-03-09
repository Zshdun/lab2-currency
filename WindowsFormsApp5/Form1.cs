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

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
        }

        private ChartArea chartArea;
        private Timer timer = new Timer();
        double cur1_rate;
        double cur2_rate;
        private int currentIndex = 0;
        const double k = 0.02;
        bool flag = true;
        private int daystotal;
        double maxcur1 = 0;
        double maxcur2 = 0;
        List<double> forecast1 = new List<double>();
        List<double> forecast2 = new List<double>();

        private void CreateForecast_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (flag)
            {
                cur1_rate = int.Parse(Currency1.Text);
                cur2_rate = int.Parse(Currency2.Text);
                flag = false;
            }
            int.TryParse(ForecastLength.Text, out int days);
            daystotal += days;

            for (int i = 0; i < days; i++)
            {
                forecast1.Add(cur1_rate);
                cur1_rate = cur1_rate * (1 + k * (rnd.NextDouble() - 0.5));
                forecast2.Add(cur2_rate);
                cur2_rate = cur2_rate * (1 + k * (rnd.NextDouble() - 0.5));
            }

            chartArea = chart1.ChartAreas[0];

            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = daystotal;
            chartArea.AxisX.Interval = (daystotal < 10) ? 1.0 : daystotal / 10.0; ;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = Math.Round(Math.Max(forecast1.Max(), forecast2.Max()));
            chartArea.AxisY.Interval = chartArea.AxisY.Maximum / 10;

            timer.Interval = 500 / days;
            timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            if (currentIndex < daystotal)
            {
                chart1.Series[0].Points.AddXY(currentIndex, forecast1[currentIndex]);
                chart1.Series[1].Points.AddXY(currentIndex, forecast2[currentIndex]);
                currentIndex++;
            }
            else
            {
                timer.Stop();
            }
        }
    
    }
}