package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class BOJ_9465 {

	static int[][] board;
	
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		int tcn = Integer.parseInt(br.readLine());
		
		while(tcn-- != 0) {
			int col = Integer.parseInt(br.readLine());
			board = new int[2][col];
			
			for(int i = 0; i < board.length; i++) {
				board[i] = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
			}
			
			solv();
			
			
		}// end while
		
	}

	static int solv() {
		/*
		 * DP이중배열로 i반복당 전 연산값을 더함
		 * 전 연산값 * 2 로 i+1 배열 수 늘어감
		 */
		return 0;
	}
	
}


