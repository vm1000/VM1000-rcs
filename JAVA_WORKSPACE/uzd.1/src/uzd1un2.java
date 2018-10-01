import java.util.Scanner;

public class uzd1un2 {

	public static void main(String[] args) {

		System.out.println("Ievadi pirmo skaitli: ");
		Scanner scanner = new Scanner(System.in);
		int i = scanner.nextInt();

		System.out.println("Ievadi otro skaitli: ");
		int j = scanner.nextInt();

		if (i + j >= 10 && i + j <= 19) {
			System.out.println("Jūsu skaitļu summa: " + 20);
		} else {
			System.out.println("Jūsu skaitļu summa: " + (i + j));
		}

		System.out.println();
		System.out.println("otrais uzd ");
		System.out.println();

		System.out.println("Ievadi pirmo skaitli: ");
		double k = scanner.nextInt();

		System.out.println("Ievadi otro skaitli: ");
		double l = scanner.nextInt();

		System.out.println("Ievadi trešo skaitli: ");
		double m = scanner.nextInt();

		System.out.println("Jūsu skaitļu vidējā vērtība: " + (k + l + m) / 3.0);

		System.out.println();
		System.out.println("piektais uzd ");
		System.out.println();

		System.out.println("Ievadi pirmo skaitli: ");
		int o = scanner.nextInt();

		System.out.println("Ievadi otro skaitli: ");
		int p = scanner.nextInt();

		System.out.println("Ievadi trešo skaitli: ");
		int r = scanner.nextInt();

		if (p == o && p == r && o == r) {
			System.out.println("Jūsu skaitļu summa: " + "0" + " jo visi skaitļi vienadi");
		} else if (o == r) {
			System.out.println("Jūsu skaitļu summa: " + p + " jo pirmais un trešais skaitlis sakrīt");
		} else if (p == o) {
			System.out.println("Jūsu skaitļu summa: " + r + " jo pirmais un otrais skaitlis sakrīt");
		}

		else if (r == p) {
			System.out.println("Jūsu skaitļu summa: " + o + " jo otrais un trešais skaitlis sakrīt");
		} else {
			System.out.println("Jūsu skaitļu summa: " + (o + p + r));
		}

		scanner.close();
	}

}
