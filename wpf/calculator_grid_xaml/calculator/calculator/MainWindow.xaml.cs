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
using System.Diagnostics;

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private Dictionary<Key, Button> KeyButton;

        private Calculator calc;
        private bool ResetScreen = false;
        public MainWindow()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
            InitializeComponent();
            this.calc = new Calculator();

        KeyButton = new Dictionary<Key, Button>()
        {
            {Key.D0,this.ZeroBtn},
            {Key.D1,this.OneBtn},
            {Key.D2,this.TwoBtn},
            {Key.D3,this.ThreeBtn},
            {Key.D4,this.FourBtn},
            {Key.D5,this.FiveBtn},
            {Key.D6,this.SixBtn},
            {Key.D7,this.SevenBtn},
            {Key.D8,this.EigthBtn},
            {Key.D9,this.NineBtn}
        };

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
            Debug.WriteLine(e.Key.ToString());
            if (KeyButton.ContainsKey(e.Key))
            {
                this.NumberBtn_Click(KeyButton[e.Key], new RoutedEventArgs());
            }
/*
            else
            {
                switch (e.Key)
                {
                    case Key.OemPlus:
                        this.PlusBtn_Click(null, null);
                        break;
                    case Key.OemMinus:
                        this.MinusBtn_Click(null, null);
                        break;
                }
            }
*/
            //{Key.Divide,this.DivisionBtn},
            //{Key.Multiply,this.MultiplicationBtn},
            //TODO: ver la manera de detectar mays divide o mays mult
//            { Key.OemPlus,this.PlusBtn},
//            { Key.OemMinus,this.MinusBtn}
        }
    }
}
