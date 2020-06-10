package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class Binary_tree {

	static int result = 0;
	static int[] tArr;
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int height = (1 << Integer.parseInt(br.readLine())+1);
		tArr = new int[height];
		int[] tmp = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		
		for(int i = 2; i < height; i++) {
			tArr[i] = tmp[i-2];
		}
		System.out.println(Arrays.toString(tArr));
		dps(1);
		System.out.println(result);
	}

	static int dps(int index) {
		if(index > tArr.length-1) return 0;
		
		int left = dps(index * 2);
		int right = dps(index * 2 + 1);
		result += tArr[index] + Math.abs(left - right);
		return tArr[index] + Math.max(left, right);
	}
}
