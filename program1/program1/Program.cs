using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NumArray = new int[10];
            int j = 0;
           for(int i=1;i<=10;i++)
            {
                int num=Convert.ToInt32(Console.ReadLine());
                if (num % 7 == 0)
                {
                    NumArray[j] = num;
                    j++;
                }
                 
            }
           for(int i=0;i<j;i++)
            {
                Console.WriteLine(NumArray[i]);
            }
        }
    }
}
