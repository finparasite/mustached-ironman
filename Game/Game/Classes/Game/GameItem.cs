using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    abstract class GameItem
    {
        protected string name;
        protected Audio audio;

        public string Name
        {
            get { return name; }
        }

        public Audio Audio
        {
            get { return audio; }
        }

        // Passthro constructor
        public GameItem() { }

        public GameItem(string name, Audio audio)
        {
            this.name = name;
            this.audio = audio;
        }
    }
}
