using System;
using System.Collections.Generic;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            var NumberList = new List<int>();
            int input = Convert.ToInt32(Console.ReadLine());
            while(input>0)
            {
                NumberList.Add(input);
                input= Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Repeated Numbers are:");
            for(int i=0;i<NumberList.Count;i++)
            {
                for(int j=i+1;j<NumberList.Count;j++)
                {
                    if(NumberList[i]==NumberList[j])
                    {
                        Console.WriteLine(NumberList[i]);
                    }
                }
            }
            

            
         
        }
    }
}
