import java.util.Scanner;

public class PrimeGenerator {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		int count = 0;

		while (count < 1 || count > 100) {
			System.out.println("Ievadi, cik pirmskaitļus vēlies uzģenerēt: ");
			count = sc.nextInt();

			if (count < 1 || count > 100) {
				System.out.println("Nepareiza ievade, lūdzu ievadiet no 1 līdz 100! ");
			}
		}

		int[] pirmsSk = new int[count];

		int dalitajs = 0;
		int number = 1;
		int i = 0;

		while (i < pirmsSk.length) {
			dalitajs = 0;

			for (int j = 2; j < number; j++) {
				if (number % j == 0) {
					dalitajs = 1;
				}
			}

			if (dalitajs == 0) {
				pirmsSk[i] = number;
				System.out.print(pirmsSk[i] + ", ");
				i++;
			}
			number++;
		}
	}
}
