using System;

namespace Program5
{
    class Program
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        int count = 1;
        public void TakingInput()
        {
            Console.WriteLine("Please enter the username");
            UserName = Console.ReadLine();
            Console.WriteLine("Please enter the password");
            Password = Console.ReadLine();
            if (UserName == "Admin" & Password == "admin")
                Console.WriteLine("welcome");
            else
            {
                Console.WriteLine("Try Again");
                if (count < 3)
                {
                    count=count+1;
                    TakingInput();
                }
                    
                else
                    Console.WriteLine("Sorry you have already tried 3 times");

            }

        }
        public static void Main(string[] args)
        {
            // program.TakingInput();

            Program obj = new Program();
            obj.TakingInput();

           
               
        }

    }

}
