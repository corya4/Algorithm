package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class BOJ_2884 {

	public static void main(String[] args) throws IOException {
		int[] clock = Arrays.asList(new BufferedReader(new InputStreamReader(System.in)).readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		
		if(clock[1] < 45) {
			clock[1] = 60 - (45 - clock[1]);
			clock[0]--;
			if(clock[0] < 0) {
				clock[0] = 23;
			}
		}else {
			clock[1] -= 45;
		}
		
		System.out.println(clock[0] + " " + clock[1]);
	}

	
}
