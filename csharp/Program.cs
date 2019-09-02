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
            string indice1 = numberCard[0].ToString();
            string indice2 = numberCard[1].ToString();

            switch (indice1)
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
                    if (((indice2=="4") || (indice2 == "7")) && (numberCard.Length == 15))
                    {
                        return "Credit Card AMEX";
                    }
                break;
                }
                case "5":
                {
                    if (((indice2 == "1") || (indice2 == "2") || (indice2 == "3") || (indice2 == "4") || (indice2 == "5")) && (numberCard.Length == 16))
                    {
                        return "Credit Card MasterCard";
                    }
                break;
                }
                case "6":
                {
                    if (((indice1 == "0") && (indice2.ToString() == "1") || (numberCard[3].ToString() == "1") ) && (numberCard.Length == 16))
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
