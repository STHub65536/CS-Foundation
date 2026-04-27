using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_09.Modules
{
    public class NetAccount : Account
    {
        public int Point{ get; set; }

        public NetAccount(string accountNo, string accountName, int balance, int point)
        :base(accountNo, accountName, balance)
        {
            this.Point = point;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("ポイント："+this.Point);
        }

        public override string ToString()
        {
            return "NetAccount["+base.ToString()+",Point="+this.Point+"]";
        }
    }
}