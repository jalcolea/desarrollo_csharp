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
using System.Globalization;
using System.Threading;

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
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
            InitializeComponent();
            this.calc = new Calculator();

        }

        private void Operation (char type)
        {
            double result = calc.calculate(Convert.ToDouble(ResultLbl.Content), type);
            ResultLbl.Content = result.ToString();
            ResetScreen = true;
        }

        private void ChangeSignScreen()
        {
            Double tmp;
            if (Double.TryParse(ResultLbl.Content.ToString(), out tmp))
            {
                tmp *= -1;
                ResultLbl.Content = tmp.ToString();
            }
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
            calc.reset();
        }

        private void SignBtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeSignScreen();
        }

        private void PercentageBtn_Click(object sender, RoutedEventArgs e)
        {
            Operation(((Button)sender).Content.ToString()[0]);
        }

        private void DivisionBtn_Click(object sender, RoutedEventArgs e)
        {
            Operation(((Button)sender).Content.ToString()[0]);
        }

        private void NumberBtn_Click(object sender, RoutedEventArgs e)
        {
            AddContentToScreen(Convert.ToInt16((sender as Button).Content));
        }

        private void MultiplicationBtn_Click(object sender, RoutedEventArgs e)
        {
            Operation(((Button)sender).Content.ToString()[0]);
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            Operation(((Button)sender).Content.ToString()[0]);
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
            String content = ResultLbl.Content.ToString();
            if (!content.Contains("."))
            {
                ResultLbl.Content += ".";
            }
            else if (content[content.Length-1]=='.')
            {
               ResultLbl.Content = content.Substring(0, content.Length - 1);
            }
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            Operation(((Button)sender).Content.ToString()[0]);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D0:
                    this.NumberBtn_Click(this.ZeroBtn, new RoutedEventArgs());
                    break;
                case Key.D1:
                    this.NumberBtn_Click(this.OneBtn, new RoutedEventArgs());
                    break;
                case Key.D2:
                    this.NumberBtn_Click(this.TwoBtn, new RoutedEventArgs());
                    break;
                case Key.D3:
                    this.NumberBtn_Click(this.ThreeBtn, new RoutedEventArgs());
                    break;
                case Key.D4:
                    this.NumberBtn_Click(this.FourBtn, new RoutedEventArgs());
                    break;
                case Key.D5:
                    this.NumberBtn_Click(this.FiveBtn, new RoutedEventArgs());
                    break;
                case Key.D6:
                    this.NumberBtn_Click(this.SixBtn, new RoutedEventArgs());
                    break;
                case Key.D7:
                    this.NumberBtn_Click(this.SevenBtn, new RoutedEventArgs());
                    break;
                case Key.D8:
                    this.NumberBtn_Click(this.EigthBtn, new RoutedEventArgs());
                    break;
                case Key.D9:
                    this.NumberBtn_Click(this.NineBtn, new RoutedEventArgs());
                    break;
            }

        }
    }
}
