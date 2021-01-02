package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class BOJ_1330 {

	public static void main(String[] args) throws IOException {
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		int[] values = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		String answer = "";
		if(values[0] < values[1]) {
			answer = "<";
		}else if(values[0] > values[1]) {
			answer = ">";
		}else {
			answer = "==";
		}
		System.out.println(answer);
	}

}
