package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class BOJ_10039 {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int ave = 0;
		for(int i = 0; i < 5; i++) {
			int temp = Integer.parseInt(br.readLine());
			
			if(temp < 40) {
				temp = 40;
			}
			ave += temp;
		}
		
		System.out.println(ave/5);
	}

}
