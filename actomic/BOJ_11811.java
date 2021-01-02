
package JAVA;

import java.util.Scanner;
import java.util.StringTokenizer;

public class BOJ_11811 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		sc.nextLine();
		int[][] dArr = new int[n][n];
		StringTokenizer stn;
		for(int i = 0; i < dArr.length; i++) {
			stn = new StringTokenizer(sc.nextLine(), " ");
			for(int j = 0; j < dArr[i].length; j++) {
				dArr[i][j] = Integer.parseInt(stn.nextToken());
			}
		}
		int num = 0;
		for(int[] row : dArr) {
			for(int col : row){
				num = col|num;
			}
			System.out.print(num + " ");
			num = 0;
		}
	}
}