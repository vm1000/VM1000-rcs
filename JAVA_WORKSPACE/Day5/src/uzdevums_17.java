import java.util.ArrayList;
import java.util.Scanner;

public class uzdevums_17 {

	public static void main(String[] args) {
	
		ArrayList <String> arrayList = new ArrayList<>(3);
		
		arrayList.add("gg");
		arrayList.add("kmg");
		arrayList.add("LmKm");
		arrayList.add("goog");
		
		System.out.print(arrayList + "-->");
		
		for(int i = 0; i < arrayList.size(); i++)
		{
			String item = arrayList.get(i);
					if(item.length()>2) {
						item = item.toUpperCase();
						arrayList.set(i, item);
					}
			
//			System.out.println(" " + i + " : " + item.toUpperCase());
			
		}
		System.out.println(arrayList);
		
		
//		System.out.println("Ievadiet vērtības");
//		System.out.println();
		
//		Scanner scanner = new Scanner(System.in);
//		
//		String vertiba = arrayList.toString();
//		
//		
		
////		System.out.println(arrayList);
//		//		System.out.println(vertiba);
		
//		arrayList.replaceAll(String::toUpperCase);

	}

}
