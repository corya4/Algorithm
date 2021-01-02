
package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class BOJ_2098 {
	static int[][] table;
	static int[][] dp;
	static int contry;
	static int max = 200000000;
	static int start = 0;
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		contry = Integer.parseInt(br.readLine());
		table = new int[contry][contry];
		dp = new int[contry][1<<contry];
		StringTokenizer stn; 
		for(int i = 0; i < contry; i++) {
		stn = new StringTokenizer(br.readLine(), " ");
			for(int j = 0; j < contry; j++) {
				table[i][j] = Integer.parseInt(stn.nextToken());
			}
		}
		System.out.println(TPS(start,1<<start));
	}	
	
	static int TPS(int local, int memo) {
		if(memo == (1<<contry)-1) {
            if(table[local][start] == 0) return max;
                else
			return table[local][start];
		}
		if(dp[local][memo] != 0) {
			return dp[local][memo];
		}
		int temp = max;
		for(int i = 0; i < contry; i++) {
			if((memo & (1<<i)) > 0 || table[local][i] == 0) 
				continue;
			
			temp = Math.min(temp, table[local][i] + TPS(i, memo | (1<<i)));	
		}
		return dp[local][memo] = temp;
	}
}
