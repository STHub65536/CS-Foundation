using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_12.Modules
{
    public class DVDPlayer : Player
    {
        public DVDPlayer(string media) : base(media){}

        public override void Play()
        {
            Console.WriteLine("DVD:"+base.Media+"を再生しています");
        }
        
        public override void Stop()
        {
            Console.WriteLine("DVD:"+base.Media+"の再生を停止しました");
        }
    }
}