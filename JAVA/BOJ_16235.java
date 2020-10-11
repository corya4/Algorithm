package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.StringTokenizer;

public class BOJ_16235 {

	public static void main(String[] args) throws IOException {
		int N, M, K;
		int[][] Tbl;
		int[][] S2D2;
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");
		
		N = Integer.parseInt(stn.nextToken());
		M = Integer.parseInt(stn.nextToken());
		K = Integer.parseInt(stn.nextToken());
		
		Tbl = new int[N][N];
		S2D2 = new int[M][3];
		
		for(int i = 0; i < N; i++) Tbl[i] = Arrays.asList(br.readLine()).stream().mapToInt(Integer::parseInt).toArray();
		for(int j = 0; j < M; j++) S2D2[j] = Arrays.asList(br.readLine()).stream().mapToInt(Integer::parseInt).toArray();
		
		/////init/////
		
		
		
	}

}
