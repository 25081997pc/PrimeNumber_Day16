using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class CheckPalindrome
    {
        public void CheckPrimeIsPalindrome(int PrimeNumber)
        {
            int remainder, reverse = 0;
            int pn = PrimeNumber;

            while(pn > 0)
            {
                remainder = pn % 10;
                pn = pn / 10;
                reverse = reverse * 10 + remainder;
            }
            if(reverse == PrimeNumber)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not Palindrome");
            }
        }
        
    }
}
