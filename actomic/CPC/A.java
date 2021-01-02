package CPC;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class A {
	static int[][] org;
	static int[][] ans;
	static int nLen;
	static int nLenNew;
	
	public static void main(String[] args) throws IOException {
		CreateInit();
		UpSampling();
		
		//Ãâ·Â
		for(int[] arr : ans) {
			for(int n : arr) System.out.print(n + " ");
		System.out.println();
		}
	}
	
	private static void CreateInit() throws IOException {
		int[] init = null;
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		init = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		
		nLen = init[0];
		nLenNew = init[1];
		
		org = new int[nLen][nLen];
		ans = new int[nLen * nLenNew][nLen * nLenNew];
		
		for(int i = 0; i < nLen; i++) {
			org[i] = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		}
		
	}
	private static void UpSampling() {
		for(int i = 0; i < nLen; i++) 
			for(int j = 0; j < nLen; j++) 
				UpdatePixcel(i, j);
	}
	
	private static void UpdatePixcel(int n, int m) {
		int nOrg = (n * nLenNew);
		int mOrg = (m * nLenNew);
		int nNew = nOrg + nLenNew;
		int mNew = mOrg + nLenNew;
		
		for(int i = nOrg; i < nNew; i++) {
			for(int j = mOrg; j < mNew; j++) {
				ans[i][j] = org[n][m];
			}
		}
	}
}





