import java.util.Scanner;

public class uzd_09 {

	public static void main(String[] args) {
		
//		saņem 2 vērtības un aizskaita no pirmās vērtības līdz otram augošā secībā
		
		Scanner scanner = new Scanner(System.in);
		
		System.out.println("Ievadiet 2 skaitļus: ");
		int x = scanner.nextInt();
		int y = scanner.nextInt();
		
		
		for(int i = x; i <= y; i++)
		{
			
			System.out.println(i);
		}
		
		System.out.println();
		
		scanner.close();
	}

}
