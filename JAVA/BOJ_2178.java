
package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashSet;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.Queue;
import java.util.StringTokenizer;

public class BOJ_2178 {
	
	static int[][] table;
	static int [][]dp;
	static int[] row = {-1, 0, 0, 1};
	static int[] col = {0, -1, 1, 0};
	static HashSet<int[]> hashSet = new HashSet<int[]>();

	public static void main(String[] args) throws IOException {
		setting();
		int result = searchLoad();
		System.out.println(result);
		
	}
	public static void setting() throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		StringTokenizer st = new StringTokenizer(br.readLine()," ");
		table = new int[Integer.valueOf(st.nextToken())][Integer.valueOf(st.nextToken())];
		if(!(2<=table.length)) {
			if(!(table[0].length<=100)) {
				throw new ArrayIndexOutOfBoundsException();
			}
		}
		dp = new int[table.length][table[0].length];
		dp[0][0] = 1;
		for(int i = 0; i < table.length; i++) {
			String sb = br.readLine();
			for(int j = 0; j < table[i].length; j++) {
				table[i][j] = sb.charAt(j) - 48;
			}
		}
		
	}
	public static int searchLoad() {
		Queue<int[]> queue = new LinkedList<int[]>();
		int[] start = {0,0};
		queue.add(start);
		while(!queue.isEmpty()) {
			int[] memo = queue.poll();
			for(int i = 0; i < 4; i++) {
				int[] exam = {memo[0] + row[i],memo[1] + col[i]};
				if((exam[0] < 0 || exam[0] > table.length-1) || (exam[1] < 0 || exam[1] > table[0].length-1) || table[exam[0]][exam[1]] == 0) {
					continue;
				}
				
				if(checking(exam)) {
					return dp[memo[0]][memo[1]]+1;
				}
				if(checking2(exam)) {
					queue.add(exam);
					dp[exam[0]][exam[1]] = dp[memo[0]][memo[1]]+1;
					hashSet.add(exam);
				}		
			}
		}
		return 0;
	}
	
	static boolean checking(int[] exam) {
		if(exam[0] == table.length-1 && exam[1] == table[0].length -1) {
			return true;
		}
		return false;
	}
	static boolean checking2(int[] exam) {
		Iterator<int[]> it = hashSet.iterator();
		while(it.hasNext()) {
			int[] check = it.next();		
			if(check[0] == exam[0] && check[1] == exam[1]) {
				return false;
			}
		}
		return true;
	}
}