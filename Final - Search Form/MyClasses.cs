using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final___Search_Form
{
    internal class MyClasses
    {
    }
    public class Game
    {
        public string Name { get; set; }
        public List<string> Platforms { get; set; }

        public Game(string name, List<string> platforms)
        {
            Name = name;
            Platforms = platforms;
        }
    }

    // Represents a game not found
    public class GameNotFound : Game
    {

        public GameNotFound() : this("Game Not Found", new List<string>() { "No Platform" })
        {

        }

        public GameNotFound(string name, List<string> platforms) : base(name, platforms)
        {

        }

    }

    // Represents a collection of Game
    

    // Represents a database of Game
    public class GameDatabase
    {
        private List<Game> gameDictionary;

        public GameDatabase( )
        {
            this.gameDictionary = new List<Game>();
        }

        public List<Game> ReturnSearch(string gameTitle)
        {
            // Add logic to search for a game in the database

            List<Game> foundGames = new List<Game> ();

            foreach(Game g in this.gameDictionary)
            {
                if(g.Name.IndexOf(gameTitle, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    foundGames.Add(g);
                }
            }

            if(foundGames.Count == 0)
            {
                foundGames.Add(new GameNotFound());
            }
            
            return foundGames;
        }

        public void AddGame(Game game)
        {
            this.gameDictionary.Add(game);
        }
    }

    // Represents a team
    public class Team
    {
        // Team properties
    }

    // Represents a team not found
    public class TeamNotFound
    {
    }

    // Represents a database of teams
    public class TeamDatabase
    {
        private List<Team> teams;
        private Searcher search;

        public TeamDatabase(Searcher searcher)
        {
            teams = new List<Team>();
            search = searcher;
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

    // Represents a query for game requests
    public class RequestQuery
    {
        private Dictionary<string, string> gameRequests;

        public RequestQuery()
        {
            gameRequests = new Dictionary<string, string>();
        }

        public void AddRequest(string gameName)
        {
            // Add logic to add a game request
        }

        public void AddRequest(string gameName, string console)
        {
            // Add logic to add a game request with platform
        }

        public void AddRequest(KeyValuePair<string, string> gameInfo)
        {
            // Add logic to add a game request with additional information
        }
    }

    // Represents a requester
    public class Requester
    {
        private KeyValuePair<string, string> requestInfo;
        private RequestQuery rq;
        private Searcher search;

        public Requester(RequestQuery requestQuery, Searcher searcher)
        {
            rq = requestQuery;
            search = searcher;
        }

        public void Search()
        {
            // Add logic to initiate a search
        }

        public void RQ()
        {
            // Access the RequestQuery object
        }

        public void AddRequest(string gameName)
        {
            // Add logic to add a game request
        }

        public void AddRequest(string gameName, string console)
        {
            // Add logic to add a game request with platform
        }

        public void AddRequest(KeyValuePair<string, string> gameInfo)
        {
            // Add logic to add a game request with additional information
        }
    }

    // Represents a searcher
    public class Searcher
    {
        private List<Game> foundGames;
        private List<Team> foundTeams;
        private GameDatabase gameDB;
        private Requester requester;
        private TeamDatabase teamDB;

        public Searcher(Requester request, GameDatabase gameDatabase, TeamDatabase teamDatabase)
        {
            requester = request;
            gameDB = gameDatabase;
            teamDB = teamDatabase;
        }

        public List<Game> SearchGame(string gameName)
        {
            // Add logic to search for a game
            return this.gameDB.ReturnSearch(gameName);
        }

        /*public KeyValuePair<Game, string> SearchGame(string gameName, string platform)
        {
            // Add logic to search for a game with platform
            return new KeyValuePair<Game, string>(new Game(gameName, new List<string> { platform }), "Found");
        }*/

        public Team SearchTeam(KeyValuePair<Game, string> gameInfo)
        {
            // Add logic to search for a team based on a game
            return new Team();
        }
    }
}
