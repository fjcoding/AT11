using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Credit Card number");
            string numberCard = Console.ReadLine();
            Console.WriteLine(getIssuer(numberCard));
        }

        public static string getIssuer(string numberCard)
        {
            string op1 = numberCard[0].ToString();
            string op2 = numberCard[1].ToString();

            switch (op1)
            {
                case "4":
                {
                    if ((numberCard.Length==16) || (numberCard.Length==13))
                    {
                        return "Credit Card Visa";
                    }
                break;
                }
                case "3":
                {
                    if (((op2=="4") || (op2 == "7")) && (Credit Card.Length == 15))
                    {
                        return "Credit Card AMEX";
                    }
                break;
                }
                case "5":
                {
                    if (((op2 == "1") || (op2 == "2") || (op2 == "3") || (op2 == "4") || (op2 == "5")) && (numberCard.Length == 16))
                    {
                        return "Credit Card MasterCard";
                    }
                break;
                }
                case "6":
                {
                    if (((numberCard[1].ToString() == "0") && (numberCard[2].ToString() == "1") || (numberCard[3].ToString() == "1") ) && (numberCard.Length == 16))
                    {
                        return "Credit Card Discovery";
                    }
                break;
                }
            }
            return "Unknown";
        }
    }
}
