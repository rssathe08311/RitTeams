using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Author: Andrew Black, since 12/10/12
 * Name: MyClasses
 * Purpose: Holds various class objects for Final Project - RITeams Application
 */
namespace Final___Search_Form
{
    /* Class: Game
     * Purpose: Holds information regarding a Video Game object
     */
    public class Game
    {
        public string Name { get; set; }
        public List<string> Platforms { get; set; }

        //constructor requires a name and a list of platforms
        public Game(string name, List<string> platforms)
        {
            Name = name;
            Platforms = platforms;
        }
    }

    /* Class: GameNotFound
     * Purpose: Child of a game, represents an instance where a Game was attempted to be found
     * but no such game exists.
     */
    public class GameNotFound : Game
    {
        //default constructor calls constructor with the same information always to create a game
        //with values for a non-existant game
        public GameNotFound() : this("Game Not Found", new List<string>() { "No Platform" })
        {

        }

        public GameNotFound(string name, List<string> platforms) : base(name, platforms)
        {

        }

    }

    

    /* Class: GameDatabase
     * Purpose: holds a List of Games as well as a search function to ensure we're not adding a game that already exists
     * in the database
     */
    public class GameDatabase
    {
        private List<Game> gameDictionary;

        //default constructor instantiates the list
        public GameDatabase()
        {
            this.gameDictionary = new List<Game>();
        }

        /* Method: ReturnSearch
         * Purpose: Returns a List of games matching a string representing a game's title (Game.Name)
         * returns matches or GameNotFound
         */
        public List<Game> ReturnSearch(string gameTitle)
        {
            // Add logic to search for a game in the database

            List<Game> foundGames = new List<Game>();

            foreach (Game g in this.gameDictionary)
            {
                if (g.Name.IndexOf(gameTitle, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    foundGames.Add(g);
                }
            }

            if (foundGames.Count == 0)
            {
                foundGames.Add(new GameNotFound());
            }

            return foundGames;
        }

        /* Method: AddGame
         * Purpose: Adds Game to the List
         */
        public void AddGame(Game game)
        {
            this.gameDictionary.Add(game);
        }
    }

    /* Class: Searcher
     * Purpose: dual purpose (in theory) object that goes through the GameDatabase (and TeamDatabase if it were used)
     * to call its functions and reutrn data relating to Games/Teams
     */
    public class Searcher
    {

        private GameDatabase gameDB;

        //teamDB unusued
        private TeamDatabase teamDB;

        //default connstructor still requires both databases. an unused TeamDatabase won't even have methods for it
        //so it won't break
        public Searcher(GameDatabase gameDatabase, TeamDatabase teamDatabase)
        {

            gameDB = gameDatabase;
            teamDB = teamDatabase;
        }

        /* Method: SearchGame
         * Purpose: returns a list of Game objects the Search found in the GameDatabase (or GameNotFound if none matched criteria)
         */
        public List<Game> SearchGame(string gameName)
        {

            return this.gameDB.ReturnSearch(gameName);
        }

        /* Method: SearchTeam
         * Purpose: would return List of Team's that currently are rostered for a Game, but is currently unused. This would take a secondary
         * string for the KVP for Platform
         */
       /* public List<Team> SearchTeam(KeyValuePair<Game, string> gameInfo)
        {
            // Add logic to search for a team based on a game
            return new List<Team>();
        }*/
    }

    /* Class: Requester
     * Purpose: Writes to a Text File any Game Requests by users (i.e., games not in the Database for Team's to register for)
     * Limitation: none, but in a practical sense a Text file wouldn't be a good way to store data for an online application. Since we aren't using a server
     * of any kind, its current iteration serves as a "proof of practice" that the data can be saved
     */
    public class Requester
    {
        //current game being requested; this changes with every new call of AddGame()
        private string gameRequest;
        private string filePath;

        //only constructor requires the filepath for the data to be saved
        public Requester(string filePath)
        {
            this.filePath = filePath;
        }

        /* Method: AddRequest
         * Purpose: Add's a requested game to the text file to be considered by Dev team to be added to Database. Uses helper method Search()
         * to complete this function
         */
        public void AddRequest(string gameName)
        {
            this.gameRequest = gameName;

            //check to ensure we can store the data. Regardless of if the filepath exists or not, open the file (make one if we need to)
            if (File.Exists(filePath))
            {
                //calling Search, check if the game is already in the requests. If not, proceed to add it
                if (!Search())
                {

                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(gameRequest);
                    }
                }
            }
            else
            {
                using (FileStream fs = File.Create(filePath))
                {
                    //calling Search, check if the game is already in the requests. If not, proceed to add it
                    if (!Search())
                    {
                        using (StreamWriter writer = new StreamWriter(filePath, true))
                        {
                            writer.WriteLine(gameRequest);
                        }
                    }
                }
            }
        }

        /* Method: Search
         * Purpose: Search through the Text file for any line that contains a match for the current gameRequest. If none found, add it. 
         */
        private bool Search()
        {
            //bool to keep track if the game data was found
            bool foundGame = false;

            
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                //iterate until end of file; look for a game request that's the same as the one currently being requested.
                //if it's found, return TRUE. Otherwise, return FALSE
                while ((line = reader.ReadLine()) != null)
                {

                    if (string.IsNullOrWhiteSpace(line))
                    {
                        // Found a blank line, add the gameRequest and break out of the loop
                        foundGame = false;
                        break;

                    }
                    else if (line.Equals(this.gameRequest, StringComparison.OrdinalIgnoreCase))
                    {
                        foundGame = true;
                        break;
                    }
                }
            }

            return foundGame;
        }


    }

    /* Class: Team
     * Purpose: would hold information relating to a Team, but currently unusued
     */
    public class Team
    {
        public List<Game> gamesPlayed;
        public string TeamName
        {
            get; set;
        } 

        //there's not even a constructor :(

    }

    /* Class: TeamNotFound
     * Purpose: would hold information relating to a nonexistent Team, but currently unusued
     */
    public class TeamNotFound
    {
    }

    /* Class: TeamDatabase
     * Purpose: would hold a List of Teams for indexing, but currently unused
     */
    public class TeamDatabase
    {
        private List<Team> teams;

        public TeamDatabase()
        {
            teams = new List<Team>();
        }

        public Team ReturnTeamsByGame(Game game)
        {
            // Add logic to return teams based on a game
            return new Team();
        }

        public void AddGameToMyTeam(KeyValuePair<Game, string> gameInfo)
        {
            // Add logic to add a game to the team database
        }
    }


   
}
