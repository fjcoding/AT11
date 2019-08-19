public class Main {
	//Credit Card
	public static void main (String[] args){

		//String texto="378282246310005";
		//String texto="4012888888881881";
		//String texto="5105105105105100";
		String texto="6011111111111117";
		System.out.println(getIssuer(texto));
	}

	public static String getIssuer (String texto){
		int size_number=texto.length();
		String answer="none";
		char first_letter=texto.charAt(0); //Character
		char second_letter=texto.charAt(1);
		switch (first_letter){
			case '3':
			if (size_number==15){
				if (second_letter=='4' || second_letter=='7')
					answer="AMEX";
			}
			break;
			case '4':
			if (size_number==13 || size_number==16)
				answer="VISA";
			break;
			case '5':
			if (size_number==16){
				if (second_letter=='1' || second_letter=='2' || second_letter=='3' || second_letter=='4' || second_letter=='5')
					answer="Mastercard";
			}
			break;
			case '6':
			if (size_number==16)
				answer="Discover";
			break;
			default:
				answer="Unknown";
			break;
			
		}// switch 
		return answer;
	}// function
}

