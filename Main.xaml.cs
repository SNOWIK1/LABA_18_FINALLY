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

namespace FINALLY_18_LABA
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
            string[] source = { "Left 4 Dead", "Fallout: New Vegas", "The Elder Scrolls IV: Oblivion", "Call of Duty Modern Warfare", "The Forest", "S.T.A.L.K.E.R. Тень Чернобыля" };
            navigation.ItemsSource = source;
        }

        private void selected(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Module(navigation.SelectedItem.ToString()));
        }
    }
}
