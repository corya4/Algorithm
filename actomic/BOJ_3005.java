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
	
	public static void main(String[] args) throws IOException {
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");
		
		String[][] pz = new String[Integer.parseInt(stn.nextToken())][Integer.parseInt(stn.nextToken())];
		
		for(int i = 0; i < pz.length; i++) {
			pz[i] = br.readLine().split("");
		}
		
		getHorizontalWord(pz);
		getVerticalWord(pz);
		listSort();
		System.out.println(wList.get(0));
	}

	// Horizontal word Extraction
	private static void getHorizontalWord(String[][] t) {
		
		for(int i = 0; i < t.length; i++) {
			int length = t[i].length;
			overCheck = new boolean[length]; 
			
			for(int j = 0; j < length; j++) {
				String tmp = exWord(t[i], 0);
				if(tmp.length() > 1) wList.add(tmp);
			}
		}
		
	}
	
	private static void getVerticalWord(String[][] t) {
		
		for(int i = 0; i < )
	}
	
	// Word Search
	private static String exWord(String[] line, int index) {

		if(line.length <= index || line[index].equals("#") || overCheck[index]) {
			return "";
		}
		
		overCheck[index] = true;
		return line[index] + exWord(line, index+1);
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
