import java.util.Scanner;

public class Homework02_tast02 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);

		System.out.println("Ievadi datumu: ");
		int date = scanner.nextInt();
		if (date > 31 || date < 1) {
			System.out.println("Nepareiza ievade");
		}
//		else {
//			System.out.println(date);
//		}

		System.out.println("Ievadi mēnesi: ");
		int month = scanner.nextInt();
		if (month < 1 || month > 12) {
			System.out.println("Nepareiza ievade  ");
		}
//		else {
//			System.out.println(month);
//		}



		switch (date) {
		case 31:
			if (month == 2 || month == 4 || month == 6 || month == 9 || month == 11) {
				System.out.println("Dotajā mēnesī nav 31 diena!");
			} else {
				System.out.println(date);
			}
			break;

		case 29:
			if (month == 2) {
				System.out.println("Februārī nav 29 dienas! (izņēmums ir garais gads)");
			} else {
				System.out.println(date);
			}
			break;

		case 30:
			if (month == 2) {
				System.out.println("Februārī nav 30 dienas!");
			} else {
				System.out.println(date);
			}
			break;

		default:
			break;
		}

		String allMonths[] = { "Janvāris", "Februāris", "Marts", "Aprīlis", "Maijs", "Jūnis", "Jūlijs", "Augusts",
				"Septembris", "Oktobris", "Novembris", "Decembris" };

		while (date >= 1 && date <= 28) {
			System.out.print(date + ".");
			System.out.print(" " + allMonths[month - 1]);
			break;
		}
//		{
//			System.out.print("Datums tika ievadīts nepareizi!");
//		}

		

		if (date > 31 || date < 1) {
			System.out.println("Nepareiza ievade");
		} else if (month < 1 || month > 12) {
			System.out.println("Nepareiza ievade");
		}

		System.out.println();
		System.out.println("Ievadiet Gadu: ");
		int year = scanner.nextInt();
		if (year % 4 == 0) {
			System.out.println(year + "  ir garais gads!");
		} else {
			System.out.println(year + "  Nav garais gads!");
		}
		
		scanner.close();
	}

}
