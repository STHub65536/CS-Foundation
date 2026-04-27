using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_09.Modules
{
    public class Account : Object
    {
        public string? AccountNo{ get; set; }
        public string? AccountName{ get; set; }
        public int Balance{ get; set; }

        public Account(string accountNo, string accountName, int balance)
        {
            this.AccountNo = accountNo;
            this.AccountName = accountName;
            this.Balance = balance;
        }

        public virtual void Print()
        {
            Console.WriteLine("結果");
            Console.WriteLine("口座番号："+this.AccountNo);
            Console.WriteLine("口座名義："+this.AccountName);
            Console.WriteLine("残高："+this.Balance);
        }

        public override string ToString()
        {
            return "Account[AccountNo="+this.AccountNo+",AccountName="+this.AccountName+",Balance="+this.Balance+"]";
        }
    }
}