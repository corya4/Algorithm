package IGRUS_Newbie;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class A {

	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		int[] iArr = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();

		int n, m;
		n = iArr[0];
		m = iArr[1];
		
		if (n < 3) return;
		
		if(m == 1 || m == 2) {
			System.out.println("NEWBIE!");
		}else if(m <= n) {
			System.out.println("OLDBIE!");
		}else {
			System.out.println("TLE!");
		}
	}

}
