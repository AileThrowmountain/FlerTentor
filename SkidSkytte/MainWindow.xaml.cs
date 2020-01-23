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

namespace SkidSkytte
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

        Deltagare deltagare = new Deltagare();
        
        List<Deltagare> competetors = new List<Deltagare>();
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Deltagare competetor = new Deltagare(textBoxFirstName.Text, textBoxLastName.Text);

            competetors.Add(competetor);
            GenereraStartNummer();

            listBoxCompetetors.ItemsSource = null;
            listBoxCompetetors.ItemsSource = competetors;

        }

        public int GenereraStartNummer()
        {
            int count = 0;
            foreach (Deltagare deltagare in competetors)
            {
                count++;
                deltagare.Number = count.ToString();
            }
            return count;
        }

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {

            

            if (RegistreraTräffar() == 0)
            {
                MessageBox.Show($"Åkaren fick ingen straffrunda!");
            }
            else if (RegistreraTräffar() > 1)
            {
                MessageBox.Show($"Åkaren fick {RegistreraTräffar()} straffrundor");
            }
            else
            {
                MessageBox.Show($"Åkaren fick {RegistreraTräffar()} straffrunda");
            }

            listBoxCompetetors.SelectedItem = AddResult(deltagare.Result);
            

        }

       






        public int RegistreraTräffar()
        {
            int[] skytte = new int[5];


            if (goal1.IsChecked == true)
            {

                skytte[0] = 1;
            }
            if (goal2.IsChecked == true)
            {

                skytte[1] = 1;
            }
            if (goal3.IsChecked == true)
            {

                skytte[2] = 1;
            }
            if (goal4.IsChecked == true)
            {

                skytte[3] = 1;
            }
            if (goal5.IsChecked == true)
            {

                skytte[4] = 1;
            }



            int counter = skytte[0] + skytte[1] + skytte[2] + skytte[3] + skytte[4];
            return counter;
        }
        public int[] AddResult(int[] result)
        {
            
            if (goal1.IsChecked == true)
            {
                result[0] = 1;
            }
            if (goal2.IsChecked == true)
            {
                result[1] = 1;
            }
            if (goal3.IsChecked == true)
            {
                result[2] = 1;
            }
            if (goal4.IsChecked == true)
            {
                result[3] = 1;
            }
            if (goal5.IsChecked == true)
            {
                result[4] = 1;
            }

            

            return result;
        }

        private void buttonLänder_Click(object sender, RoutedEventArgs e)
        {
            List<string> länder = new List<string>();
            länder.Add("Tyskland");
            länder.Add("Sverige");
            länder.Add("Belgien");
            länder.Add("Tyskland");
            länder.Add("Norge");
            länder.Add("Sverige");
            länder.Add("Norge");
            länder.Add("Sverige");
            länder.Add("Tyskland");
            länder.Add("Tyskland");
            länder.Add("Norge");
            länder.Add("Sverige");
            länder.Add("Norge");
            länder.Add("Norge");

                int tyskland = 0;
                int sverige = 0;
                int belgien = 0;
                int norge = 0;

            foreach (var item in länder)
            {
                if (item == "Tyskland")
                {
                    tyskland++;
                }
                if (item == "Sverige")
                {
                    sverige++;
                }
                if (item == "Belgien")
                {
                    belgien++;
                }
                if (item == "Norge")
                {
                    norge++;
                }


            }
            MessageBox.Show($"Tyskland\t{tyskland} st\nSverige\t{sverige} st\nBelgien\t{belgien} st\nNorge\t{norge} st");
        }
    }
}
