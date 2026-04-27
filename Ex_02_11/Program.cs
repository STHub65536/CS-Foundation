namespace Ex_02_11;

static class Program
{
    static void Main(string[] args)
    {
        string[] stationArray = {"品川","大崎","五反田","目黒","恵比寿","渋谷","原宿","代々木","新宿"};

        Console.Write("駅名を入力してください->");
        string targetStation = Console.ReadLine();

        for(int i = 0;i < stationArray.Length; i++)
        {
            if (stationArray[i].Equals(targetStation)) continue;

            Console.WriteLine(stationArray[i]);
        }
    }
}
