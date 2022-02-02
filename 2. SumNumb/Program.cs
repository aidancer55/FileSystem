using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2.SumNumb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "File";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);    
            
            }
            string path1 = "File/Numbers.txt";
            if (!File.Exists(path1))
            {
                File.Create(path1);
            }
            StreamWriter sw = new StreamWriter(path1);
            int[] array = new int[10];
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
                sw.Write("{0} ", array[i]);
            }
            sw.Close();
            Console.WriteLine("Сумма равна {0}", sum);
            Console.ReadKey();
        }
    }
}
