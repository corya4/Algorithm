
package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.StringTokenizer;


public class BOJ_11399 {
	
	public static void main(String[] args) throws IOException {
		BufferedReader rd = new BufferedReader(new InputStreamReader(System.in));
		int length = new Integer(rd.readLine()).intValue();
		int[] customer = new int[length];
		StringTokenizer st = new StringTokenizer(rd.readLine()," ");
		int[] time = new int[customer.length];
		for(int i = 0; i < time.length; i++) {
			time[i] = new Integer(st.nextToken()).intValue();
			customer[i] = time[i];
		}
		int sum = 0;
		int totalWaiting = 0;
		
		for(int i = 0; i < customer.length-1; i++) {
			for(int j = i; j < customer.length; j++) {
				if(customer[i] > customer[j]) {
					int temp = customer[i];
					customer[i] = customer[j];
					customer[j] = temp;
				}
			}
		}
		
		
		for(int i = 0; i < customer.length; i++) {
			sum +=customer[i];
			totalWaiting += sum;
		}
		System.out.println(totalWaiting);
	}
} 