package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.Collections;
import java.util.Comparator;
import java.util.StringTokenizer;

public class BOJ_3005 {

	static ArrayList<String> wList = new ArrayList<String>();
	static boolean[] overCheck; // Checking overlap Array
	static String[][] pz;
	static int ar, ac;

	public static void main(String[] args) throws IOException {

		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");

		pz = new String[Integer.parseInt(stn.nextToken())][Integer.parseInt(stn.nextToken())];

		for (int i = 0; i < pz.length; i++) {
			pz[i] = br.readLine().split("");
		}

		getHorizontalWord();
		getVerticalWord();
		listSort();
		
		System.out.println(wList.get(0));
	}

	// Horizontal word Extraction
	private static void getHorizontalWord() {
		ar = 0;
		ac = 1;
		overCheck = new boolean[pz[0].length];
		
		for (int i = 0; i < pz.length; i++) {
			for (int j = 0; j < pz[i].length; j++) {
				String tmp = exWord(0, i, j);
				
				if(tmp.length() < 2) continue;
				
				wList.add(tmp);
			}
			Arrays.fill(overCheck, false);
		}

		/*
		 * for(int i = 0; i < t.length; i++) { int length = t[i].length; overCheck = new
		 * boolean[length];
		 * 
		 * for(int j = 0; j < length; j++) { String tmp = exWord(t[i], 0);
		 * if(tmp.length() > 1) wList.add(tmp); } }
		 */

	}

	private static void getVerticalWord() {
		ar = 1;
		ac = 0;
		overCheck = new boolean[pz.length];
		
		for (int j = 0; j < pz[0].length; j++) {
			for (int i = 0; i < pz.length; i++) {
				String tmp = exWord(1, i, j);
				if(tmp.length() < 2) continue;
				
				wList.add(tmp);
			}
			Arrays.fill(overCheck, false);
		}
	}

	// Word Search
	private static String exWord(int stu, int row, int col) {

		if (stu == 0) {
			if (pz[row].length <= col || pz[row][col].equals("#") || overCheck[col]) return "";
			overCheck[col] = true;

			return pz[row][col] + exWord(0, row + ar, col + ac);
		} else {
			 if(pz.length <= row || pz[row][col].equals("#") || overCheck[row]) return ""; 
			 overCheck[row] = true;
			 
			 return pz[row][col] + exWord(1, row + ar, col + ac);
			 
		}
 
	}

	/* Sort alphabetically */
	private static void listSort() {
		Collections.sort(wList, new Comparator<String>() {
			@Override
			public int compare(String o1, String o2) {
				return o1.compareTo(o2);
			}
		});
	}

}
