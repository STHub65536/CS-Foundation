using Ex_04_03.Modules;

namespace Ex_04_03;

static class Program
{
    static void Main(string[] args)
    {
        List<Employee> empList = new List<Employee>();
        int id;
        string name;
        string address;

        while(empList.Count < 2)
        {
            Console.Write("社員番号を入力してください->");
            id = int.Parse(Console.ReadLine());
            Console.Write("社員名を入力してください->");
            name = Console.ReadLine();
            Console.Write("住所を入力してください->");
            address = Console.ReadLine();

            empList.Add(new Employee(id, name, address));
        }

        for(int i = 0;i < empList.Count; i++)
        {
            Console.WriteLine(empList[i].ToString());
        }
    }
}
