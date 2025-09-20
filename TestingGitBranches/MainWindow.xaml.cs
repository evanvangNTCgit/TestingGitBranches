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

namespace TestingGitBranches
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi this button was made in the first commit! \n This project was made by Evan for him to learna about git branches!");
        }

        private void momButton_Click(object sender, RoutedEventArgs e)
        {
            var evansImageWindow = new EvansImage();
            evansImageWindow.Show();
        }

        private void evansAge_Click(object sender, RoutedEventArgs e)
        {
            // Ok it is not getting merged to the master branch!
            // And as per the testing branch everything is going okay. We see no edge cases as of 9/19.
            // Alright as per the development branch everything is alright.
            MessageBox.Show($"Evans Current Age: {DateTime.Now.Year - 2005}");
        }
    }
}