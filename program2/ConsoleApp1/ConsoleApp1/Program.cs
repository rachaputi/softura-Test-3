using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the minimum value");
            int min =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the maximum value");
            int max = Convert.ToInt32(Console.ReadLine());
            if(min<max)
            {
                for (int i = min; i < max; i++)
                {
                    int flag = 0;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                        Console.WriteLine(i);
                }
            }
            else
                Console.WriteLine("Invalid entry");
          


        }
    }
}
