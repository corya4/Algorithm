
package JAVA;

import java.util.Arrays;
import java.util.Scanner;

public class BOJ_1546 {
	
	public static void main(String[] args) {
		
	Scanner sc = new Scanner(System.in);
	int[] scores = new int[sc.nextInt()];
	sc.nextLine();
	String[] str = sc.nextLine().split(" ");
		
	scores = Arrays.asList(str).stream().mapToInt(Integer::parseInt).toArray();
	
	float max = 0;
	for(int i = 0; i < scores.length; i++) {
		if(max < scores[i]) {
			max = scores[i];
		}
	}
	float avg = 0;
	for(int i = 0; i < scores.length; i++) {
		
		avg += (scores[i]*100)/max;
	}
	
	float length = scores.length;
	
	avg = avg/length;
			
	System.out.println(avg);
	
	}

}