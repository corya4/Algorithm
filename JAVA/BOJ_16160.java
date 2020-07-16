package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;

public class BOJ_16160 {

	static String[] nodes;
	
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		int[] init = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		int H = init[0];
		//노드 테이블
		int P = init[1];
		//수열
		int K = init[2];
		//수열길이
		int[] arr = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		
		nodes = new String[(int)(Math.pow(2, H)) - 1];
		nodes[0] = insert(arr, H*2, P);
		
		for(int i = 0; i < nodes.length/2; i++) {
			int half = (nodes[i].length()/2);
			int end = nodes[i].length();
			
			nodes[(i*2)+1] = nodes[i].substring(0, half);
			nodes[(i*2)+2] = nodes[i].substring(half, end);
			
		}
		
		System.out.println(solv(0, (int)Math.pow(2, 1) - 1, 1,  K, H));
		
	}
	
	static int solv(int s, int e, int pow, int c, int h) {
		
		if(c == 1) return 1;
		if(pow == h || e > nodes.length + 1) {
			return -1;
		}
		
		Set<String> set = new HashSet<String>();
		int tcp = c;
		
		for(int i = s; i < e; i++) {
			if(!set.add(nodes[i])) tcp--;
			System.out.print( nodes[i] + " ");
		}
		System.out.println();
		if(tcp == 0) {
			return 1;
		}
		
		return solv(e, (int)Math.pow(2, pow+1) - 1 , pow+1, c, h) == -1 ? -1 : 1;
	}
	
	static String insert(int[] arr, int H, int P) {
		String sequence = "";
		for(int i = 0; i < H; i++) {
			sequence += arr[i%P];
		}
		
		return sequence;
	}
	
}