using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALLY_18_LABA
{
    public class Game
    {
        private List<string> genres = new List<string>();
        public string Title { get; set; }

        public void AddGenres(string[] arr)
        {
            foreach (string g in arr)
            {
                genres.Add(g);
            }
        }

        public void Update(string[] arr)
        {
            foreach (string g in genres)
            {
                genres.Remove(g);
            }
            
            foreach (string g in arr)
            {
                genres.Add(g);
            }

        }

        public string GetGenres()
        {
            string result = "";

            foreach (string g in genres)
            {
                result += (g + " ");
            }
            return result;
        }
        public string Description {get; set;}
    }
}
