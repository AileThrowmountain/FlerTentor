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

namespace ÖvningTenta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Broker realEstate = new Broker();
        public MainWindow()
        {
            InitializeComponent();
            listBoxRealEstate.ItemsSource = null;
            listBoxRealEstate.ItemsSource = realEstate.GetList();
        }

        private void btnBerakna_Click(object sender, RoutedEventArgs e)
        {
            
            int price = int.Parse(textBoxSlutPris.Text);
            string priceString = textBoxSlutPris.Text;
            
            
            if (priceString.Length <= 4)
            {
                price = price * 1000;

            }

            textBoxSlutPris.Text = ($"{price:C0} ");

            labelKrKvm.Content = ($"{BeräknaKvmPris(price):C0} kr/kvm");
        }

        public int BeräknaKvmPris(int price)
        {
            int size = 57;
            int priceKvm = price / size;
            return priceKvm;

        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            listBoxRealEstate.ItemsSource = null;
            listBoxRealEstate.ItemsSource = realEstate.GetSuitableRealEstate(int.Parse(textBoxMin.Text), int.Parse(textBoxMax.Text));
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            RealEstate newRealEstate = new RealEstate()
            { Address = textBoxAdress.Text, 
              Rooms = int.Parse(textBoxRum.Text),
              Area = int.Parse(textBoxArea.Text)
            };
            realEstate.AddRealEstate(newRealEstate);
            listBoxRealEstate.ItemsSource = null;
            listBoxRealEstate.ItemsSource = realEstate.GetList();
        }
    }
}
