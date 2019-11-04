using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian = 55 * Math.PI / 180;
            double startedExpression = 9.8 * (Math.Sin(radian) - (0.6 * Math.Cos(radian))) / 2;
            Console.WriteLine("Введите, пожалуйста, первый шаг, который выполнит программа" +
                "\nШаг не может быть отрицательным, или равным нулю");
            if (double.TryParse(Console.ReadLine(), out double step) && step <= 1)
            {
                Console.WriteLine("Введите максимально возможную погрешность");
                double step3 = step / 3;
                if (double.TryParse(Console.ReadLine(), out double normalColculationError) && normalColculationError <= 1)
                {
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

                        if (Math.Abs(colculationError) >= normalColculationError)
                        {
                            step = step / 2;
                            currentTimeValue -= step;
                        }
                        else
                        {
                            currentCoordinateValue = currentCoordinateValue + (k4 + k5) / 2;
                            Console.WriteLine($"для времени - {currentTimeValue}с \t|\t координата - {currentCoordinateValue}");
                            if (Math.Abs(colculationError) < normalColculationError / 32)
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
            }
        }
    }
}
