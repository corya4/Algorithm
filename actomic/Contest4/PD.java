package Contest4;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class PD {

	public static void main(String[] args) throws NumberFormatException, IOException {
		int s, count;
		int min[];
		int max[];
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		s = 0;
		count = Integer.parseInt(br.readLine());
		min = new int[count];
		max = new int[count];
		
		while(s < count) {
			int[] tmp = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
			min[s] = tmp[0] - tmp[1];
			max[s] = tmp[0] + tmp[1];
			s++;
		}
		
		for(int i = 0; i < count; i++) {
			int n = min[i]; int m = max[i];
			int in = 1; int im = 1;
			for(int j = i; j < count; j++) {
				if(i == j) continue;
				if(max[j] < n) in++;
				if(min[j] < m) im++;
			}
			
			System.out.println(in + " " + im);
		}

	}

}
