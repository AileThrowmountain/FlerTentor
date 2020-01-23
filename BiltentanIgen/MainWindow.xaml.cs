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

        public bool HasCorrectLength(string regNr)
        {
           if(regNr.Length == 7)
            {
                return true;
            }
            return false;
        }

        private void buttonLangd_Click(object sender, RoutedEventArgs e)
        {
            if (HasCorrectLength(textBoxLangd.Text) == false)
            {
                MessageBox.Show("Skylten har ett felaktigt antal tecken.");
            }
            

        }
        
        private void buttonPlatespotting_Click(object sender, RoutedEventArgs e)
        {
            labelPlateGenerator.Content = ($"{GetRandomLetters()} {GetRandomNumber()}");

             


        }
        private static string GetRandomLetters()
        {
            Random r = new Random();
            string okLetters = "ABCDEFGHJKLMNPRSTUWXYX";
            string letters = "";
            for (int i = 0; i < 3; i++)
            {
                int index = r.Next(okLetters.Length);
                letters += okLetters[index].ToString();
            }
            return letters;
        }
        private static int GetRandomNumber()
        {

            Random n = new Random();
            int randomNumbers = n.Next(1000);
  
  
            return randomNumbers;
        }

    }
}
