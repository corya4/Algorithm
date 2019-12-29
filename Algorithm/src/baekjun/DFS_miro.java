package baekjun;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
import java.util.StringTokenizer;


class Memorise{
	int x = 0;
	int y = 0;
	
	Memorise(int x, int y){
		this.x = x;
		this.y = y;
	}

	@Override
	public boolean equals(Object obj) {
		if(obj instanceof Memorise) {
			Memorise memo = (Memorise)obj;
			if(this.x == memo.x && this.y == memo.y) {
				return true;
			}else {
				return false;
			}
		}
		return false;
	}

	@Override
	public String toString() {
		return "Memorise [x=" + x + ", y=" + y + "]";
	}
	
	
}

public class DFS_miro {
	static int[][] table;
	static int[] direction = {1, -1, 1, -1};
	static boolean find = false;
	static int distance = 1;
	static boolean[] flags = {true, true, true, true};
	static ArrayList<Integer> list = new ArrayList<Integer>();
	static ArrayList<Memorise> memolist = new ArrayList<Memorise>();
	public static void main(String[] args) {
		setting();
		searchLoad(0,0);
		Collections.sort(list);
		System.out.println(list.get(0));
		
		
	}
	
	public static void setting() {
		Scanner sc = new Scanner(System.in);
		StringTokenizer st = new StringTokenizer(sc.nextLine()," ");
		table = new int[Integer.valueOf(st.nextToken())][Integer.valueOf(st.nextToken())];
		if(!(2<=table.length)) {
			if(!(table[0].length<=100)) {
				throw new ArrayIndexOutOfBoundsException();
			}
		}
		String sb = null;
		for(int i = 0; i < table.length; i++) {
			sb = (sc.nextLine());
			for(int j = 0; j < table[i].length; j++) {
				table[i][j] = sb.charAt(j)-48;
			}
		}
	}
	public static void searchLoad(int x, int y) {
		
		Memorise memo = new Memorise(x,y);
		
		if(x == table.length-1 && y == table[0].length-1) {
			list.add(distance);
			//System.out.println(memo);
			return;
		}
		
		if(!memolist.contains(memo)) {
			distance++;
			memolist.add(memo);
		if((!(x == 0)) || x > memolist.get(memolist.size()-1).x) {
			if(table[x+direction[3]][y] == 1){
				searchLoad(x-1,y);
			}
		}
		
		if((!(y == 0)) || y > memolist.get(memolist.size()-1).y) {
			if(table[x][y+direction[1]] == 1) {
				searchLoad(x,y-1);
			}
		}
		
		if((y < table[0].length-1)) {
			if(table[x][y+1]==1) {
				searchLoad(x,y+1);
			}
		}
		
		if((x < table.length-1)) {
			if(table[x+direction[2]][y] == 1) {
				searchLoad(x+1,y);
			}
		}
		
		distance--;
		memolist.remove(memolist.size()-1);
		}
		return;
	}
}









