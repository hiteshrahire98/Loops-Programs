using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Programs
{
    internal class Armstrongnumber                    // WAP to accept a number from user & find the number is Armstrong number .
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to check Armstrong: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int n1, rem, sum = 0;
            n1 = n;

            while (n > 0)
            {
                rem = n % 10;
                sum = sum + (rem * rem * rem);
                n = n / 10;
            }

            if (n1 == sum)
            {
                Console.WriteLine("NUmnber is Armstrong");
            }
            else
            {
                Console.WriteLine(" Number is not Armstrong");
            }




            /*

             Console.WriteLine("Enter a number to check Armstrong:");
             int num = Convert.ToInt32(Console.ReadLine());
             int rem;
             int cube;
             int result = 0;
             int temp = num;

             while (num != 0)
             { 
                 rem=num% 10;
                 cube = rem * rem * rem;
                 result= result+cube;
                 num = num / 10;
             }
             num = temp;
             if (num == result)
             {
                 Console.WriteLine("Given Number is Armstrong");
             }
             else
             {
                 Console.WriteLine("Given Number is Not Armstrong");

             }  
             */




        }

    }
}
