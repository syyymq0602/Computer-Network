using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            List<string> lines = new List<string>();
            string path = @"C:\\Users\\lonovo\\Desktop\\EquipmentInformation.csv";
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8)) // 使用默认编码
            {
                line = sr.ReadLine();
                /*
                while (!sr.EndOfStream)//判断是否读完文件，EndOfStream表示是否是流文件的结尾
                {
                    Console.WriteLine(sr.ReadLine());   // 按照行读取
                }
                */
                
                while (line != null)
                {
                    line = line.Replace(",", " ");
                    lines.Add(line);
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
        // Console.ReadLine();
        }
    }
}
