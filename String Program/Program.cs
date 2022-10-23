using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = " \" Visual C# .Net \"  ";
            Console.WriteLine(title);

            string batch = " 01 \\ 02";
            Console.WriteLine(batch);
            Console.WriteLine();

            Console.Write("\n");
            Console.WriteLine($"{title} \n {batch}");


            string line = "Object Oriented Language C#";

            Console.WriteLine(line.ToLower());
            Console.WriteLine(line.ToUpper());
            Console.WriteLine(line.Replace("C#", "C++"));

            Console.WriteLine($"Characters with space : {line.Length}");
            Console.WriteLine($"Characters without space : {line.Replace(" ","").Length}");
            Console.WriteLine($"Total words: {line.Split(' ').Length}");

            Console.WriteLine();

            String dep1 = "Compute Science";
            String dep2 = "Electrical Engineering";
            String dep3 = "Civil Engineering";

            int dep1Student = 10;
            int dep2Student = 20;
            int dep3Student = 30;

            Console.WriteLine($"{dep1.PadRight(30, ' ')} {dep1Student.ToString().PadLeft(10, ' ')}");
            Console.WriteLine($"{dep2.PadRight(30, ' ')} {dep2Student.ToString().PadLeft(10, ' ')}");
            Console.WriteLine($"{dep3.PadRight(30, ' ')} {dep3Student.ToString().PadLeft(10, ' ')}");

            string uName = "Canadian";
            Console.WriteLine(uName.Substring(0, 3));
            Console.WriteLine(uName.Substring(1, 3));
            Console.WriteLine(uName.Substring(3, 3));
            Console.WriteLine(uName.Substring(3));





            Console.ReadKey();    
        }//Main
    }//Class
}//Namespace
