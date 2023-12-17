using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final___Search_Form
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GameDatabase gameDB = InstantiateGameList();
            TeamDatabase teamDB = new TeamDatabase();

            Requester requester = new Requester(gameDB);
            Searcher searcher = new Searcher(gameDB, teamDB);

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(searcher, requester));
        }

        

        /* Method: InstantiateGameList
         * Purpose: Fill GameDatabase object
         * Limitations: none, but Authors note on this method:
         * for a real application, this method shouldn't be tied to a page but to an overarching "manager class" that creates these pages
         * and relevant information. Adding games like this is nonsensical in almost every way for an online application using a database. It would be more correct
         * to store these information in a file and pull it from there. For the sake of this program's needs, however, this is an "acceptable way"
         * to do this.
         */
        private static GameDatabase InstantiateGameList( )
        {
            GameDatabase gameDB = new GameDatabase();

            gameDB.AddGame(new Game("Fortnite", new List<string> { "PC", "Nintendo Switch", "Xbox One", "Xbox Series X/S", "Playstation 5", "Playstation 4" }));
            gameDB.AddGame(new Game("Overwatch 2", new List<string> { "PC", "Nintendo Switch", "Xbox One", "Xbox Series X/S", "Playstation 5", "Playstation 4" }));
            gameDB.AddGame(new Game("Call of Duty Modern Warfare 3", new List<string> { "PC", "Xbox One", "Playstation 5", "Playstation 4" }));
            gameDB.AddGame(new Game("MineCraft", new List<string> { "PC", "Mac", "Linux", "Nintendo Switch", "Xbox One", "Xbox Series X/S", "Playstation 5", "Playstation 4" }));
            gameDB.AddGame(new Game("StarCraft 2", new List<string> { "PC", "Mac" }));

            return gameDB;

        }
    }
}
