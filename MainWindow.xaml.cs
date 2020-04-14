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
            oneButton.Click += OneButton_Click;
            twoButton.Click += TwoButton_Click;
            threeButton.Click += ThreeButton_Click;
            fourButton.Click += FourButton_Click;
            fiveButton.Click += FiveButton_Click;
            sixButton.Click += SixButton_Click;
            //seven done
            eightButton.Click += EightButton_Click;
            nineButton.Click += NineButton_Click;
            zeroButton.Click += ZeroButton_Click;
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

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "7";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}7";
            }
        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FourButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
