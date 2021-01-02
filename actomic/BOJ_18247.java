
package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class BOJ_18247 {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int count = Integer.parseInt(br.readLine());
		StringTokenizer stn;
		for(int i = 0; i < count; i++) {
			stn = new StringTokenizer(br.readLine(), " ");
			int row = Integer.parseInt(stn.nextToken());
			int col = Integer.parseInt(stn.nextToken());
			if(row < 12|| col < 4) System.out.println(-1);
			else System.out.println((11*col)+4);
		}
	}
}