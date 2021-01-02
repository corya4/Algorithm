package study;

import java.util.Arrays;
import java.util.Scanner;
import java.util.StringTokenizer;

public class Union_rank {
	static int[] root = new int[15];
	static int[] rank = new int[15];
	public static void main(String[] args) {
		for(int i = 0; i < root.length; i++) {
			root[i] = i;
			rank[i] = 0;
		}
		Scanner sc = new Scanner(System.in);
		for(int j = 0; j < 5; j++) {
			StringTokenizer stn = new StringTokenizer(sc.nextLine(), " ");
			int i = Integer.parseInt(stn.nextToken());
			int z = Integer.parseInt(stn.nextToken());
			union(i,z);
		}
		System.out.println(Arrays.toString(root));
		System.out.println(Arrays.toString(rank));
	}
	static void union(int v, int x) {
		v = find(v);
		x = find(x);
		
		root[x] = v;
		
		if(v == x) {
			return;
		}
		
		if(root[v] < root[x]) {
			root[v] = x;
		}else {
			root[x] = v;
			
			if(rank[x] == rank[v]) {
				rank[x]++;
				rerank(x);
			}
		}
	}
	
	static void rerank(int s) {
		for(int i = 0; i < root.length; i++) {
			if(s == i) {
				continue;
			}
			if(s == root[i]) {
				rank[i]++;
				rerank(i);
			}
		}
	}
	static int find(int s) {
		if(root[s] == s) {
			return s;
		}else {
			return find(root[s]);
		}
	}
}
