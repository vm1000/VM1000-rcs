 
public class Rectangle {

	private int length;
	private int width;
	
	public Rectangle() {
		
	}
	
	public Rectangle(int garums, int platums) {
		length = garums;
		width = platums;
	}
	
	public Rectangle(int mala) {
		this(mala,mala);
	}
	
	
	
	public Boolean isSquare() {
		Boolean answer = (length == width);
		
//		if(garums == platums) {
//			answer = (true);
//		} else {
//			answer = (false);
//		}
		return answer;
	}
	
	
	public int area() {
		
		int area = length * width;
		
		return area;
	}
	

	
	public int perimeter() {
		int perimeter = (2 * length) + (2 * width);
		
		return perimeter;
	}

	
	public int getLength() {
		return length;
	}
	
	public void setLength(int length) {
		if(length <0) {
			return;
		} 
		this.length = length;
	}
}
