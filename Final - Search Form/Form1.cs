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

        //constants for various controls
        const string DefaultSearchText = "Search for a Game!";
        const string DefaultTeamSearchText = "Enter a Team Name";
        const byte DefaultComboBoxIndex = 0;

        //Lists of Game and Team for return results by searcher
        List<Game> foundGamesBySearch;
        List<Team> foundTeamsBySearch;

        //necessary objects for searcher and requester to work with this form
        
        Searcher searcher;
        Requester requester;

        public Form1(Searcher searcher, Requester requester)
        {

            this.searcher = searcher;
            this.requester = requester;

            InitializeComponent();

            this.searchGameButton.Click += new EventHandler(SearchButton__Click);
            this.requestGameButton.Click += new EventHandler(RequestButton__Click);

            

            HideTeamResultsGroupBox();

            
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

            if(rtb.Tag.GetType() == typeof(GameNotFound))
            {
                HideTeamResultsGroupBox();
            }
            else
            {
                ShowTeamResultsGroupBox((Game)rtb.Tag);
            }
        }

        private void RequestButton__Click(object sender, EventArgs e)
        {
            Console.WriteLine(requestGameTextBox.Text);
        }

        
    }
}
