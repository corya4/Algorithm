
package study;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Comparator;
import java.util.Iterator;
import java.util.List;
import java.util.Scanner;


class EqualsPad {
	private int x1, y1;
	private int x2, y2;
	private int value;
	private int distance;
	private String sign;
	EqualsPad(int x1, int y1, int x2, int y2) {
		this.x1 = x1;
		this.y1 = y1;
		this.x2 = x2;
		this.y2 = y2;
	}

	public int getDistance() {
		return distance;
	}

	public void setDistance(int distance) {
		this.distance = distance;
	}

	public int getX1() {
		return x1;
	}

	public String getSign() {
		return sign;
	}

	public void setSign(String sign) {
		this.sign = sign;
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
	public int getValue() {
		return value;
	}

	public void setValue(int value) {
		this.value = value;
	}

	@Override
	public boolean equals(Object obj) {
		if (!(obj instanceof EqualsPad)) {
			return false;
		}
		EqualsPad pad = (EqualsPad) obj;
		if ((this.x1 == pad.x2) && (this.y1 == pad.y2) && (this.x2 == pad.x1) && (this.x2 == pad.x1)) {
			return true;
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
		return "EqualsPad [x1=" + x1 + ", y1=" + y1 + ", x2=" + x2 + ", y2=" + y2 + "]";
	}



}
	
class Sichunan {
	static Scanner sc;
	static String value;
	static String[][] kakaoGame;
	static List<EqualsPad> ep = new ArrayList<EqualsPad>();

	public static void main(String[] args) {
		sc = new Scanner(System.in);
		final int m = sc.nextInt();
		final int n = sc.nextInt();
		String[] board = null;
		solution(m, n, board);
		int num = 0;
		Collections.sort(ep, new Comparator<EqualsPad>() {

			@Override
			public int compare(EqualsPad o1, EqualsPad o2) {
				if(o1.getSign().charAt(0) < o2.getSign().charAt(0)) {
					return -1;
				}else {
					return 1;
				}
			}
			
		});
		while(ep.size()!=0) {
			if(ep.size()-1 < num) {
				System.out.println("IMPOSSIBLE");
				System.exit(0);
			}
			ep.get(num).setSign(kakaoGame[ep.get(num).getX1()][ep.get(num).getY1()]);
			if(A_star(ep.get(num))) {
				kakaoGame[ep.get(num).getX1()][ep.get(num).getY1()] = ".";
				kakaoGame[ep.get(num).getX2()][ep.get(num).getY2()] = ".";
				ep.remove(num);
				closeNode.clear();
				for(String[] a : kakaoGame) {
					System.out.println(Arrays.toString(a));
				}
				num = 0;
			}else {
				num++;
			}
		}
		System.out.println(answer);
	}

	public static String solution(int m, int n, String[] board) {
		board = new String[m];
		for (int i = 0; i < m; i++) {
			String pad = sc.next();
			if (pad.length() - 1 < n) {
				board[i] = pad;
			} else {
				throw new IndexOutOfBoundsException();
			}
		}
		kakaoGame = new String[m][n];
		for (int i = 0; i < m; i++) {
			String set = board[i];
			for (int j = 0; j < n; j++) {
				kakaoGame[i][j] = String.valueOf(set.charAt(j));
			}
		}
		equalsPad(0, 0);

		return null;
	}

	static boolean flag = false;
	
	public static void equalsPad(int x, int y) {

		if (x > kakaoGame.length - 1) {
			flag = true;
		}

		if (flag == true) {
			return;
		}

		for (int i = 0; i < kakaoGame.length; i++) {
			for (int j = 0; j < kakaoGame[i].length; j++) {
				if (kakaoGame[x][y].matches("[a-zA-Z]") && kakaoGame[x][y].equals(kakaoGame[i][j]) && (x != i || y != j)) {
					EqualsPad pad = new EqualsPad(x, y, i, j);
					pad.setSign(kakaoGame[x][y]);
					// System.out.println(pad);
					if (!ep.contains(pad)) {
						ep.add(pad);
					}

					if (y + 1 < kakaoGame[i].length) {
						equalsPad(x, y + 1);
					} else if (x < kakaoGame.length) {
						equalsPad(x + 1, 0);
					} else {
						return;
					}

					if (flag == true) {
						return;
					}
				}
			}
		}
		if (y + 1 < kakaoGame[0].length) {
			equalsPad(x, y + 1);
		} else if (x < kakaoGame.length) {
			equalsPad(x + 1, 0);
		} else {
			return;
		}
	}
	
	static int distance;
	static int chance;
	static String answer = "";
	static List<EqualsPad> closeNode = new ArrayList<EqualsPad>();
	static boolean A_star(EqualsPad pad) {
		closeNode.add(pad);
		flag = false;
		List<EqualsPad> list = new ArrayList<EqualsPad>();
		int bx = pad.getX1(); int by = pad.getY1(); int ex = pad.getX2(); int ey = pad.getY2();
		if(chance > 4) {
			return false;
		}
		System.out.println(pad.getSign());
		//
		if(bx != 0) {
			if(kakaoGame[bx-1][by].equals(".") || ((pad.getSign().equals(kakaoGame[ex][ey])) && mapSearch(bx-1, by, ex, ey))){
				EqualsPad npad = new EqualsPad(bx-1,by,ex,ey);
				npad.setValue((bx-1)+by+ex+ey);
				if(closeNodeSearch(npad)) {
					list.add(npad);
				}
			}
		}
		if(bx != kakaoGame.length-1) {
			if(kakaoGame[bx+1][by].equals(".") || ((pad.getSign().equals(kakaoGame[ex][ey])) && mapSearch(bx+1, by, ex, ey))) {
				EqualsPad npad = new EqualsPad(bx+1,by,ex,ey);
				npad.setValue((bx+1)+by+ex+ey);
				if(closeNodeSearch(npad)) {
					list.add(npad);
				}
			}
		}
		if(by != 0) {
			if(kakaoGame[bx][by-1].equals(".") || ((pad.getSign().equals(kakaoGame[ex][ey])) && mapSearch(bx, by-1, ex, ey))) {
				EqualsPad npad = new EqualsPad(bx,by-1,ex,ey);
				npad.setValue(bx+(by-1)+ex+ey);
				if(closeNodeSearch(npad)) {
					list.add(npad);
				}
			}
		}
		if(by != kakaoGame[0].length-1) {
			if(kakaoGame[bx][by+1].equals(".")|| ((pad.getSign().equals(kakaoGame[ex][ey])) && mapSearch(bx, by+1, ex, ey))) {
				EqualsPad npad = new EqualsPad(bx,by+1,ex,ey);
				npad.setValue(bx+(by+1)+ex+ey);
				if(closeNodeSearch(npad)) {
					list.add(npad);
				}
			}
		}
		System.out.println(list);
		if(answerSearch(list,new EqualsPad(ex, ey, ex, ey))) {
			flag = true;
			chance = 0;
			answer+=pad.getSign();
			return true;
		}
		
		Collections.sort(list, new Comparator<EqualsPad>() {

			@Override
			public int compare(EqualsPad o1, EqualsPad o2) {
				// TODO Auto-generated method stub
				if(o1.getValue() > o2.getValue()) {
					return 1;
				}else if(o2.getValue() < o2.getValue()) {
					return -1;
				}else {
					return 0;
				}
			}
		});
		
		Iterator it = list.iterator();
		
		while(it.hasNext()) {

			if(flag == true) {
				return true;
			}
			EqualsPad shorts = (EqualsPad)it.next();
			closeNode.add(shorts);
			if((pad.getX1() - shorts.getX1()) == 0) {
				if(pad.getY1() < shorts.getY1()) {
					distance = 1;
					shorts.setDistance(1);
				}else {
					distance = 3;
					shorts.setDistance(3);
				}
			}else if(pad.getY1() - shorts.getY1() == 0) {
				if(pad.getX1() < shorts.getY1()){
					distance = 2;
					shorts.setDistance(2);
				}else {
					distance = 4;
					shorts.setDistance(4);
				}
			}
			if(pad.getDistance() != shorts.getDistance()) {
				chance++;
			}
			shorts.setSign(pad.getSign());
			A_star(shorts);
			if(flag==true) {
				return true;
			}
			closeNode.remove(shorts);
			chance--;
		}
		closeNode.clear();
		return false;
	}	
	static boolean mapSearch(int x1, int y1, int x2, int y2) {
		if(x1==x2 && y1==y2) {
			System.out.println(x1+" "+y1+" "+x2+" "+y2);
			return true;
		}else {
			return false;
		}
	}
	static boolean closeNodeSearch(EqualsPad pad) {
		Iterator it = closeNode.iterator();
		while(it.hasNext()) {
			EqualsPad search = (EqualsPad)it.next();
			if(search.getX1() == pad.getX1()) {
				if(search.getY1() == pad.getY1()) {
					return false;
				}
			}
		}
		return true;
	}
	static boolean answerSearch(List<EqualsPad> list, EqualsPad apad) {
		Iterator it = list.iterator();
		while(it.hasNext()) {
			EqualsPad pad = (EqualsPad)it.next();
			if(pad.getX1() == apad.getX1() && pad.getY1() == apad.getY1()) {
				if(pad.getX2() == apad.getX2() && pad.getY1() == apad.getY2()) {
					return true;
				}
			}
		}
		return false;
	}
}