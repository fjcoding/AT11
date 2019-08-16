class Test
    {
        String getIssuer(long n)
        {
            String number = Long.toString(n);
            int size = number.length();
            if(number.charAt(0) == '4' && (size == 13 || size == 16))
            {
                return "VISA";
            }
            else if(number.charAt(0) == '3' && (number.charAt(1) == '4' || number.charAt(1) == '7') && size == 15)
            {
                return "AMEX";
            }
            else if(number.charAt(0) == '6' && number.charAt(1) == '0' && number.charAt(2) == '1' && number.charAt(3) == '1' && size == 16)
            {
                return "Discover";
            }
            else if(number.charAt(0) == '5' && (number.charAt(1) >= '1' && number.charAt(1) <= '5' ) && size == 16)
            {
                return "Mastercard";
            }
            else
            {
                return "Unknown";
            }
        }
    }
    
public class Main 
{
    public static void main(String[] args)
    {
        Test t = new Test();
        System.out.println(t.getIssuer(4111111111111111l));
        System.out.println(t.getIssuer(4111111111111l));
        System.out.println(t.getIssuer(4012888888881881l));
        System.out.println(t.getIssuer(378282246310005l));
        System.out.println(t.getIssuer(6011111111111117l));
        System.out.println(t.getIssuer(5105105105105100l));
        System.out.println(t.getIssuer(5105105105105106l));
        System.out.println(t.getIssuer(9111111111111111l));
    }
}