using System;

namespace week4.academy
{
    public class Program
    {
       public static void Main()
        {
            ////int i = 9;
            ////int j = 10;
            ////int result = i + j;

            //Figure o = new Figure() { X = 100 };

            //Figure o2 = new Figure() { X = 123 };
            ////Figure plus = o == o2;
            //bool isEqual = o == o2;
            //bool isEqual2 = o2 >= o;
            ////Figure o3 = new Figure() { X = 10 };

            ////Figure o4 = new Figure() { X = 20 };

            ////Figure plus = o + (o2 + o3) - o4;
            ////plus++;
            ////bool isEqual = o == o2;
            //Console.WriteLine(isEqual2);



            ////PARSEINT 
            //peg:
            //string input = Console. ReadLine();
            //Nullable<int> a = int.TryParse(input, out int age) ? age : 0;

            //int i = a.HasValue ? a.Value : 0;

            //Console.WriteLine(i);
            //goto peg;


            //ParseInt_2

            string age = "2";

            if (decimal.TryParse(age, out _))
            {
                Console.WriteLine("Invalid age");
            }
            else
            {
                Console.WriteLine("Age is valid");
            }
        }

        public static void SomeMethod(out int y)
        {
            y = 78;
        }
    }
}
