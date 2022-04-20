using System;

namespace week4.academy
{
    public class Program
    {
       public static void Main()
        {
            //int i = 9;
            //int j = 10;
            //int result = i + j;

            Figure o = new Figure() { X = 100 };

            Figure o2 = new Figure() { X = 123 };
            //Figure plus = o == o2;
            bool isEqual = o == o2;
            bool isEqual2 = o2 >= o;
            //Figure o3 = new Figure() { X = 10 };

            //Figure o4 = new Figure() { X = 20 };

            //Figure plus = o + (o2 + o3) - o4;
            //plus++;
            //bool isEqual = o == o2;
            Console.WriteLine(isEqual2);

        }
    }
}
