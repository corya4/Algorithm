package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class BOJ_18250 {
	static int n, m, ret;
	static int[] add, in, uf;
	static int[][] load;
	public static void main(String[] args) {
	
		init();
		
		for(int[] itmp : load) union_merge(itmp[0], itmp[1]);
		
		/*
		 * System.out.println(Arrays.toString(add));
		 * System.out.println(Arrays.toString(in));
		 * System.out.println(Arrays.toString(uf));
		 */
		for(int i = 1; i <= n; i++) {
			
			if(uf[i] > 0 || (in[i]) == 0) continue;
			int p = union_find(i);
			if((add[p]) == 0) ret++;
			else ret += add[p] / 2;
			
		}
		System.out.println(ret);
	//	System.out.println(ret != 0 ? ret : 1);
		
	}
	
	static void init() {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String[] uTmp;
		try {
			uTmp = br.readLine().split(" ");
			n = Integer.parseInt(uTmp[0]);
			m = Integer.parseInt(uTmp[1]);
			
			add = new int[n+1]; in = new int[n+1]; uf = new int[n+1];
			load = new int[m+1][2];
			
			for(int i = 1; i <= m; i++) {
				uTmp = br.readLine().split(" ");
				load[i][0] = Integer.parseInt(uTmp[0]);
				load[i][1] = Integer.parseInt(uTmp[1]);
				in[Integer.parseInt(uTmp[0])]++;
				in[Integer.parseInt(uTmp[1])]++;
			}
			Arrays.fill(uf, -1);
			
			for(int j = 1; j <= n; j++) {
				add[j] = in[j] & 1;
			}
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	static int union_find(int i) {
		
		if(uf[i] < 0) return i;
		else return uf[i] = union_find(uf[i]);
		
	}
	
	static void union_merge(int u, int v) {
		u = union_find(u);
		v = union_find(v);
		
		if(u != v) {
			uf[v] = u;
			add[u] += add[v];
		}
	}
}














