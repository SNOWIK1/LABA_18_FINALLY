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
    /// Логика взаимодействия для AddScreen.xaml
    /// </summary>
    public partial class AddScreen : Page
    {
        public AddScreen()
        {
            InitializeComponent();
        }

        private void add_game(object sender, RoutedEventArgs e)
        {
            if (title.Text == "" || desc.Text == "")
            {
                MessageBox.Show("All fields must be filled", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                ListOfGames.AddGame(new Game { Title = title.Text, Description = desc.Text });
                title.Text = "";
                desc.Text = "";
            }
        }

        private void go_back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Main());
        }
    }
}
