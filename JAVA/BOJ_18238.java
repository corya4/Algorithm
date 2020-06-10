
package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class BOJ_18238 {

	public static void main(String[] args) throws IOException {
		char[] circle = new char[26];
		for(int i = 0; i < circle.length; i++) {
			circle[i] = (char)(65+i);
		}
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String str = br.readLine();
		
		int arrow = 0;
		int sum = 0;
		for(int j = 0; j < str.length(); j++) {
			char sr = str.charAt(j);
			int front = 0; int back = 0;
			int b = arrow;
			while(circle[b] != sr) {
				front++;
				b++;
				if(b > circle.length-1) b = 0;
			}
			
			int c = arrow;
			while(circle[c] != sr) {
				back++;
				c--;
				if(c < 0) c = circle.length-1;
			}
			
			sum += (front>back)?back:front;
			arrow = sr- 65;
		}
		System.out.println(sum);
	}

}