package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Comparator;

public class BOJ_11047 {

	
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String[] init = br.readLine().split(" ");
		int[] coins = new int[Integer.parseInt(init[0])];
		for(int i = 0; i < coins.length; i++) {
			coins[i] = Integer.parseInt(br.readLine());
		}
		int target = Integer.parseInt(init[1]);
		int m = 0;
		for(int j = coins.length-1; j >= 0; j--) {
			m += target/coins[j];
			target %= coins[j];
		}
		System.out.println(m);
	}
	
//	static final int MAX = 1000000000;
//	static ArrayList<Integer> coins = new ArrayList<Integer>();
//	static int[] dp = new int[1000001];
//	
//	public static void main(String[] args) throws IOException {
//		
//		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
//		String[] values = br.readLine().split(" ");
//	
//		int count = Integer.parseInt(values[0]);
//		int target = Integer.parseInt(values[1]);
//		
//		if(!(1 <= count || count <= 10) || !(1 <= target || target <= 100000000)) return;
//		
//		for(int i = 0; i < count; i++) {
//			coins.add(Integer.parseInt(br.readLine()));
//		}
//		
//		Collections.sort(coins, new Comparator<Integer>() {
//			@Override
//			public int compare(Integer o1, Integer o2) {
//				// TODO Auto-generated method stub
//				return o2 - o1;
//			}
//		});
//		Arrays.fill(dp, -1);
//		splitList(target);
//		
//		int min = getMinValue(0, target);
//		System.out.println(min);
//		
//	}
//	
//	static void splitList(int target) {
//		int limit = 0;
//		for(int tmp : coins) {
//			if(tmp > target) limit++;
//			else break;
//		}
//		
//		for(int i = 0; i < limit; i++) {
//			coins.remove(0);
//		}
//	}
//
//	static int getMinValue(int sum, int target) {
//		
//		if(sum > target) return MAX;
//		if(sum == target) return 0;
//		if(dp[sum] != -1) return dp[sum]; 
//		
//		int min = MAX;
//		for(int i = 0; i < coins.size(); i++) {
//			min = Math.min(min, getMinValue(sum + coins.get(i), target) + 1);
//		}
//		
//		return dp[sum] = min;
//	}
//	
}
