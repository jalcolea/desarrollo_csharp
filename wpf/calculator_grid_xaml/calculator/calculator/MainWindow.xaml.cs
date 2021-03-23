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
        public MainWindow()
        {
            InitializeComponent();
        //    ResultLbl.Content = "1";
        }

        private void AddContentToScreen(int number)
        {
            if (Convert.ToInt16(ResultLbl.Content) == 0) ResultLbl.Content = "";
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

        }
    }
}
