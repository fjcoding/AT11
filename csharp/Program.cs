using System;

namespace csharp
{   
    class Program
    {
        static string getIssuer(long longNumber)
        {
            string number = longNumber.ToString();
            char firstDigit = number[0];
            char secondDigit = number[1];
            char thirdDigit = number[2];
            char fourthDigit = number[3];
            int size = number.Length;
            if(firstDigit == '4' && (size == 13 || size == 16))
            {
                return "VISA";
            }
            else if(firstDigit == '3' && (secondDigit == '4' || secondDigit == '7') && size == 15)
            {
                return "AMEX";
            }
            else if(firstDigit == '6' && secondDigit == '0' && thirdDigit == '1' && fourthDigit == '1' && size == 16)
            {
                return "Discover";
            }
            else if(firstDigit == '5' && (secondDigit >= '1' && secondDigit <= '5' ) && size == 16)
            {
                return "Mastercard";
            }
            else
            {
                return "Unknown";
            }
        }

        static void Main(string[] args)
        {
            // var t = new Test();
            Console.WriteLine(getIssuer(4111111111111111));
            Console.WriteLine(getIssuer(4111111111111));
            Console.WriteLine(getIssuer(4012888888881881));
            Console.WriteLine(getIssuer(378282246310005));
            Console.WriteLine(getIssuer(6011111111111117));
            Console.WriteLine(getIssuer(5105105105105100));
            Console.WriteLine(getIssuer(5105105105105106));
            Console.WriteLine(getIssuer(9111111111111111));
        }
    }
}
