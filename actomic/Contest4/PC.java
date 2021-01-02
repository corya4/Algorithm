package Contest4;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class PC {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		int s = Integer.parseInt(br.readLine());
		int count = 0;
		
		while(s != 0) {
			count += br.readLine().length();
			s--;
		}
		System.out.println(count);
	}

}
