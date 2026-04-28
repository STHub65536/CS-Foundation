using Ex_04_04.Modules;

namespace Ex_04_04;

static class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, Item> itemDict = new Dictionary<int, Item>();

        itemDict.Add(101, new Item(101, "水性ボールペン(黒)", 150));
        itemDict.Add(102, new Item(102, "油性ボールペン(黒)", 100));
        itemDict.Add(103, new Item(103, "鉛筆(黒)", 60));
        itemDict.Add(104, new Item(104, "鉛筆(赤)", 80));

        Console.Write("商品番号を入力してください->");
        int key = int.Parse(Console.ReadLine());
        if (itemDict.ContainsKey(key))
        {
            Console.WriteLine(itemDict[key].ToString());
        }
        else
        {
            Console.WriteLine("該当する商品はありません。");
        }
    }
}
