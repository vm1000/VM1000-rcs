import java.util.Random;
import java.util.Scanner;

public class uzd08 {

	public static void main(String[] args) {
		
		System.out.println("Ievadi skaitli: ");
//		
		Scanner scanner = new Scanner(System.in);
		int input = scanner.nextInt();
		int i = input;
		
		Random rdm = new Random();
		input = rdm.nextInt();
		
		if (i < 0)
		{
			for(int k = i; k <=0; k ++)
			{
				System.out.print(k + ",");
			}
		} 
		else 
		{
		for (int j = 0; j <= i; j++)
		{
			System.out.print(j + ",");
		}
		
		}
		

		scanner.close();
	}
}
