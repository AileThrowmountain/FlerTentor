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

namespace BiltentanIgen
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

        private void buttonCalc_Click(object sender, RoutedEventArgs e)
        {
            int totalVikt = int.Parse(textBoxSlapVikt.Text);

            int slapviktB = 3500 - totalVikt;
            int slapviktBUtokad = 4250 - totalVikt;

            labelB.Content = ($"{slapviktB} kg");
            labelBUtokad.Content = ($"{slapviktBUtokad} kg");
        }
    }
}
