package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class BOJ_18248 {
	static int[][] table;
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");
		int n = Integer.parseInt(stn.nextToken());
		int m = Integer.parseInt(stn.nextToken());
		table = new int[n][m];
		for(int i = 0; i < n; i++) {
			stn = new StringTokenizer(br.readLine(), " ");
			int j = 0;
			while(stn.hasMoreTokens()) table[i][j++] = Integer.parseInt(stn.nextToken()); 
			j = 0;
		}
		
		for(int i = 0; i < n-1; i++) {
			for(int j = i+1; j < n; j++) {
				boolean ch1 = false; boolean ch2 = false;
				for(int z = 0; z < m; z++) {
					if(table[i][z] == 0 && table[j][z] == 1) ch1 = true;
					if(table[i][z] == 1 && table[j][z] == 0) ch2 = true;
					if(ch1 && ch2) {
						System.out.println("NO");
						return;
					}
				}
			}
		}
		System.out.println("YES");
	}
}
