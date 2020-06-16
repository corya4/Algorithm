package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class BOJ_10950 {

	public static void main(String[] args) throws NumberFormatException, IOException {
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String count;;
		int[] answer;
		
		while(true) {
			count = br.readLine();
			if(count == null || count.equals("")) break;
			answer = Arrays.asList(count.split(" ")).stream().mapToInt(Integer::parseInt).toArray();
			System.out.println(answer[0] + answer[1]);
		}
	}

}
