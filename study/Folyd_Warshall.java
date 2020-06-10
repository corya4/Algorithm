package study;

import java.util.Arrays;
import java.util.Stack;

public class Folyd_Warshall {
	static int[][] path;
	
	static {
		path = new int[4][4];
		for(int i = 0; i < 4; i++) {
			for(int j = 0; j < 4; j++) {
				if(i == j) continue;
				path[i][j] = i+1;
			}
		}
	}
	
	static int INF = 1000000000;
	static int[][] table = {
			{0, 5, INF, 8},
			{7, 0, 9, INF},
			{2, INF, 0, 4},
			{INF, INF, 3, 0}
			
	};
	
	public static void main(String[] args) {
		
		int size = table.length;
		int[][] dTmp = new int[size][size];
		int[][] pTmp = new int[size][size];
		int s = 0;
		for(int[] t : table) {
			for(int ii = 0; ii < t.length; ii++) {
				dTmp[s][ii] = t[ii];
			}
			s++;
		}
		int ss = 0;
		for(int[] p : path) {
			for(int ii = 0; ii < p.length; ii++) {
				pTmp[ss][ii] = p[ii];
				
			}
			ss++;
		}
		
		for(int i = 0; i < size; i++) { // 핵심
			for(int j = 0; j < size; j++) {
				for(int k = 0; k < size; k++) {
					if(dTmp[k][j] > dTmp[i][j] + dTmp[k][i]) {
						dTmp[k][j] = dTmp[i][j] + dTmp[k][i];
						pTmp[k][j] = pTmp[i][j];
					}
				}
			}
		}
		
		println(dTmp, pTmp);
	}

	static void println(int[][] dTmp, int[][] pTmp) {
		System.out.println("before Algorithm");
		for(int[] a : table) System.out.println(Arrays.toString(a));
		
		System.out.println();
		System.out.println("after Algorithm");
		for(int[] b : dTmp) System.out.println(Arrays.toString(b)); 
		
		System.out.println('\n' + "#####################" + '\n');
		
		System.out.println("before Path");
		for(int[]c : path) System.out.println(Arrays.toString(c));
		
		System.out.println();
		System.out.println("after Path");
		for(int[] d : pTmp) System.out.println(Arrays.toString(d));
		
		System.out.println('\n' + "#####################" + '\n');
		
		for(int i = 0; i < 4; i++) {
			for(int j = 0; j < 4; j++) {
				if(i == j) continue;
				
				System.out.printf("%d부터 %d까지의 경로  :  ", i+1, j+1);
				
				Stack<Integer> stack = new Stack<Integer>();
				
				int pre = j;
				stack.push(j+1);
				while(i+1 != pTmp[i][pre]) {
					pre = pTmp[i][pre]-1;
					stack.push(pre+1);
				}
				
				while(!stack.empty()) {
					System.out.print(stack.pop());
					if(!stack.empty()) {
						System.out.print("-");
					}
				}
				System.out.println();
			}
		}
	}
}






