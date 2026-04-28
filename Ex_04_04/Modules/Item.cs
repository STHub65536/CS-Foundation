using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_04_04.Modules
{
    public class Item : Object
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }

        public Item(int id, string name, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return "Item[Id="+this.Id+" , Name="+this.Name+" , Price="+this.Price+"]";
        }
    }
}