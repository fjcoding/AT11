public class Main 
{
    static String getIssuer(long longNumber)
    {
        String number = Long.toString(longNumber);
        char firstDigit = number.charAt(0);
        char secondDigit = number.charAt(1);
        char thirdDigit = number.charAt(2);
        char fourthDigit = number.charAt(3);
        int size = number.length();
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

    public static void main(String[] args)
    {
        System.out.println(getIssuer(4111111111111111l));
        System.out.println(getIssuer(4111111111111l));
        System.out.println(getIssuer(4012888888881881l));
        System.out.println(getIssuer(378282246310005l));
        System.out.println(getIssuer(6011111111111117l));
        System.out.println(getIssuer(5105105105105100l));
        System.out.println(getIssuer(5105105105105106l));
        System.out.println(getIssuer(9111111111111111l));
    }
    
}
