using System;

namespace csharp
{
    class Test
    {
        public string getIssuer(long n)
        {
            string number = n.ToString();
            int size = number.Length;
            if(number[0] == '4' && (size == 13 || size == 16))
            {
                return "VISA";
            }
            else if(number[0] == '3' && (number[1] == '4' || number[1] == '7') && size == 15)
            {
                return "AMEX";
            }
            else if(number[0] == '6' && number[1] == '0' && number[2] == '1' && number[3] == '1' && size == 16)
            {
                return "Discover";
            }
            else if(number[0] == '5' && (number[1] >= '1' && number[1] <= '5' ) && size == 16)
            {
                return "Mastercard";
            }
            else
            {
                return "Unknown";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Test();
            Console.WriteLine(t.getIssuer(4111111111111111));
            Console.WriteLine(t.getIssuer(4111111111111));
            Console.WriteLine(t.getIssuer(4012888888881881));
            Console.WriteLine(t.getIssuer(378282246310005));
            Console.WriteLine(t.getIssuer(6011111111111117));
            Console.WriteLine(t.getIssuer(5105105105105100));
            Console.WriteLine(t.getIssuer(5105105105105106));
            Console.WriteLine(t.getIssuer(9111111111111111));
        }
    }
}
