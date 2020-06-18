package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class BOJ_1065 {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int num = Integer.parseInt(br.readLine());
		
		System.out.println(solv(num));
		
	}

	static int solv(int n) {

		int count = 0;
		
		for(int i = 1; i <= n; i++) {
			if(Sequence(i)) count++;
			
		}
		
		return count;
	}
	
	static boolean Sequence(int c) {
		
		if(c < 100) return true;
		
		int digit = String.valueOf(c).length();
		int div = 0;
		int d_temp = 1001;
		int calc = 1001;
		int c_temp = c;
		
		for(int i = digit-1; i >= 0; i--) {
			int ctn = (int)Math.pow(10, i);
			div= c_temp / ctn;
			c_temp %= ctn;
			
			if(d_temp == 1001) {
				d_temp = div;
				continue;
			}
			
			if(calc == 1001) {
				calc = div - d_temp;
			}else if(calc != (div - d_temp)) {
				return false;
			}
			d_temp = div;
		}
		
		return true;
	}
}




