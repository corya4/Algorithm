package baekjun;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.StringTokenizer;

public class baekjun_12865 {
	static int[][] dp;
	static int[][] object;
	static int o;
	static int w;
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");
		o = Integer.parseInt(stn.nextToken());
		w = Integer.parseInt(stn.nextToken());
		
		object = new int[o][2];
		dp = new int[o+1][w+1];
		for(int i = 0; i < dp.length; i++) Arrays.fill(dp[i], -1);
		
		for(int back = 0; back < o; back++) {
			stn = new StringTokenizer(br.readLine(), " ");
			object[back][0] = Integer.parseInt(stn.nextToken());
			object[back][1] = Integer.parseInt(stn.nextToken());
		}
		int value = knapsack(0,w);
		System.out.println(value);
	}
	
	static int knapsack(int visited, int weigh) {
		
		if(visited == o) return 0;
		if(dp[visited][weigh] != -1) return dp[visited][weigh]; 
		int value = 0;
		
		value = knapsack(visited+1,weigh);
		
		if(weigh >= object[visited][0]) value = dp[visited][weigh] = Math.max(value, knapsack(visited+1,weigh-object[visited][0]) + object[visited][1]);
		return value;
	}
}





