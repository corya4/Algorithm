
package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class BOJ_12865 {
	
	static int[][] dp;
	static int[][] object;
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");
		int o = Integer.parseInt(stn.nextToken());
		int w = Integer.parseInt(stn.nextToken());
		
		object = new int[o+1][2];
		dp = new int[w+1][o+1];
		
		for(int back = 1; back <= o; back++) {
			stn = new StringTokenizer(br.readLine(), " ");
			object[back][0] = Integer.parseInt(stn.nextToken());
			object[back][1] = Integer.parseInt(stn.nextToken());
		}
		
		for(int i = 1; i <= w; i++) {
			for(int j = 1; j <= o; j++) {
				if(i >= object[j][0]) {
                    dp[i][j] = Math.max(dp[i][j-1], dp[i-object[j][0]][j-1]+object[j][1]);
				}else{
				    dp[i][j] = dp[i][j-1];
                }
			}
		}
		System.out.println(dp[w][o]);
	}
	
}