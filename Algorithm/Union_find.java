package study;

import java.util.Arrays;
import java.util.Scanner;
import java.util.StringTokenizer;

public class Union_find {
	static int[] root = new int[15];
	public static void main(String[] args) {
		for(int i = 0; i < root.length; i++) {
			root[i] = i;
		}
		Scanner sc = new Scanner(System.in);
		for(int j = 0; j < 7; j++) {
			StringTokenizer stn = new StringTokenizer(sc.nextLine(), " ");
			int i = Integer.parseInt(stn.nextToken());
			int z = Integer.parseInt(stn.nextToken());
			System.out.println(union(i, z));
		}
		System.out.println(Arrays.toString(root));
	}
	static int union(int v, int x) {
		v = find(v);
		x = find(x);
		
		root[x] = v;
		
		return v;
	}
	static int find(int s) {
		if(root[s] == s) {
			return s;
		}else {
			return find(root[s]);
		}
	}
}
