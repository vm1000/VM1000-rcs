import java.util.Random;

public class ClassExample {

	public static int counter;
	
	public int z;
	
	public ClassExample() {
		z = new Random().nextInt(100) + 1;
		counter ++;
		
		System.out.println("counter: " + ClassExample.counter);
	}
	
	public void printZ() {
		z--;
		System.out.println(z);
	}
	
}
