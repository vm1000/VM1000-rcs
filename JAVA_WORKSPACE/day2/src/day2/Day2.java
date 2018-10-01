package day2;

import java.util.Scanner;

public class Day2 {

	public static void main(String[] args) {
		System.out.println("Ievadi savu vārdu: ");
		Scanner scanner = new Scanner(System.in);
		
		java.lang.String name = scanner.nextLine();
		System.out.println("Tu ievadiji: " + name);

		System.out.println("Ievadi skaitli: ");
		int number = scanner.nextInt();
		System.out.println("Tu ievadiji skaitli: " + number);
		
		
		scanner.close();
	}

}
