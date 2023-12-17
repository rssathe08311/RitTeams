using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final___Search_Form
{
    public partial class Form1 : Form
    {

        const string DefaultSearchText = "Search for a Game!";
        List<Game> games;
        List<Team> teams;
        GameDatabase gameDB;
        TeamDatabase teamDB;
        Requester requester;
        Searcher searcher;

        public Form1()
        {
            InitializeComponent();
            this.searchGameButton.Click += new EventHandler(SearchButton__Click);
            this.comboBox1.SelectedIndex = 0;

            InstantiateGameList();
            CreateSearcher();

            
        }

        private void CreateSearcher()
        {
            searcher = new Searcher(this.requester, this.gameDB, this.teamDB);
        }

        /* Method: InstantiateGameList
         * Purpose: Fill GameDatabase object
         * Limitations: none, but Authors note on this method:
         * for a real application, this method shouldn't be tied to a page but to an overarching "manager class" that creates these pages
         * and relevant information. Adding games like this is nonsensical in almost every way for an online database. It would be more correct
         * to store these information in a file and pull it from there. For the sake of this program's needs, however, this is an "acceptable way"
         * to do this.
         */
        private void InstantiateGameList()
        {
            gameDB = new GameDatabase();

            gameDB.AddGame(new Game("Fortnite", new List<string> { "PC", "Nintendo Switch", "Xbox One", "Xbox Series X/S", "Playstation 5", "Playstation 4" }));
            gameDB.AddGame(new Game("Overwatch 2", new List<string> { "PC", "Nintendo Switch", "Xbox One", "Xbox Series X/S", "Playstation 5", "Playstation 4" }));
            gameDB.AddGame(new Game("Call of Duty Modern Warfare 3", new List<string> { "PC", "Xbox One", "Playstation 5", "Playstation 4" }));
            gameDB.AddGame(new Game("MineCraft", new List<string> { "PC", "Mac", "Linux", "Nintendo Switch", "Xbox One", "Xbox Series X/S", "Playstation 5", "Playstation 4" }));
            gameDB.AddGame(new Game("StarCraft 2", new List<string> {"PC", "Mac"}));
                
        }

        private void SearchButton__Click(object sender, EventArgs e)
        {
            //fill games list via the searcher, based on the User's entered text for the searchGameTextBox
            games = searcher.SearchGame(searchGameTextBox.Text);

            //create RichTextBox's to be added to gameTableLayoutPanel
            RichTextBox gameName;
            RichTextBox gamePlatforms;

            // Clear existing controls and reset properties
            gameTableLayoutPanel.Controls.Clear();
            gameTableLayoutPanel.RowStyles.Clear();

            //loop through all found games matching search result and add their information to gameTableLayoutPanel
            foreach (Game game in games)
            {
                gameName = new RichTextBox();
                gamePlatforms = new RichTextBox();

                gameName.Text = game.Name;

                foreach (string platform in game.Platforms)
                {

                    gamePlatforms.Text += platform + "\n";
                }

                //optional styling to look nicer
                gameName.Dock = DockStyle.Fill;
                gamePlatforms.Dock = DockStyle.Fill;


                gameTableLayoutPanel.Controls.Add(gameName);
                gameTableLayoutPanel.Controls.Add(gamePlatforms);

            }

            //turn off the autoscroll functionality of gameTableLayoutPanel if it's not warranted.
            //added to fix visual error were a large return query would enable the scrolling, but a thereafter smaller one
            //would keep the scroll even if not needed
            gameTableLayoutPanel.AutoScroll = gameTableLayoutPanel.Controls.Count > gameTableLayoutPanel.RowCount;


        }

        private void RequestButton__Click(object sender, EventArgs e)
        {
            return;
        }

        
    }
}
