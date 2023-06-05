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
        bool isEditor = false;
        private List<Game> source = ListOfGames.GetGames();
        private List<string> titles = new List<string>();
        public Main()
        {
            foreach (Game game in source)
            {
                titles.Add(game.Title);
            }
            InitializeComponent();
            navigation.ItemsSource = titles;
        }

        private void selected(object sender, RoutedEventArgs e)
        {
            foreach (Game game in source)
            { 
                if (navigation.SelectedItem.ToString() == game.Title)
                {
                    selected_title.Text = game.Title;
                    selected_price.Text = game.Price;
                    selected_description.Text = game.Description;
                }
            }
        }


        private void editor_on(object sender, RoutedEventArgs e)
        {
            isEditor = !isEditor;
            if (isEditor)
            {
                MenuItem item = new MenuItem();
                item.Header = "Store";
                MenuItem item2 = new MenuItem();
                item2.Header = "Add new game";
                item2.Click += add_game;
                item.Items.Add(item2);
                menu_main.Items.Add(item);
            }
            else
            {
                menu_main.Items.Remove("Store");
            }
        }

        private void add_game(object sender, RoutedEventArgs e)
        {
                NavigationService.Navigate(new AddScreen());
        }

        private void exit (object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void about_page(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Module());
        }
    }
}

