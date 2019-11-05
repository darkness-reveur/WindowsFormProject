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

namespace CourseWork
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myChart = chart.ChartAreas[0];
            myChart.AxisX.IntervalType = DateTimeIntervalType.Number;

            myChart.AxisX.LabelStyle.Format = "";
            myChart.AxisX.Minimum = 0;
            myChart.AxisX.Maximum = 10;
            myChart.AxisX.Interval = 1;

            myChart.AxisY.LabelStyle.Format = "";
            myChart.AxisY.Maximum = 500;

            Series newSeries = new Series();
            chart.Series.Add(newSeries);
            newSeries.ChartType = SeriesChartType.Spline;
            newSeries.IsVisibleInLegend = false;

            double step = 0, normalCalculationError = 0, friction = 0, angle = 0;

            bool isParsingDone = true;
            try
            {
                normalCalculationError = double.Parse(CalculationError.Text.Replace('.', ','));
                step = double.Parse(Step.Text.Replace('.', ','));
                friction = double.Parse(Friction.Text.Replace('.', ','));
                angle = double.Parse(Angle.Text.Replace('.', ','));
            }
            catch 
            {
                isParsingDone = false;
            }

            double radian = angle * Math.PI / 180;
            double startedExpression = 9.8 * (Math.Sin(radian) - (friction * Math.Cos(radian))) / 2;

            if (isParsingDone && startedExpression >= 0)
            {
                label4.Text = "Время";
                label5.Text = "Координата";
                double step3 = step / 3;
                double currentTimeValue = 0;
                double currentCoordinateValue = 0;

                double k1 = step3 * (startedExpression * Math.Pow(currentTimeValue, 2) - (currentCoordinateValue));
                double k2 = step3 * ((startedExpression * Math.Pow(currentTimeValue, 2) + step3) - (currentCoordinateValue + k1));
                double k3 = step * ((startedExpression * Math.Pow(currentTimeValue, 2) + step3) - (currentCoordinateValue + (k1 + k2) / 2));
                double k4 = k1 + step3 + ((startedExpression * Math.Pow(currentTimeValue, 2) + step / 2) - (currentCoordinateValue + 0.375 * (k1 + k3)));
                double k5 = step3 + ((startedExpression * Math.Pow(currentTimeValue, 2) + step) - (currentCoordinateValue + 1.5 * (k4 - k3)));

                currentCoordinateValue = currentCoordinateValue + (k4 + k5) / 2;
                currentTimeValue += step;

                while (currentTimeValue < 10)
                {
                    k1 = step3 * (startedExpression * Math.Pow(currentTimeValue, 2) - (currentCoordinateValue));
                    k2 = step3 * ((startedExpression * Math.Pow(currentTimeValue, 2) + step3) - (currentCoordinateValue + k1));
                    k3 = step * ((startedExpression * Math.Pow(currentTimeValue, 2) + step3) - (currentCoordinateValue + (k1 + k2) / 2));
                    k4 = k1 + step3 + ((startedExpression * Math.Pow(currentTimeValue, 2) + step / 2) - (currentCoordinateValue + 0.375 * (k1 + k3)));
                    k5 = step3 + ((startedExpression * Math.Pow(currentTimeValue, 2) + step) - (currentCoordinateValue + 1.5 * (k4 - k3)));

                    double colculationError = 0.1 * (2 * k4 - 3 * k3 - k5);

                    if (Math.Abs(colculationError) >= normalCalculationError)
                    {
                        step = step / 2;
                        currentTimeValue -= step;
                    }
                    else
                    {
                        currentCoordinateValue = currentCoordinateValue + (k4 + k5) / 2;
                        newSeries.Points.AddXY(currentTimeValue, currentCoordinateValue);

                        if (Math.Abs(colculationError) < normalCalculationError / 32)
                        {
                            step = step * 2;
                            currentTimeValue += step;
                        }
                        else
                        {
                            currentTimeValue += step;

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Проверьте корреутность введённых данных", "ОШИБКА БЛЯТЬ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
