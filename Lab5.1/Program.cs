using System;

namespace lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {


            //5.1- 8 вариант - средний уровень

            bool x, y, z;
            Console.WriteLine("x y z f1   ||   x y z f2");
            for (int i = 0; i <= 1; i++)
            {
                z = i == 0 ? false : true;
                for (int j = 0; j <= 1; j++)
                {
                    y = j == 0 ? false : true;
                    for (int m = 0; m <= 1; m++)
                    {

                        x = m == 0 ? false : true;
                        int a = x ? 1 : 0;
                        int b = y ? 1 : 0;
                        int c = z ? 1 : 0;
                        int d1 = first(x, y, z) ? 1 : 0; ;
                        int d2 = second(x, y, z) ? 1 : 0;

                        Console.WriteLine($"{a} {b} {c} {d1}    ||   {a} {b} {c} {d2}");
                    }
                }

            }
        
            
            static bool first(bool x, bool y, bool z) => !(x & y) | (x & !z);

            static bool second(bool x, bool y, bool z) => (x & !(!y | z)) | y;


        }
    }
}