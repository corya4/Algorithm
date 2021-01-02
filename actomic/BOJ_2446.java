package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class BOJ_2446 {

	public static void main(String[] args) throws NumberFormatException, IOException {
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int length = Integer.parseInt(br.readLine());
		
		for(int i = 0; i < length; i ++) {
			String star = "";
			
			for(int j = 0; j < i; j++) {
				star += " ";
			}
			
			star += "*";
			for(int z = i; z < length-1; z++) {
				star += "**";
			}
			
			System.out.println(star);
		}

		for(int i = length-1; i > 0; i--) {
			String star = "";
			
			for(int j = 1; j < i; j++) {
				star += " ";
			}
			
			star += "*";
			for(int z = i-1; z < length-1; z++) {
				star += "**";
			}
			
			System.out.println(star);
		}
	}

}




