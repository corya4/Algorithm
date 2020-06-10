
package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;
import java.util.StringTokenizer;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;
import java.util.StringTokenizer;

class Node{
	int x;
	int y;
	Node(int x, int y){
		this.x = x;
		this.y = y;
	}
}

public class BOJ_2580  {
	
	static int[][] table = new int[9][9];
	static int zeroCount = 0;
	static List<Node> zeroNode = new ArrayList<Node>();
	public static void main(String[] args) throws IOException{
		  BufferedReader sc = new BufferedReader(new InputStreamReader(System.in)); 

		  StringTokenizer st = null;
		  for(int i = 0; i < 9; i++) {
			  st = new StringTokenizer(sc.readLine()," ");
			  for(int j = 0; j < 9; j++) {
				  table[i][j] = new Integer(st.nextToken()).intValue();
				  if(table[i][j] == 0) {
					  zeroNode.add(new Node(i,j));
				  }
			  }
		  }
		  zeroCount = zeroNode.size()-1;
		  sc.close();
		backTracking(0, 0);
	}

	static void backTracking(int count, int i) {
			if (count > zeroCount) {
				for (int[] a : table) {
					for (int b : a) {
						System.out.print(b + " ");
					}
					System.out.println();
				}
				System.exit(0);
		}
				for(int num = 1; num < 10; num++) {
					if(checkingNum(num, zeroNode.get(i).x, zeroNode.get(i).y)){
						backTracking(count+1, i+1);
						table[zeroNode.get(i).x][zeroNode.get(i).y] = 0;
					}else {
						if(num==9) {
							return;
						}
					}
				}

	}
	
	static boolean checkingNum(int num, int i, int j) {
		for (int row = 0; row < table.length; row++) {
			if (table[i][row] == num || table[row][j] == num) {
				return false;
			}
		}
		
		int i_row = (i/3)*3;
		int j_col = (j/3)*3;
		for (int row = i_row; row < i_row+3; row++) {
			for (int col = j_col; col < j_col+3; col++) {
				if (table[row][col] == num) {
					return false;
				}	
			}
		}
		table[i][j] = num;
		return true;
	}
} 