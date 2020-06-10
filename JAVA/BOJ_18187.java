package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class BOJ_18187 {
	static int[] dp;
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int line = Integer.parseInt(br.readLine());
		dp = new int[line+1];
		if(line < 1 || 100 < line) return;
		
		dp[0] = 1; dp[1] = 2; dp[2] = 4;
		
		int plus = 3;
		for(int i = 3; i <= line; i++) {
			dp[i] = dp[i-1] + plus;
			if(i%3 != 0) plus++;
		}
		
		System.out.println(dp[line]);
	}

}