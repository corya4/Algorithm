package programers;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

class EqualsPad{
	private int x1, y1;
	private int x2, y2;
	
	EqualsPad(int x1, int y1, int x2, int y2){
		this.x1 = x1; this.y1 = y1;
		this.x2 = x2; this.y2 = y2;
	}

	public int getX1() {
		return x1;
	}

	public int getY1() {
		return y1;
	}

	public int getX2() {
		return x2;
	}

	public int getY2() {
		return y2;
	}

	
	@Override
	public boolean equals(Object obj) {
		if(!(obj instanceof EqualsPad)) {
			return false;
		}
		EqualsPad pad = (EqualsPad)obj;
		if(this.x1 == pad.x2 && this.y1 == pad.y2) {
			return true;
		}
		return false;
	}

	
	@Override
	public String toString() {
		return "EqualsPad [x1=" + x1 + ", y1=" + y1 + ", x2=" + x2 + ", y2=" + y2 + "]";
	}
}

public class Little_friends { //사천성
	static Scanner sc;
	static String value;
	static String[][] kakaoGame;
	static List<EqualsPad> ep = new ArrayList<EqualsPad>();
	public static void main(String[] args) {
		Little_friends game = new Little_friends();
		sc = new Scanner(System.in);
		final int m = sc.nextInt();
		final int n = sc.nextInt();
		String[] board = null;
		game.solution(m,n,board);
		System.out.println(ep);
	}
	
	 public void solution(int m, int n, String[] board) {
		board = new String[m];
		for(int i = 0; i < m; i++) {
			String pad = sc.next();
			if(pad.length()-1 < n) {
				board[i] = pad;
			}else {
				throw new IndexOutOfBoundsException();
			}
		}
		kakaoGame = new String[m][n];
		for(int i = 0; i < m; i++) {
			String set = board[i];
			for(int j = 0; j < n; j++) {
				kakaoGame[i][j] = String.valueOf(set.charAt(j));
			}
		}
		
		equalsPad(0,0);
		while(ep.size() != 0) {
			pathSearch();
		}
		
	}
	
	static boolean flag = false;
	public void equalsPad(int x, int y){
		
		if(x > kakaoGame.length-1) {
			flag = true;
		}
		
		if(flag==true){
			return;
		}
		
		for(int i = 0; i < kakaoGame.length; i++) {
			for(int j = 0; j < kakaoGame[i].length; j++) {
				//System.out.println("재귀 : " + x +", "+y +"     "+"반복 : " + i +", " + j);
				if(kakaoGame[x][y].matches("[a-zA-Z]") && kakaoGame[x][y].equals(kakaoGame[i][j]) &&( x != i || y != j)) {
					EqualsPad pad = new EqualsPad(x,y,i,j);
					//System.out.println(pad);
					if(!ep.contains(pad)) {
						ep.add(pad);
					}
					
					if(y+1 < kakaoGame[i].length) {
						equalsPad(x,y+1);
					}else if(x < kakaoGame.length){
						equalsPad(x+1,0);
					}else {
						return;
					}
					
					if(flag == true) {
						return;
					}
				}
			}	
		}
		if(y+1 < kakaoGame[0].length) {
			equalsPad(x,y+1);
		}else if(x+1 < kakaoGame.length){
			equalsPad(x+1,0);
		}else {
			return;
		}
		
		if(flag == true) {
			return;
		}
	}
	public void pathSearch() {
		
		
		
	}
}






