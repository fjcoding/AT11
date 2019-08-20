﻿using System;

namespace csharp
{
    public class Program
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

        public static void getIssuer(String number)
        {
            String onefirstLetterCreditCatd = numberCreditCard.Substring(0, 1);
            String twoFirstsLettersCreditCatd = numberCreditCard.Substring(0, 2);
            String fourFirstsLettersCreditCatd = numberCreditCard.Substring(0, 4)
            if(number.Length == 13 || number.Length == 16)
            {
                verifyVisa(onefirstLetterCreditCatd);
            }
            if(number.Length ==15)
            {
                verifyAmex(twoFirstsLettersCreditCatd);
            }
            if(number.Length ==16)
            {
                verifyDiscover(fourFirstsLettersCreditCatd);
                verifyMasterCard(twoFirstsLettersCreditCatd);
            }
            verifyExistence(creditCardFinder);
        }
        public static void verifyVisa(String numberCreditCard)
        {
            if(numberCreditCard.Equals("4"))
            {
                Console.WriteLine("Visa");
                creditCardFinder = true;
            }
        }
        public static void verifyAmex(String numberCreditCard)
        {
            if(numberCreditCard.Equals("34") || numberCreditCard.Equals("37"))
            {
                Console.WriteLine("AMEX");
                creditCardFinder = true;
            }
        }
        public static void verifyDiscover(String numberCreditCard)
        {
            if(numberCreditCard.Equals("6011"))
            {
                Console.WriteLine("Discover");
                creditCardFinder = true;
            }
        }
        public static void verifyMasterCard(String numberCreditCard)
        {
            if(numberCreditCard.Equals("51"))
            {
                Console.WriteLine("Mastercard");
                creditCardFinder = true;
            }
        }
        public static void verifyExistence(bool finderNumberCreditCard)
        {
            if(finderNumberCreditCard == false)
            {
                Console.WriteLine("unknown");
            }
            else
            {
                Console.WriteLine("Well Done!");
                creditCardFinder = false;
            }
        }
    }
}
