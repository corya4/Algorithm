package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class BOJ_1965 {

	
	//Time Over
	//answer Study/LIS.java
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int length = Integer.parseInt(br.readLine());
		int[] iArr = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		if(length < iArr.length) return;
		
		int maxBox = 0;
		
		for(int i = 0; i < iArr.length; i++) {
			maxBox = Math.max(maxBox, LIS(iArr[i], i, iArr) + 1);
		}
		
		System.out.println(maxBox);
	}

	static int LIS(int num, int len, int[] iArr) {
		
		if(len >= iArr.length) return 0;
		
		int tMax = 0;
		for(int i = len+1; i < iArr.length; i++) {
			if(num > iArr[i]) continue;
			tMax = Math.max(tMax, LIS(iArr[i], i, iArr) + 1);
		}
		return tMax;
	}
}
