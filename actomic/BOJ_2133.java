package JAVA;


import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class BOJ_2133 {
	
	static int[] dp;
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int length = Integer.parseInt(br.readLine());	
		dp = new int[length+1];
		System.out.println((length%2==0)?dp(length):0);
	}
	static int dp(int length) {
		if(length == 0) return 1;
		if(length == 2) return 3;
		if(dp[length] != 0) return dp[length];
		
		for(int i = 2; i <= length; i+=2) {
			int j = (i == 2)?3:2;
			dp[length] += j * dp(length-i);
		}
		return dp[length];
	}
}