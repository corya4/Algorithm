
package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.StringTokenizer;


public class BOJ_16935 {

	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		StringTokenizer stn = new StringTokenizer(br.readLine()," ");
		int row = Integer.parseInt(stn.nextToken());
		int col = Integer.parseInt(stn.nextToken());
		
		int[][] table = new int[row][row];
		
		for(int i = 0; i < row; i++) {
			for(int j = 0; j <= i; j++) {
				if(i-1 > 0 && j != 0) {
					table[i][j] = table[i-1][j-1] + table[i-1][j];
				}else {
					table[i][j] = 1;
				}
			}
		}
		System.out.println(table[row-1][col-1]);
	}

}