//import java.util.Scanner;

public class metodes_un_cits {

	public static void main(String[] args) {

//		cubeNumber();

		smallestNumber(3,55,6);
		
//		int kkadsMasivs[] = {7, 11};
//		
//		averageArr(kkadsMasivs);
	}
	
	public static int cubeNumber(int kapinasana) {
//		Scanner scanner = new Scanner(System.in);
//		System.out.println("Ievadi skaitli");
//		int a = scanner.nextInt();
//		int kapinasana = a * a * a;
//		
//		System.out.println(kapinasana);
		
		return kapinasana * kapinasana * kapinasana;
	}
	
	
	public static int smallestNumber(int x, int y, int z) {
//		Scanner scanner = new Scanner(System.in);
//		System.out.println("Ievadi 1. skaitli");
//		int a = scanner.nextInt();
//		System.out.println("Ievadi 2. skaitli");
//		int b = scanner.nextInt();
//		System.out.println("Ievadi 3. skaitli");
//		int c = scanner.nextInt();
//		
//		
//		int theSmallest = 0;
//		return theSmallest;
		
		
		if(x < y && x < z) {
			return x;
		} else if(y < x && y < z) {
			return y;
		} else {
			return z;
		}		
	}
	
	
	public static double averageArr( int[] allNumbers) {
		
		double numbersSum = 0.0;
		
		for(int i = 0; i < allNumbers.length; i++)
		{
			numbersSum = allNumbers[i] + numbersSum;
		}
		
		double averageOfNumbers = numbersSum / allNumbers.length;
		
		System.out.println(averageOfNumbers);
		
		return averageOfNumbers;
	}
}
