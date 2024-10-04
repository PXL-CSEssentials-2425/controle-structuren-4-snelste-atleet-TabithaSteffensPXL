using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace snelste_atleet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nameFastest;
        int secondsFastest = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void newButton_Click(object sender, RoutedEventArgs e)
        { 
            bool isValidNumber = int.TryParse(timeTextBox.Text, out int secondsCurrent);

            if (isValidNumber)
            {
                if (secondsFastest == 0 ||secondsCurrent < secondsFastest)
                {
                    secondsFastest = secondsCurrent;
                    nameFastest = nameTextBox.Text;
                }
            }

            nameTextBox.Clear();
            timeTextBox.Clear();
            nameTextBox.Focus();
        }
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValidNumber = int.TryParse(timeTextBox.Text, out int secondsCurrent);

            if (isValidNumber)
            {
                if (secondsFastest == 0 || secondsCurrent < secondsFastest)
                {
                    secondsFastest = secondsCurrent;
                    nameFastest = nameTextBox.Text;
                }
            }

            resultTextBox.Text = $"De snelste atleet is {nameFastest} met de tijd van {secondsFastest}.";

        }
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox.Clear();
            timeTextBox.Clear();
            resultTextBox.Clear();

            nameTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}