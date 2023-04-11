using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassPractice
{
    internal class Games
    {
        // fields
        // console
        // type (mmo, rpg, fps, ect)
        // players
        // year
        // region
        string _console;
        string _type;
        int _players;
        int _years;
        string _region;

        // properties

        public string console {get { return _console;} set { _console = value; } }

        public string type { get { return _type; } set { _type = value; } }
        
        public int players { get { return _players; } set { _players = value; } }

        public int years { get { return _years; } set { _years = value; } }

        public string region { get { return _region; } set{ _region = value; } } 



    }
}
