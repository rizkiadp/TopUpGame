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

namespace TopUpGame
{
    /// <summary>
    /// Interaction logic for ListGame.xaml
    /// </summary>
    public partial class ListGame : Window
    {
        public ListGame()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PilihDmML ListGame = new PilihDmML();
            ListGame.Show();
        }
    }
}
