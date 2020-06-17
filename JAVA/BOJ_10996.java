package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class BOJ_10996 {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		int n = Integer.parseInt(br.readLine());
		String top = "*";
		String bottom = "";
		boolean flag = false;
		
		for(int i = 0; i < n - 1; i++) {
			
			if(i%2 == 0) {
				bottom += " *";
				if(!flag) flag = true;
			}else {
				top += " *";
			}
		}
		
		for(int i = 0; i < n; i++) {
			System.out.println(top);
			if(flag) System.out.println(bottom);
		}
	}

}
