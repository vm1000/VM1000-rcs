package day2;

import java.util.Scanner;

public class uzd {

	public static void main(String[] args) {
		
		
		System.out.println("Ievadi pirmo tekstu ");
		Scanner scanner = new Scanner(System.in);
		String firstText = scanner.nextLine();

		System.out.println("Ievadi otro tekstu ");
		String secondText = scanner.nextLine();
		
		if(firstText.length() > secondText.length())
		{
		System.out.println(firstText + secondText);
		}
		else
		{
			System.out.println(secondText + firstText);
		}
		
		scanner.close();
	}
}
