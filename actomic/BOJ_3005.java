package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.StringTokenizer;

public class BOJ_3005 {

	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");
		
		int[][] pz = new int[Integer.parseInt(stn.nextToken())][Integer.parseInt(stn.nextToken())];
		
		for(int i = 0; i < pz.length; i++) {
			String[] tmp = br.readLine().split("");
			System.out.println(Arrays.toString(tmp));
			
		}

	}

}
