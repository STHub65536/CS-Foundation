namespace Ex_04_05;

static class Program
{
    static void Main(string[] args)
    {
        List<string> textList = new List<string>();
        string fileName = "exercise05.txt";

        string text;
        while (true)
        {
            Console.Write("書き込むデータを入力してください->");
            text = Console.ReadLine();
            if (text.Equals("End"))
            {
                break;
            }
            textList.Add(text);
        }
        
        TextFileAccessor textFileAccessor = new TextFileAccessor();
        textFileAccessor.Write(fileName, textList);

        textFileAccessor.ReadAndPrint(fileName);
    }
}
