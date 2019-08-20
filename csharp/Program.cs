using System;

namespace csharp
{   
    class Program
    {

        static string GetIssuer(Int64 card)
        {
            string num = Convert.ToString(card);;
            int num_aux;

            if ((num.Substring(0,2) == "34" || num.Substring(0, 2) == "37") && (num.Length == 15))
            {
                return "AMEX";
            }
            else
            {
                if (num.Substring(0, 4) == "6011" && num.Length == 16)
                {
                    return "DISCOVER";
                }
                else
                {
                    num_aux = Convert.ToInt32(num.Substring(0, 2));
                    if ((num_aux>50 && num_aux<56) && (num.Length == 16))
                    {
                        return "MASTERCARD";
                    }
                    else
                    {
                        if (num.Substring(0, 1) == "4" && (num.Length >12 && num.Length <17) )
                        {
                            return "VISA";
                        }
                        else
                        {
                            return "UNKNOWN";
                        }
                    }
                }
            }
        }
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
