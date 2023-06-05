using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALLY_18_LABA
{
    static internal class ListOfGames
    {

        static private List<Game> games = new List<Game>
        {
            new Game { Title = "Left 4 Dead", Price = "699 руб.",Description = "Многопользовательская компьютерная игра в жанрах шутера от первого лица и survival horror, разработанная американской компанией Turtle Rock Studios, которая с 10 января 2008 по 3 июня 2009 являлась частью Valve Corporation. Игра создана на движке Source версии 14 для платформ Microsoft Windows и Xbox 360. Портированием игры на Xbox 360 занималась студия Certain Affinity. 28 октября 2010 года игра стала доступна на macOS." }
        };


       static public void AddGame(Game game)
        {
            games.Add(game);
        }

        static public void RemoveGame(string title)
        {
            foreach (Game game in games)
            {
                if (game.Title == title)
                {
                    games.Remove(game);
                    break;
                }
            }
        }

        static public void UpdateGame(string title, string desc, string price)
        {
            Game game = null;
            Game pre = null;

            foreach (Game g in games) 
            {
                if (g.Title == title)
                {
                    game = g;
                    pre = g;
                    break;
                }
            }

            game.Title = title;
            game.Description = desc;
            game.Price = price;

            games.Remove(pre);
            games.Add(game);

        }

        static public List<Game> GetGames()
        {
            return games;
        }

    }

}
