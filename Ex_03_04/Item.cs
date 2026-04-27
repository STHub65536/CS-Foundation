using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_04
{
    /// <summary>
    /// 商品情報を表すクラス
    /// </summary>
    public class Item
    {
        public int itemNo;
        public string itemName;
        public int price;
        public double salesTaxRate = 0.10;

        public void Print()
        {
            Console.WriteLine("商品番号="+this.itemNo);
            Console.WriteLine("商品名="+this.itemName);
            Console.WriteLine("単価="+this.price);
        }

        public void ChangePrice(int price)
        {
            this.price = price;
        }

        public int CalculateTaxAmount()
        {
            return (int)double.Floor((double)this.price * (1.0 + this.salesTaxRate));
        }
    }
}