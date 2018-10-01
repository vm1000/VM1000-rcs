package day2;

import java.util.Random;

public class masivi_04_diena {
	
	public static void main(String[] args) {
		
		Random rnd = new Random();
		
		int[] ints = new int[400];
		
		for(int i = 0; i<ints.length; i++)
		{
			ints[i] = rnd.nextInt(101);
		}
		
		int[] counters = new int[101];
		
		for(int i = 0; i<ints.length; i++)
		{ 
			int cIndex = ints[i];
			counters[cIndex] ++;
			
			System.out.println(" " + i + " : " + ints[i]);
		}
		
		System.out.println("------------------------");
		
		int max = 0;
		int maxIndex = -1;
		for(int i = 0; i<counters.length; i++) {
			if(counters[i] > max) {
				max = counters[i];
				maxIndex = i;
			}
			System.out.println("" + i + " : " + counters[i]);
		}
		
		System.out.println("max: " + max + " number: " + maxIndex);
		
	}

}
