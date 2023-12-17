using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileLib
{
    public class Profile
    {
        public string username
        {
            get; set;
        }
        public string password
        {
            get; set;
        }
        public string email
        {
            get;set;
        }

        public string status
        {
            get; set;
        }

        public Boolean privacy
        {
            get;set;
        }

        //need to impliment more
        public string profilePicture;

        public Profile()
        {
            this.privacy = false;
            this.status = "Hi I'm a new user on RITeams!";
        }
    }
}
