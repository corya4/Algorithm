package help;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Plus_array {
	static int[] index;
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		index = new int[10];
		String val = br.readLine().replace(" ", "");
		
		for(int i = 0; i < val.length(); i++) {
			int tmp = val.charAt(i) - 48;
			index[tmp]++;
		}
		print();
	}
	
	static void print() {
		for(int j = 0; j < index.length; j++) {
			if(index[j] != 0) {
				System.out.print(j+""+index[j]);
			}
		}
	}
}
