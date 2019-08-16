using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero de tarjeta de credito");
            string numeroTarjeta = Console.ReadLine();
            Console.WriteLine(getIssuer(numeroTarjeta));

        }

        public static string getIssuer(string tarjeta)
        {
            string op1 = tarjeta[0].ToString();
            string op2 = tarjeta[1].ToString();
            switch (op1)
            {
                case "4":
                    {
                        if ((tarjeta.Length==16) || (tarjeta.Length==13))
                        {
                            return "Tarjeta Visa";
                        }
                        break;
                    }
                case "3":
                    {
                        if (((op2=="4") || (op2 == "7")) && (tarjeta.Length == 15))
                        {
                            return "Tarjeta AMEX";
                        }
                        break;
                    }
                case "5":
                    {
                        if (((op2 == "1") || (op2 == "2") || (op2 == "3") || (op2 == "4") || (op2 == "5")) && (tarjeta.Length == 16))
                        {
                            return "Tarjeta MasterCard";

                        }
                        break;
                    }
                case "6":
                    {
                        if (((tarjeta[1].ToString() == "0") && (tarjeta[2].ToString() == "1") || (tarjeta[3].ToString() == "1") ) && (tarjeta.Length == 16))
                        {
                            return "Tarjeta Discovery";

                        }
                        break;
                    }
            }
            return "Unknown";
        }

    }
}
