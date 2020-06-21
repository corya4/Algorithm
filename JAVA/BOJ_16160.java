package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class BOJ_16160 {

	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		int[] init = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		int[] node = new int[init[0]];
		//노드 테이블
		int[] sequence = new int[init[1]];
		//수열
		int length = init[2];
		//수열길이
		sequence = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		
		
	}

}
