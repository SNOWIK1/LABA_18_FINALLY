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
    public partial class Module : Page
    {
        List<Game> games = new List<Game>
        {
            new Game {Title = "Left 4 Dead", Description = "Left 4 Dead — многопользовательская компьютерная игра в жанрах шутера от первого лица и survival horror, разработанная американской компанией Turtle Rock Studios, которая с 10 января 2008 по 3 июня 2009 являлась частью Valve Corporation. Игра создана на движке Source версии 14 для платформ Microsoft Windows и Xbox 360."},

            new Game {Title = "Fallout: New Vegas", Description = "Игрового персонажа, известного просто как Курьер, нанимают для доставки в город Нью-Вегас (бывший Лас-Вегас) ценной посылки, но Курьер становится жертвой ограбления и едва не погибает, а в течение дальнейшей игры пытается вернуть посылку и отомстить своим обидчикам."},

            new Game {Title = "The Elder Scrolls IV: Oblivion", Description = "The Elder Scrolls IV: Oblivion — компьютерная ролевая игра в жанре action/RPG с открытым миром, разработанная американской компанией Bethesda Game Studios и выпущенная компаниями Bethesda Softworks и 2K Games для Microsoft Windows и Xbox 360 в 2006 году и для PlayStation 3 в 2007 году. В 2006 году также была выпущена игра для мобильных телефонов The Elder Scrolls IV: Oblivion Mobile, разработанная компанией Vir2L Studios."},

            new Game {Title = "Call of Duty Modern Warfare", Description = "Call of Duty: Modern Warfare — компьютерная игра в жанре шутера от первого лица, разработанная Infinity Ward и изданная Activision. Выход состоялся 25 октября 2019 года. Игра является перезапуском подсерии Modern Warfare, а также шестнадцатым проектом во франшизе."},

            new Game {Title = "The Forest", Description = "The Forest - это мрачная sandbox-игра про выживание в ночном лесу, полном монстров. Игроки попадают на остров в результате авиакатастрофы, после чего узнают, что на острове они не одиноки - там же живет племя туземцев-каннибалов, которые начинают преследовать протагониста."},

            new Game {Title = "S.T.A.L.K.E.R. Тень Чернобыля", Description = "«S.T.Á.L.K.E.R.: Тень Черно́быля»[к 2] (бывш. S.T.A.L.K.E.R.: Oblivion Lost[7][к 3]), официально названная в СНГ как S.T.A.L.K.E.R.[8], — компьютерная игра в жанре шутера от первого лица с элементами RPG и survival horror, разработанная и выпущенная украинской компанией GSC Game World для Microsoft Windows в 2007 году. За пределами СНГ издателем выступила американская компания THQ. Действие игры происходит в зоне отчуждения Чернобыльской АЭС. "}
        };

        public Module(string title)
        {
            Game selected = null;
            foreach (Game game in games)
            {
                if (title == game.Title)
                {
                    selected = game;
                    break;
                }
            }
            InitializeComponent();
            lbl.Text = selected.Title;
            lbl.FontWeight = FontWeights.Bold;
            desc.Text = selected.Description;
        }

        private void go_back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Main());
        }
    }
}
