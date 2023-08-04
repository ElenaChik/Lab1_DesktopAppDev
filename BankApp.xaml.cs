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
    /// Interaction logic for BankApp.xaml
    /// </summary>
    public partial class BankApp : Window
    {
        public BankApp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BankCharges bc = new BankCharges();
            double b = double.Parse(balanceBox.Text);
            int v = int.Parse(checksNumberBox.Text);
            bc.setBalance(b);
            bc.setChecksCounter(v); 
            messageLabel.Content = bc.getMonthServiceFee() + "$";
            bc.setNewBalance();
            newBalanceRezultLabel.Content = bc.getBalance() + "$";
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mv = new MainWindow();
            mv.Show();
            this.Close();
        }
    }
}
