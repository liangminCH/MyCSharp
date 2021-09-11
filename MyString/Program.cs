using System;

namespace MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================");




            // string[][] 是一维数组，数组中的元素是string[]，相当于锯齿数组
            string[][] arrar1 = new string[][] {
                 new string[]{"1", "1", "1" },
                 new string[]{"2", "2", "2" },
                 new string[]{"3", "3", "3" }};

            string[][] arrar2 = new string[][] {

                 new string[]{"1", "1", "1" },
                 new string[]{"2" },
                 new string[]{"3", "3", "3" }};

            string[][] arrar3 = new string[3][];

            string[][] arrar4 = new string[4][];

            //string[,] 是一个多维数组，数组每一维元素的个数必须相等
            string[,] arr1 = new string[,] {
                            { "1", "1", "1" },
                            { "2", "2", "2" },
                            {"3", "3", "3" }};

            Console.WriteLine("===================");
        }
    }
}
