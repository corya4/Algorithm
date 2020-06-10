
package JAVA;


import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

class Location{
	int x;
	int y;
	Location(int x, int y){
		this.x = x;
		this.y = y;
	}
	
	@Override
	public boolean equals(Object arg0) {
		if(!(arg0 instanceof Location)) {
			return false;
		}
		Location lct = (Location)arg0;
		return (this.x == lct.x && this.y == lct.y);
	}
}

public class BOJ_4963 {
	
	static Scanner sc = new Scanner(System.in);
	static int[][] table = null;
	static int island = 0;
	static List<Location> location = new ArrayList<Location>();
	
	public static void main(String[] args) {
		while(setting()) {
			dfs();
			System.out.println(island);
			island = 0;
			location = new ArrayList<Location>();
			table = null;
		}
	}
	
	static boolean setting() {
		String[] set = sc.nextLine().split(" ");
		
		table = new int[Integer.parseInt(set[1])][Integer.parseInt(set[0])];
		if(set[0].equals("0") && set[1].equals("0")) {
			return false;
		}
		
		for(int i = 0; i < Integer.parseInt(set[1]); i++) {
			String[] temp = sc.nextLine().split(" ");
			for(int j = 0; j < Integer.parseInt(set[0]); j++) {
				table[i][j] = Integer.parseInt(temp[j]);
			}
		}
		return true;
	}
	
	static void dfs() {
		for(int i = 0; i < table.length; i++) {
			for(int j = 0; j < table[0].length; j++) {
				if(table[i][j] == 1) {
					if(dfsCheck(i,j)) {
						island++;
						dfsUtill(i,j);
					}
				}
			}
		}
	}
	static boolean dfsCheck(int i, int j) {
		Location lct = new Location(i,j);
		if(location.contains(lct)) {
			return false;
		}else {
			location.add(lct);
			return true;
		}
	}
	static void dfsUtill(int i, int j) {
		int x = i==0?0:i-1;
		int y = j==0?0:j-1;
		int ex = i==table.length-1?table.length-1:i+1;
		int ey = j==table[0].length-1?table[0].length-1:j+1;
		for(int sx = x; sx <= ex; sx++) {
			for(int sy = y; sy <= ey; sy++) {
				if(sx==i && sy == j) {
					continue;
				}
				if(table[sx][sy]== 1) {					
					if(dfsCheck(sx,sy)) {
						dfsUtill(sx, sy);
					}
				}
			}
		}
	}
} 