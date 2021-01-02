
package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class BOJ_1463 {
	
	static int[] dp;
	static final int max = 2000000;
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int cnt = Integer.parseInt(br.readLine());
		dp = new int[cnt+1];
		System.out.println(dp(cnt));
	}
	static int dp(int cnt) {
		if(cnt == 1) {
			return 0;
		}
		if(dp[cnt] != 0) {
			return dp[cnt];
		}
		return dp[cnt] = Math.min(Math.min((cnt%3 == 0)?dp(cnt/3):max, (cnt%2 == 0)?dp(cnt/2):max) + 1, dp(cnt-1)+1);
	}
}
