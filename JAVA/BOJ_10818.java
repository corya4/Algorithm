package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class BOJ_10818 {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int length = Integer.parseInt(br.readLine());
		int[] num = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		
		int max = 0;
		int min = 1000001;
		for(int i = 0; i < length; i++) {
			int temp = num[i];
			
			if(max < num[i]) max = num[i];
			if(min > num[i]) min = num[i];
		}
	
		System.out.println(min + " " + max);
	}

}
