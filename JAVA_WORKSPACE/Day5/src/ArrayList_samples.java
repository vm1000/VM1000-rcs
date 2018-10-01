import java.util.ArrayList;

public class ArrayList_samples{

	public static void main(String[] args) {
		
		int[] test = {-10, 1, 2, 3, 5, 66, 7, 100};
		test[0] = -100;
		
		ArrayList al = new ArrayList();
		al.add(-10);
		al.add(1);
		al.add(2);
		al.add(3);
		al.add(5);
		al.add(66);
		al.add(7);
		al.add(100);
		
		System.out.println("size: " + al.size());
	}


}
