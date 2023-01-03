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

namespace Lesson_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateE.Text);
            double sumEuro = Convert.ToDouble(sumE.Text);
            double resDouble = rateEuro * sumEuro;
            resSumE.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rateG.Text);
            double sumGrivna = Convert.ToDouble(sumG.Text);
            double resDouble = rateGrivna * sumGrivna;
            resSumG.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateADr = Convert.ToDouble(rateA.Text);
            double sumADr = Convert.ToDouble(sumA.Text);
            double resDouble = rateADr * sumADr;
            resSumA.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double lengthInch = Convert.ToDouble(inch.Text);         
            double resSumInchDouble = lengthInch * 0.0254;
            resSumInch.Text = resSumInchDouble.ToString();


        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double lengthFeet = Convert.ToDouble(feet.Text);
            double resSumFeetDouble = lengthFeet * 0.3048;
            resSumFeet.Text = resSumFeetDouble.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double lengthMile = Convert.ToDouble(mile.Text);
            double resSumMileDouble = lengthMile * 1609.34;
            resSumMile.Text = resSumMileDouble.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double lengthVerst = Convert.ToDouble(verst.Text);
            double resSumVerstDouble = lengthVerst * 1066.8;
            resSumVerst.Text = resSumVerstDouble.ToString();
        }
    }
}
