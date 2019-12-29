package baekjun;

import java.util.HashSet;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Scanner;
import java.util.StringTokenizer;

class Memorise2{
	int x = 0;
	int y = 0;
	int point;
	
	Memorise2(int x, int y, int point){
		this.x = x;
		this.y = y;
		this.point = point;
	}
	
	@Override
	public boolean equals(Object obj) {
		if(obj instanceof Memorise2) {
			Memorise2 memo = (Memorise2)obj;
			if(this.x == memo.x && this.y == memo.y) {
				return true;
			}else {
				return false;
			}
		}
		return false;
	}
	@Override
	public int hashCode() {
		// TODO Auto-generated method stub
		return 31;
	}
	@Override
	public String toString() {
		return "Memorise2 [x=" + x + ", y=" + y + "]";
	}
}

public class BFS_miro {
	static int[][] table;
	static int[] Xdirection = {1, 0, -1, 0};
	static int[] Ydirection = {0, 1, 0, -1};
	static boolean find = false;
	static int distance = 0;

	public static void main(String[] args) {
		setting();
		int result = searchLoad();
		System.out.println(result);
		
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
	public static int searchLoad() {
		Queue<Memorise2> queue = new LinkedList<Memorise2>();
		HashSet<Memorise2> hashSet = new HashSet<Memorise2>();
		Memorise2 begin = new Memorise2(0,0,1);
		Memorise2 end = new Memorise2(table.length-1,table[0].length-1,0);
		queue.add(begin);
		int point= 0;
		while(!queue.isEmpty()) {
			Memorise2 memo = queue.poll();
			point = memo.point;
			hashSet.add(memo);
			for(int i = 0; i < 4; i++) {
				if(memo.x == 0) {
					Xdirection[2] = 0;
				}
				if(memo.x == table.length-1) {
					Xdirection[0] = 0;
				}
				if(memo.y == 0) {
					Ydirection[3] = 0;
				}
				if(memo.y == table[0].length-1) {
					Ydirection[1] = 0;
				}
				if(table[memo.x+Xdirection[i]][memo.y+Ydirection[i]]==1) {
					Memorise2 exam = new Memorise2(memo.x+Xdirection[i],memo.y+Ydirection[i],point+1);
					if(!hashSet.contains(exam)) {
						if(exam.equals(end)) {
							return exam.point;
						}
						queue.add(exam);
						
					}
				}
				recovery();
			}
		}
		return 0;
	}
	static void recovery() {
		Xdirection[2]=-1; Xdirection[0]=1;
		Ydirection[3]=-1; Ydirection[1]=1;
	}
}









