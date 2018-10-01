import java.util.Random;
import java.util.Scanner;

public class SortArray {

	public static void main(String[] args) {

		Scanner scanner = new Scanner(System.in);

		int masivuIzmers = 0;

		while (masivuIzmers <= 0) {

			System.out.println("Ievadi masīvu izmēru (20-40) ");
			masivuIzmers = scanner.nextInt();

			if (masivuIzmers < 20 || masivuIzmers > 40) {
				System.out.println("Masīvu izmērs var būt tikai 20 - 40 !");
			} else {

				int jaunsMasivs[] = new int[masivuIzmers];
				Random rand = new Random();
				for (int i = 0; i < masivuIzmers; i++) {
					jaunsMasivs[i] = 10 + rand.nextInt(90);
				}

				System.out.print("Random masīvs ar vērtībām 10 - 99: ");
				for (int i = 0; i < masivuIzmers; i++) {
					System.out.print(jaunsMasivs[i]);

					if (i < masivuIzmers - 1) {
						System.out.print(", ");
					}
				}

				System.out.println();
				System.out.println();

				System.out.print("Masīvs augošā secībā: ");
				for (int i = 0; i < masivuIzmers; i++) {

					for (int j = i + 1; j < masivuIzmers; j++) {
						if (jaunsMasivs[i] > jaunsMasivs[j]) {
							int liel = jaunsMasivs[i];
							jaunsMasivs[i] = jaunsMasivs[j];
							jaunsMasivs[j] = liel;
						}
					}

					System.out.print(jaunsMasivs[i]);
					if (i < masivuIzmers - 1) {
						System.out.print(", ");
					}
				}
			}
		}

		scanner.close();

	}
}
