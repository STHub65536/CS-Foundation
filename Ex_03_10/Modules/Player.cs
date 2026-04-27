using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_10.Modules
{
    public abstract class Player
    {
        public string Media{ get; set;}

        public Player(string media)
        {
            this.Media = media;
        }

        public abstract void Play();

        public abstract void Stop();
    }
}