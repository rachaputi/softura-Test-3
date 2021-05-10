using System;
using System.Collections.Generic;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            var NumberList = new List<int>();
            int input = Convert.ToInt32(Console.ReadLine());
            while(input!=0)
            {
                if (input > 0)
                    NumberList.Add(input);
                input = Convert.ToInt32(Console.ReadLine());

            }
            NumberList.Sort();
            foreach (var item in NumberList)

            {
                Console.WriteLine(item);
            }
        }
    }
}
