package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class BOJ_5543 {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
	
		int minB = 2100;
		int minD = 2100;
		
		for(int i = 0; i < 5; i++) {
			int temp = Integer.parseInt(br.readLine());
			if(i <= 2) {
				
				if(minB > temp) {
					minB = temp;
				}
				
			}else {
				
				if(minD > temp) {
					minD = temp;
				}
				
			}
		}
		System.out.println(minB + minD - 50);

	}

}
