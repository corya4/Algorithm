package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class BOJ_16160 {

	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		int[] init = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		int H = init[0];
		//노드 테이블
		int[] P = new int[init[1]];
		//수열
		int K = init[2];
		//수열길이
		P = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		
		int[][] table = new int[(int)(Math.pow(2, H) - 1)][];
		
		int answer = -1;
		
		
		
	}

}
