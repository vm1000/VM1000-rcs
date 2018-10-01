
public class exampleRectangle {

	public static void main(String[] args) {

		Rectangle rec = new Rectangle(5, 4);
		System.out.println("isSquare -> " + rec.isSquare());
		System.out.println("area -> " + rec.area());
		System.out.println("perimeter -> " + rec.perimeter());
		System.out.println(rec.toString());
//		int length = rec.getLength();
//		length = 1000;
		System.out.println();

		Rectangle rec2 = new Rectangle(3, 8);
		System.out.println("isSquare -> " + rec2.isSquare());
		System.out.println("area -> " + rec2.area());
		System.out.println("perimeter -> " + rec2.perimeter());
		System.out.println(rec2.toString());
		System.out.println();

		Rectangle rec3 = new Rectangle(6, 6);
		System.out.println("isSquare -> " + rec3.isSquare());
		System.out.println("area -> " + rec3.area());
		System.out.println("perimeter -> " + rec3.perimeter());
		System.out.println(rec3.toString());
		System.out.println();

	}

}
