package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class BOJ_9465 {

	static int[][] board;
	static int[][] dp;
	static int col;
	
	public static void main(String[] args) throws NumberFormatException, IOException {
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		int tcn = Integer.parseInt(br.readLine());
		
		while(tcn-- != 0) {
			col = Integer.parseInt(br.readLine());
			board = new int[2][col+2];
			
			for(int i = 0; i < board.length; i++) {
				String[] temp = br.readLine().split(" ");
				for(int j = 2; j < board[i].length; j++) {
					board[i][j] = Integer.parseInt(temp[j-2]);
				}
			}
			
			solv();
			
		}// end while
		
	}

	static void solv() {
	
		
		for(int i = 2; i < col+2; i++) {
			for(int j = 0; j < 2; j++) {
				if(j == 0) board[j][i] += Math.max(board[j+1][i-1], board[j+1][i-2]);
				else board[j][i] += Math.max(board[j-1][i-1], board[j-1][i-2]);
			}
		}
		
		System.out.println(Math.max(board[0][col+1], board[1][col+1]));
		
	}
	
	static int swapIndex(int index) {
		return index == 0 ? 1 : 0 ;
	}
}


