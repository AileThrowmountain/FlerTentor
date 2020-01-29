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

namespace RingTenta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listBoxQ.ItemsSource = null;
            listBoxQ.ItemsSource = program.GetQuestions();
        }
        Programme program = new Programme();

        private void buttonGissa_Click(object sender, RoutedEventArgs e)
        {
            labelNmbrP.Content = RightAnswer(textBoxSvar1.Text.ToUpper(), textBoxSvar2.Text);
        }

        public int RightAnswer(string answerNumberOne, string answerNumberTwo)
        {
            
            int points = 0;
            
            if (answerNumberOne == "ETNA" && answerNumberTwo == "3")
            {
                points = 3;
            }
            else if (answerNumberOne == "ETNA")
            {
                points = 1;
            }
            else if (answerNumberTwo == "3")
            {
                points = 1;
            }

            return points;

        }
    }
}
