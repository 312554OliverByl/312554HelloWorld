/* Oliver Byl
 * Feb 6, 2018
 * Hello world, the best program ever.
 */

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

namespace _312554HelloWorld
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

        private void BtnGreeting_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Length <= 0)
                return;

            message.Content = "Hello, " + txtName.Text;
        }
    }
}