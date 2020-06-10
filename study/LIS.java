package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class LIS {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int length = Integer.parseInt(br.readLine());
		int[] iArr = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		int[] dArr = new int[iArr.length];
		if(length < iArr.length) return;
		int max = 0;
		for(int i = 0; i < iArr.length; i++) {
			dArr[i] = 1;
			for(int j = 0; j < i; j++) {
				if(iArr[j] < iArr[i] && dArr[i] < dArr[j] + 1) {
					dArr[i] = dArr[j] + 1;
				}
			}
			if(max < dArr[i]) max = dArr[i];
		}
		System.out.println(max);
	}

}
