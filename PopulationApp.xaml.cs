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

namespace Lab1_DesktopAppDev
{
    /// <summary>
    /// Interaction logic for PopulationApp.xaml
    /// </summary>
    public partial class PopulationApp : Window
    {
        public PopulationApp()
        {
            InitializeComponent();
        }

        
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mv = new MainWindow();
            mv.Show();
            this.Close();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            PopulationSize ps = new PopulationSize();
            ps.setStartSize(int.Parse(sizeBox.Text));
            ps.setDailyIncrease(int.Parse(increaseBox.Text));
            ps.setNumberDays(int.Parse(numberDaysBox.Text));

            resultLabel.Content = ps.showDailyPopulationSize();
        }
    }
}
