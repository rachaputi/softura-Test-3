using System;

namespace CreditCardValidation
{
    class Program
    {
        public long CreditCardNumber { get; set; }
        
        public int Cvv { get; set; }

        public string StrCvv { get; set; }

        public string ExpiryDate { get; set; }

        public string StrCreditCard { get; set; }

        int[] arr = new int[16];

   
        int flagCardLength=0,flagCardCvv=0,temp=0,sum=0,flagCardNumber=0,Total=0;


        public void CardValidation()
        {
            if (StrCreditCard.Length < 15)
            {
                Console.WriteLine("Invalid Card Number. Card length must be 15 or 16");
                flagCardLength = 1;
                
            }
                
            if (StrCvv.Length!=3)
            {
                Console.WriteLine("Invalid CVV Number");
                flagCardCvv = 1;
            }
            while(CreditCardNumber!=0)
            {
                int i = 0;
                int remainder = Convert.ToInt32(CreditCardNumber % 10);
                arr[i] = remainder;
                CreditCardNumber = CreditCardNumber / 10;
                i++;

            }
            for(int i=0;i<arr.Length;i++)
            {
                if (i % 2 == 1)
                    arr[i] = arr[i] * 2;
            }
            for(int i=0;i<arr.Length;i++)
            {
                sum = 0;
                if (arr[i] > 9)
                    temp = arr[i];
                   
                    while(temp!=0)
                    {
                      int r = temp % 10;
                      sum = sum + r;
                    }
                    arr[i] = sum;
            }
            for(int i=0;i<arr.Length;i++)
            {
                Total = Total + arr[i];
            }
            if (Total % 10 == 0)
                Console.WriteLine("Valid Card Number");
            else
            {
                Console.WriteLine("Invalid card Number");
                flagCardNumber = 1;
            }       

        }
        public void ValidateAllInputs()
        {
            if (flagCardCvv == 0 & flagCardNumber == 0 & flagCardLength == 0)
                Console.WriteLine("Congragulations!! You Card is Valid");
            else
                Console.WriteLine("Inavlid Card Details !! Please check the enter details");

        }


        public void UserInput()
        {
             Console.WriteLine("Enter Your Credit Card Number");
            StrCreditCard = Console.ReadLine();
            CreditCardNumber = long.Parse(StrCreditCard);
            Console.WriteLine("Enter Your Card Cvv");
            StrCvv = Console.ReadLine();
            Cvv = Convert.ToInt32(StrCvv);
        }
        public static void Main(string[] args)
        {
            Program CardHolder1 = new Program();
            CardHolder1.UserInput();
            CardHolder1.CardValidation();
            CardHolder1.ValidateAllInputs();

        }

    }
}
