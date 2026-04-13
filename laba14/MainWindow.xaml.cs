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

namespace laba14
{
    public partial class MainWindow : Window
    {
        public MainWindow() { InitializeComponent(); }

        private void OpenExamples_Click(object sender, RoutedEventArgs e)
        {
            
            new ExamplesWindow().Show();
        }

        private void OpenTask1_Click(object sender, RoutedEventArgs e)
        {
          
            new CalculatorWindow().Show();
        }
    }
}