package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class BOJ_2523 {

	public static void main(String[] args) throws NumberFormatException, IOException {
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int length = Integer.parseInt(br.readLine());
		String star = "";
		for(int i = 0; i < length; i++) {
			star += "*";
			System.out.println(star);
		}
		
		String temp_star = "";
		for(int j = 1; j < length; j++) {
			temp_star = star.substring(j);
			System.out.println(temp_star);
		}
	}

}
