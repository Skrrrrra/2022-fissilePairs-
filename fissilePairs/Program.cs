using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fissilePairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь

            string inputpath = "D:\\SolutionsForSpaceApp\\2022\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2022\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();


            string length;
            using (var reader = new StreamReader(inputpath))
            {
                length = reader.ReadLine();
            }

            int[] A;
            A = new int[Convert.ToInt32(length)];

            string secondLine;
            using (var reader = new StreamReader(inputpath))
            {
                reader.ReadLine();
                secondLine = reader.ReadLine();
            }

            string[] seconeLineToInt = secondLine.Split(' ');

            int count = 0;
            foreach (var s in seconeLineToInt)
            {
                A[count] = Convert.ToInt32(s);
                count++;
            }

            List<int> pairs = new List<int>();
            count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 1; j < A.Length; j++)
                {
                    if (A[i] % A[j] ==0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();



        }
    }
}
