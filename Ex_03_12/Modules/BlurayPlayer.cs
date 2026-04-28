using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_12.Modules
{
    public class BlurayPlayer : Player
    {
        public BlurayPlayer(string media):base(media){}

        public override void Play()
        {
            Console.WriteLine("Blu-ray:"+base.Media+"を再生しています");
        }

        public override void Stop()
        {
            Console.WriteLine("Blu-ray:"+base.Media+"の再生を停止しました");
        }
    }
}