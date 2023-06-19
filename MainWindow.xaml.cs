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

namespace Lab1_DesktopAppDev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, RoutedEventArgs e)
        {


            if (bankAppRadio.IsChecked == true)
            {
                //BankCharges bc = new BankCharges();
                BankApp ba = new BankApp();
                ba.Show();
                messageLable.Content = "Done";
                this.Close();

            }
            else if (shippingRadio.IsChecked == true)
            {

                ShippingApp sa = new ShippingApp();
                sa.Show();
                messageLable.Content = "Done";
                this.Close();
            }
            else if (populationRadio.IsChecked == true)
            {

                PopulationApp pa = new PopulationApp();
                pa.Show();
                messageLable.Content = "Done";
                this.Close();
            }
        }
    }

  
}
