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
using System.Windows.Shapes;

namespace Lab_Desktop.View
{
    /// <summary>
    /// Interaction logic for ShippingApp.xaml
    /// </summary>
    public partial class ShippingApp : Window
    {
        public ShippingApp()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mv = new MainWindow();
            mv.Show();
            this.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShippingCharge sh = new ShippingCharge();
            double w = double.Parse(weightBox.Text);
            sh.setWeight(w);
            sh.setDistance(double.Parse(distanceBox.Text));

            double charge = sh.calcCharge();

            chargeResultLabel.Content = charge;

        }
    }
}

    }
}
