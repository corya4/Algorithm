package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.StringTokenizer;

public class BOJ_1006 {
	
	static BufferedReader br;
	static int n, w;
	static int table[][];
	static int a[], b[], c[];
	
	public static void main(String[] args) throws NumberFormatException, IOException {
		br = new BufferedReader(new InputStreamReader(System.in));
		
		int tc = Integer.parseInt(br.readLine());
		
		while(tc-- != 0) {
			solve();
			
		}
	}
	
	static void solve() throws IOException {
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");
		n = Integer.parseInt(stn.nextToken());
		w = Integer.parseInt(stn.nextToken());
		
		a = new int[n]; b = new int[n]; c = new int[n];
		table = new int[2][n];
		
		for(int i = 0; i < table.length; i++) {
			table[i] = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		}
		
		int ans;
		
		expand();
		
		ans = a[n-1];
		
		if(n > 1) {
			
			if(table[0][0] + table[0][n-1] <= w) {
				int t1 = table[0][0];
				int t2 = table[0][n-1];
				table[0][0] = table[0][n-1] = w;
				
				expand();
				
				ans = Math.min(ans, c[n-1]);
			
				table[0][0] = t1;
				table[0][n-1] = t2;
			}
			
			if(table[1][0] + table[1][n-1] <= w) {
				int t1 = table[1][0];
				int t2 = table[1][n-1];
				table[1][0] = table[1][n-1] = w;
				
				expand();
				
				ans = Math.min(ans, b[n-1]);
				
				table[1][0] = t1;
				table[1][n-1] = t2;
			}
			
			if(table[0][0] + table[0][n-1] <= w && table[1][0] + table[1][n-1] <= w) {
				int t1 = table[0][0];
				int t2 = table[0][n-1];
				int t3 = table[1][0];
				int t4 = table[1][n-1];
				table[0][0] = table[0][n-1] = table[1][0] = table[1][n-1] = w;
				
				expand();
				
				ans = Math.min(ans, a[n-2]);
				
				table[0][0] = t1;
				table[0][n-1] = t2;
				table[1][0] = t3;
				table[1][n-1] = t4;
			}
			
		}
		
		System.out.println(ans);
	}

	static void expand() {
		
		if(table[0][0] + table[1][0] <= w) {
			a[0] = b[0] = c[0] = 1;
		}else {
			a[0] = 2;
			b[0] = c[0] = 1;
		}
		
		for(int i = 1; i < n; i++) {
			
			a[i] = a[i-1] + 2;
			b[i] = c[i] = a[i-1] + 1;
			
			if(table[0][i] + table[0][i-1] <= w) {
				b[i] = Math.min(b[i], c[i-1] + 1);
			}
			
			if(table[1][i] + table[1][i-1] <= w) {
				c[i] = Math.min(c[i], b[i-1] + 1);
			}
			
			a[i] = Math.min(a[i], b[i] + 1);
			a[i] = Math.min(a[i], c[i] + 1);
			
			if(table[0][i] + table[1][i] <= w) {
				a[i] = Math.min(a[i], a[i-1] + 1);
			}
			
			if(table[0][i] + table[0][i-1] <= w && table[1][i] + table[1][i-1] <= w) {
				
				if(i >= 2) {
					a[i] = Math.min(a[i], a[i-2] + 2);
				}else {
					a[i] = Math.min(a[i], 2);
				}
			} // end for
			
		}
	}// end expand Method
	
}

















