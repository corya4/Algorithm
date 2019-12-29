package baekjun;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class baekjun_2133 {
	static int[] dp;
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int length = Integer.parseInt(br.readLine());	
		if(!(1<=length && length <=1000)) {
			System.exit(0);
		}
		dp = new int[length+1];
		System.out.println(dp(length));
	}
	static int dp(int length) {
		if(length <= 1) return 1;
		if(dp[length] != 0) return dp[length];
		return dp[length] = (dp(length-1) + dp(length-2))%10007;
	}
}
