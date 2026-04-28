using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Ex_04_05
{
    public class TextFileAccessor
    {
        public void Write(string fileName, List<string> datas)
        {
            StreamWriter sw = new StreamWriter("./"+fileName);
            
            for(int i = 0;i < datas.Count; i++)
            {
                sw.WriteLine(datas[i]);
            }

            Console.WriteLine("ファイルにデータを書き込みました。");
            sw.Close();
        }

        public void ReadAndPrint(string fileName)
        {
            StreamReader sr = new StreamReader("./"+fileName);

            string text;
            while (true)
            {
                text = sr.ReadLine();
                if(text == null)
                {
                    break;
                }
                Console.WriteLine(text);
            }

            Console.WriteLine("ファイルのデータを読み取りました。");
            sr.Close();
        }
    }
}