import java.util.Scanner;

public class Homework02_task01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		System.out.println("Ievadi vārdu un uzvārdu ar atstarpi!");
		String nameAndSurename = scanner.nextLine();

		nameAndSurename = nameAndSurename.trim();

		int spaceIndex = nameAndSurename.indexOf(' ');

		if (spaceIndex > 0) {
			String name = nameAndSurename.substring(0, spaceIndex);
			name = name.substring(0, 1).toUpperCase() + name.substring(1).toLowerCase();

			String surname = nameAndSurename.substring(spaceIndex).trim().toUpperCase();
			if (surname.contains(" ")) {
				int firstSpace = surname.indexOf(" ");
				surname = surname.substring(0, surname.indexOf(" ")) + "-" + surname.substring(firstSpace).trim();
			}
			System.out.println("'" + name + "'");
			System.out.println("'" + surname + "'");
		} else {
			System.out.println("nepareiza ievade");
		}

		scanner.close();
	}

}
