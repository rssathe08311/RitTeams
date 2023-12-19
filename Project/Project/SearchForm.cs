using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Author: Andrew Black, since 12/10/23
 * Name: SearchForm
 * Purpose: Allow the users of RIT to search within the GameDatabase on the app for any Team's playing that game
 * Limitations: none, but current iteration doesn't use all classes related to Teams from FormClasses.cs.
 * Any reference therefor to Team objects is in case of implementation later
 *
 * Controls:
 * 1. Group Box for holding anything related to Searching for a Game title
 * 2. Group Box for holding anything related to Searching for a Team
 * 3. Group Box for holding anything related to a game Request
 * 
 * GameGroupBox
 * 4-5. RichTextField to inform user of how to use Searcher, as well as a Panel for a makeshift border
 * 6. TextField for user to enter Game title to be searched
 * 7. Button that initates Search of Game title
 * 8. TableLayoutPanel to hold information about the game. While not part of the controls, currently this is two RichTextFields created
 * for each Game that matches the Search
 * 
 * TeamGroupBox
 * 9. TextField for user to enter Team names to be searched for
 * 10. ComboBox for user to limit Team search by Platform
 * 11. TableLayoutPanel to hold information about the Teams. While not part of the controls, this is currently 2 RichTextFields created
 * for each Team that matches the result query about the Team, and a button to send the Team a "request to join"
 * 
 * RequestGroupBox
 * 12-13. RichTextField to inform user of how to use Requester, as well as a Panel for a makeshift border
 * 14. TextField for user to enter Game title to be Requested
 * 15. Button that initates Request of Game title
 * 
 * HomeButton
 * 16. Button when pressed closes the form, returning to the "home screen"
 */
namespace Final___Search_Form
{

    public partial class SearchForm : Form
    {

        //constants for various controls
        const string DefaultGameSearchText = "Search for a Game!";
        const string DefaultTeamSearchText = "Enter a Team Name";
        const string RequestSentText = "Request Sent!";
        const byte DefaultComboBoxIndex = 0;

        //Lists of Game and Team for return results by searcher
        List<Game> foundGamesBySearch;
        List<Team> foundTeamsBySearch;

        //necessary objects for searcher and requester to work with this form

        GameDatabase gameDB;
        TeamDatabase teamDB;
        Searcher searcher;
        Requester requester;

        /* Constructor: SearchForm
         * Requires a GameDatabase and a filePath for the Requester
         */
        public SearchForm(GameDatabase gb, string requestFilePath)
        {
            //instantiate some data
            this.gameDB = gb;
            this.teamDB = new TeamDatabase();

            this.searcher = new Searcher(gameDB, teamDB);
            this.requester = new Requester(requestFilePath);

            InitializeComponent();

            //event handlers
            this.searchGameButton.Click += new EventHandler(SearchButton__Click);
            this.requestGameButton.Click += new EventHandler(RequestButton__Click);
            this.homeBox.Click += new EventHandler(HomeBox__Click);
            this.searchGameTextBox.Enter += new EventHandler(TextBox__Enter);
            this.teamSearchTextBox.Enter += new EventHandler(TextBox__Enter);

            //hide GroupBox's - they don't appear until needed
            HideTeamResultsGroupBox();
            HideRequestGroupBox();


            //set default text for the only viewable TextBox upon startup
            this.searchGameTextBox.Text = DefaultGameSearchText;

        }

        /* Method: HideTeamResultsGroupBox
         * Purpose: Hides the Team Results group Box
         */
        private void HideTeamResultsGroupBox()
        {
            this.teamResultsGroupBox.Visible = false;
        }

        /* Method: HideRequestGroupBox
         * Purpose: Hides the Request group Box
         */
        private void HideRequestGroupBox()
        {
            this.requesterGroupBox.Visible = false;
        }

        /* Method: ShowRequestGroupBox
         * Purpose: Shows the Request Group Box, and defaults the requestGameTextBox to the gameInput found from gameSearchTextBox (passed in)
         */
        private void ShowRequestGroupBox(string gameInput)
        {
            this.requestGameTextBox.Text = gameInput;
            this.requesterGroupBox.Visible = true;
        }

        /* Method: ShowTeamResultsGroupBox
         * Purpose: Shows the Team Results group Box, and defaults the searchText and comboBox)
         */
        private void ShowTeamResultsGroupBox(Game game)
        {
            this.teamSearchTextBox.Text = DefaultTeamSearchText;
            this.teamPlatformComboBox.SelectedIndex = DefaultComboBoxIndex;

            this.teamResultsGroupBox.Visible = true;
            this.teamResultsGroupBox.Text = game.Name;


        }

        /* Method: TextBox__Enter
         * Purpose: "Clears" the current Text from the search box if it's Default UNLESS it's the teamSeachBox.
         * If so, entering the parameters for the Teams will automatically call a Search for Teams matching the criteria listed
         * Limitations: currently this is just a proof of concept. The Team class isn't used so I have no way to access Team data, so it 
         * always show the same Team that is hard coded in this method
         */
        private void TextBox__Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text == DefaultTeamSearchText || tb.Text == DefaultGameSearchText)
            {
                tb.Text = "";
            }

            if (tb == teamSearchTextBox)
            {
                //clear previous panels
                teamLayoutPanel.Controls.Clear();
                teamLayoutPanel.RowStyles.Clear();

                //add temporary controls to the form
                RichTextBox teamName = new RichTextBox();
                RichTextBox teamPlatform = new RichTextBox();
                Button inviteButton = new Button();

                //without the current implementation of the Team class, right now the information always defaults to this
                teamName.Text = "Based Tigers";
                teamPlatform.Text = "PC";
                inviteButton.Text = "Request Join";

                //optional dock style
                teamName.Dock = DockStyle.Fill;
                teamPlatform.Dock = DockStyle.Fill;
                inviteButton.Dock = DockStyle.Fill;

                //add any "found" teams
                teamLayoutPanel.Controls.Add(teamName);
                teamLayoutPanel.Controls.Add(teamPlatform);
                teamLayoutPanel.Controls.Add(inviteButton);
            }
        }

        /* Method: SearchButton__Click
         * Purpose: Initiates a Search for any game matching criteria
         */
        private void SearchButton__Click(object sender, EventArgs e)
        {
            //hide the other group boxs while a new search is under way
            HideTeamResultsGroupBox();
            HideRequestGroupBox();

            //fill games list via the searcher, based on the User's entered text for the searchGameTextBox
            foundGamesBySearch = searcher.SearchGame(searchGameTextBox.Text);

            //create RichTextBox's to be added to gameTableLayoutPanel
            RichTextBox gameName;
            RichTextBox gamePlatforms;

            // Clear existing controls and reset properties
            gameTableLayoutPanel.Controls.Clear();
            gameTableLayoutPanel.RowStyles.Clear();

            //loop through all found games matching search result and add their information to gameTableLayoutPanel via RichTextBox's
            foreach (Game game in foundGamesBySearch)
            {

                gameName = new RichTextBox();
                gamePlatforms = new RichTextBox();

                gameName.Text = game.Name;

                //add each Platform to a string, using newlines for neatness
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

                //add click event for controls. Notably, if no game was found, a default GameNotFound object will in these control's Tag's,
                //which is necessary for the controls to determine which GroupBox to open (Team or Request)
                gameName.Click += new EventHandler(GameRichTextBox__Click);
                gamePlatforms.Click += new EventHandler(GameRichTextBox__Click);


            }

            //turn off the autoscroll functionality of gameTableLayoutPanel if it's not warranted.
            //added to fix visual error were a large return query would enable the scrolling, but a thereafter smaller one
            //would keep the scroll even if not needed
            gameTableLayoutPanel.AutoScroll = gameTableLayoutPanel.Controls.Count > gameTableLayoutPanel.RowCount;


        }

        /* Method: GameRichTextBox__Click
         * Purpose: Checks if the Game searched up is in the database. If so, open the TeamGroupBox to search for Teams. Otherwise,
         * open the RequestGroupBox for the user to Request the game
         */
        private void GameRichTextBox__Click(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;

            //the way this method is called, the Tag will always hold the Game object that was searched up OR a GameNotFound object
            if (rtb.Tag.GetType() == typeof(GameNotFound))
            {
                HideTeamResultsGroupBox();
                ShowRequestGroupBox(this.searchGameTextBox.Text);
            }
            else
            {
                ShowTeamResultsGroupBox((Game)rtb.Tag);
                
            }
        }

        /* Method: RequestButton__Click
         * Purpose: Allows the Request of a Game to be "sent to the devs" (added to a Text file in this iteration). Only
         * callable if the Game the user Searched for truly does not exist within our database
         */
        private void RequestButton__Click(object sender, EventArgs e)
        {
            //don't bother adding Requesters for empty strings or the DefaultText that requestGameTextBox is set to when the group box is
            //first opened
            if(this.requestGameTextBox.Text != "" && this.requestGameTextBox.Text != RequestSentText)
            {
                //check out the Requester class for more details on how this works
                requester.AddRequest(this.requestGameTextBox.Text);
            }
        }

        /* Method: HomeBox__Click
         * Purpose: "Returns to Home." In this iteration of the application, it simply closes the form
         */
        private void HomeBox__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}

