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
    public partial class Form7 : Form
    {

        //constants for various controls
        const string DefaultGameSearchText = "Search for a Game!";
        const string DefaultTeamSearchText = "Enter a Team Name";
        const byte DefaultComboBoxIndex = 0;

        //Lists of Game and Team for return results by searcher
        List<Game> foundGamesBySearch;
        List<Team> foundTeamsBySearch;

        //necessary objects for searcher and requester to work with this form
        //I wish I could place these in a different part of the program but I'm unsure where, so 
        //in the Search form they go!

        GameDatabase gameDB;
        TeamDatabase teamDB;
        Searcher searcher;
        Requester requester;


        public Form7()
        {
            //
            gameDB = InstantiateGameList();

            this.searcher = new Searcher(gameDB, teamDB);
            this.requester = new Requester(gameDB);

            InitializeComponent();

            this.searchGameButton.Click += new EventHandler(SearchButton__Click);
            this.requestGameButton.Click += new EventHandler(RequestButton__Click);
            this.homeBox.Click += new EventHandler(HomeBox__Click);
            this.searchGameTextBox.Enter += new EventHandler(TextBox__Enter);
            this.teamSearchTextBox.Enter += new EventHandler(TextBox__Enter);

            this.searchGameTextBox.Text = DefaultGameSearchText;

            HideTeamResultsGroupBox();
            requesterGroupBox.Visible = false;

        }

        private void HideTeamResultsGroupBox()
        {
            this.teamResultsGroupBox.Visible = false;
        }

        private void ShowTeamResultsGroupBox(Game game)
        {
            this.teamSearchTextBox.Text = DefaultTeamSearchText;
            this.comboBox1.SelectedIndex = DefaultComboBoxIndex;

            this.teamResultsGroupBox.Visible = true;
            this.teamResultsGroupBox.Text = game.Name;



        }


        private void TextBox__Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text == DefaultTeamSearchText || tb.Text == DefaultGameSearchText)
            {
                tb.Text = "";
            }

            if (tb == teamSearchTextBox)
            {

                teamLayoutPanel.Controls.Clear();
                teamLayoutPanel.RowStyles.Clear();

                RichTextBox teamName = new RichTextBox();
                RichTextBox teamPlatform = new RichTextBox();
                Button inviteButton = new Button();

                teamName.Text = "Based Tigers";
                teamPlatform.Text = "PC";
                inviteButton.Text = "Request Join";

                teamName.Dock = DockStyle.Fill;
                teamPlatform.Dock = DockStyle.Fill;
                inviteButton.Dock = DockStyle.Fill;

                teamLayoutPanel.Controls.Add(teamName);
                teamLayoutPanel.Controls.Add(teamPlatform);
                teamLayoutPanel.Controls.Add(inviteButton);
            }
        }

        private void SearchButton__Click(object sender, EventArgs e)
        {
            //hide the TeamResultsGroupBox while a new search is under way
            HideTeamResultsGroupBox();

            //fill games list via the searcher, based on the User's entered text for the searchGameTextBox
            foundGamesBySearch = searcher.SearchGame(searchGameTextBox.Text);

            //create RichTextBox's to be added to gameTableLayoutPanel
            RichTextBox gameName;
            RichTextBox gamePlatforms;

            // Clear existing controls and reset properties
            gameTableLayoutPanel.Controls.Clear();
            gameTableLayoutPanel.RowStyles.Clear();

            //loop through all found games matching search result and add their information to gameTableLayoutPanel
            foreach (Game game in foundGamesBySearch)
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

                //store Game object in control's tags
                gameName.Tag = game;
                gamePlatforms.Tag = game;

                //add controls
                gameTableLayoutPanel.Controls.Add(gameName);
                gameTableLayoutPanel.Controls.Add(gamePlatforms);

                //add click event for controls
                gameName.Click += new EventHandler(GameRichTextBox__Click);
                gamePlatforms.Click += new EventHandler(GameRichTextBox__Click);


            }

            //turn off the autoscroll functionality of gameTableLayoutPanel if it's not warranted.
            //added to fix visual error were a large return query would enable the scrolling, but a thereafter smaller one
            //would keep the scroll even if not needed
            gameTableLayoutPanel.AutoScroll = gameTableLayoutPanel.Controls.Count > gameTableLayoutPanel.RowCount;


        }

        private void GameRichTextBox__Click(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;

            if (rtb.Tag.GetType() == typeof(GameNotFound))
            {
                HideTeamResultsGroupBox();
                requesterGroupBox.Visible = true;
            }
            else
            {
                ShowTeamResultsGroupBox((Game)rtb.Tag);
                requesterGroupBox.Visible = false;
            }
        }

        private void RequestButton__Click(object sender, EventArgs e)
        {
            Console.WriteLine(requestGameTextBox.Text);
            requestGameTextBox.Text = "Request Sent!";
        }

        private void HomeBox__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Method: InstantiateGameList
        * Purpose: Fill GameDatabase object
        * Limitations: none, but Authors note on this method:
        * for a real application, this method shouldn't be tied to a page but to an overarching "manager class" that creates these pages
        * and relevant information. Adding games like this is nonsensical in almost every way for an online application using a database. It would be more correct
        * to store these information in a file and pull it from there. For the sake of this program's needs, however, this is an "acceptable way"
        * to do this.
        */
        private static GameDatabase InstantiateGameList()
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

