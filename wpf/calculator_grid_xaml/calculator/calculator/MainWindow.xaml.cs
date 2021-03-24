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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator calc;
        private bool ResetScreen = false;
        public MainWindow()
        {
            InitializeComponent();
            this.calc = new Calculator();
        //    ResultLbl.Content = "1";
        }

        private void Operation (char type)
        {
            double result = calc.calculate(Convert.ToDouble(ResultLbl.Content), type);
            ResultLbl.Content = result.ToString();
            ResetScreen = true;
        }
        private void AddContentToScreen(int number)
        {
            if (ResultLbl.Content.ToString() == "0") ResultLbl.Content = "";
            if (ResetScreen) ResultLbl.Content = "";
            ResetScreen = false;
            ResultLbl.Content += number.ToString();
        }
        private void AcBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultLbl.Content = "0";
        }

        private void SignBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void PercentageBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DivisionBtn_Click(object sender, RoutedEventArgs e)
        {
            Operation(((Button)sender).Content.ToString()[0]);
        }

        private void SevenBtn_Click(object sender, RoutedEventArgs e)
        {
            AddContentToScreen(Convert.ToInt16((sender as Button).Content));
        }

        private void EigthBtn_Click(object sender, RoutedEventArgs e)
        {
            AddContentToScreen(Convert.ToInt16((sender as Button).Content));
        }

        private void NineBtn_Click(object sender, RoutedEventArgs e)
        {
            AddContentToScreen(Convert.ToInt16((sender as Button).Content));
        }

        private void MultiplicationBtn_Click(object sender, RoutedEventArgs e)
        {
            Operation(((Button)sender).Content.ToString()[0]);
        }

        private void FourBtn_Click(object sender, RoutedEventArgs e)
        {
            AddContentToScreen(Convert.ToInt16((sender as Button).Content));
        }

        private void FiveBtn_Click(object sender, RoutedEventArgs e)
        {
            AddContentToScreen(Convert.ToInt16((sender as Button).Content));
        }

        private void SixBtn_Click(object sender, RoutedEventArgs e)
        {
            AddContentToScreen(Convert.ToInt16((sender as Button).Content));
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            Operation(((Button)sender).Content.ToString()[0]);
        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            AddContentToScreen(Convert.ToInt16((sender as Button).Content));
        }

        private void TwoBtn_Click(object sender, RoutedEventArgs e)
        {
            AddContentToScreen(Convert.ToInt16((sender as Button).Content));
        }

        private void ThreeBtn_Click(object sender, RoutedEventArgs e)
        {
            AddContentToScreen(Convert.ToInt16((sender as Button).Content));
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            Operation(((Button)sender).Content.ToString()[0]);
        }

        private void ZeroBtn_Click(object sender, RoutedEventArgs e)
        {
            AddContentToScreen(Convert.ToInt16((sender as Button).Content));
        }

        private void DotBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            Operation(((Button)sender).Content.ToString()[0]);
        }
    }
}
