import java.util.Scanner;

public class uzd_7_day4 {

	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		System.out.println("Ievadi vienu burtu");
		
		
		String Divskanis[] = {"o"};
		
		String Patskaņi[] = {"a", "ā", "e", "ē", "i", "ī", "u", "ū"};
		
		String Lidzskani[] = {"b", "c", "č", "d", "f", "g", "ģ", "h", "j", 
	"k", "ķ", "l", "ļ", "m", "n", "ņ", "p", "r", "s", "š", "t", "v", "z", "ž"};
		
		
		
		String burts = scanner.nextLine();
		
		if(burts == "o")
		{
			System.out.println("Divskanis");
		} else if(burts == "a"|| burts == "ā"|| burts == "e"|| 
		burts == "ē"|| burts == "i"|| burts == "ī"|| burts == "u"|| burts == "ū") {
			System.out.println("Patskanis");
		} else if(burts == "b"||burts == "c"||burts == "č"|| burts =="d"||burts == "f"||burts == "g"||burts == "ģ"||burts == "h"||burts == "j"||burts == 
				"k"||burts == "ķ"||burts == "l"||burts == "ļ"||burts == "m"||burts == "n"||burts == "ņ"||burts == "p"||burts == "r"||burts == "s"||burts == "š"||burts == "t"||burts == "v"||burts == "z"||burts == "ž")
		{
			System.out.println("Lidzskanis");
		} else {
			System.out.println("Nepareiza ievade");
		}
	}

}
