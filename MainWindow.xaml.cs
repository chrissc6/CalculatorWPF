using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        MyOperator myOp;

        public MainWindow()
        {
            InitializeComponent();

            resultLabel.Content = "0";

            acButton.Click += AcButton_Click;
            negButton.Click += NegButton_Click;
            percentButton.Click += PercentButton_Click;
            equalButton.Click += EqualButton_Click;
            pointButton.Click += PointButton_Click;
        }

        private void PointButton_Click(object sender, RoutedEventArgs e)
        {
            if(resultLabel.Content.ToString().Contains("."))
            {
                //
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}.";
            }
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double newNum;

            if (double.TryParse(resultLabel.Content.ToString(), out newNum))
            {
                switch (myOp)
                {
                    case MyOperator.Addition:
                        result = MyMath.Add(lastNumber, newNum);
                        break;
                    case MyOperator.Subtraction:
                        result = MyMath.Sub(lastNumber, newNum);
                        break;
                    case MyOperator.Multiplication:
                        result = MyMath.Mul(lastNumber, newNum);
                        break;
                    case MyOperator.Division:
                        result = MyMath.Div(lastNumber, newNum);
                        break;
                    default:
                        break;
                }

                resultLabel.Content = result.ToString();
            }
        }

        private void PercentButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void NegButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                resultLabel.Content = "0";
            }

            if (sender == addButton) myOp = MyOperator.Addition;
            if (sender == minusButton) myOp = MyOperator.Subtraction;
            if (sender == mulButton) myOp = MyOperator.Multiplication;
            if (sender == divButton) myOp = MyOperator.Division;
        }

        private void NumButton_Click(object sender, RoutedEventArgs e)
        {
            int value = 0;

            if (sender == zeroButton) value = 0;
            if (sender == oneButton) value = 1;
            if (sender == twoButton) value = 2;
            if (sender == threeButton) value = 3;
            if (sender == fourButton) value = 4;
            if (sender == fiveButton) value = 5;
            if (sender == sixButton) value = 6;
            if (sender == sevenButton) value = 7;
            if (sender == eightButton) value = 8;
            if (sender == nineButton) value = 9;

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = value;
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{value}";
            }
        }
    }

    public enum MyOperator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

    public class MyMath
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Sub(double x, double y)
        {
            return x - y;
        }

        public static double Mul(double x, double y)
        {
            return x * y;
        }

        public static double Div(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                MessageBox.Show("Divided by zero", "Lol", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return x / y;
        }
    }
}
