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

        public MainWindow()
        {
            InitializeComponent();

            resultLabel.Content = "0";

            acButton.Click += AcButton_Click;
            negButton.Click += NegButton_Click;
            percentButton.Click += PercentButton_Click;
            equalButton.Click += EqualButton_Click;
            divButton.Click += DivButton_Click;
            mulButton.Click += MulButton_Click;
            minusButton.Click += MinusButton_Click;
            addButton.Click += AddButton_Click;
            pointButton.Click += PointButton_Click;
        }

        

        private void PointButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MulButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void DivButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            
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
}
