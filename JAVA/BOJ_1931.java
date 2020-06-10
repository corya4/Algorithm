package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.Comparator;
import java.util.StringTokenizer;

public class BOJ_1931 {
	static Integer[][] conference;
	public static void main(String[] args) throws NumberFormatException, IOException {
		
		init();
		int length = conference.length;
		
		int max = 1;
		int s = 0;
		int e = conference[0][1];
		for(int i = 1; i < length; i++) {
			if(e <= conference[i][0]) {
				max++;
				e = conference[i][1];
			}
		}
		//for(Integer[] a : conference) System.out.println(Arrays.toString(a));
		System.out.println(max);
	}
	
	static void init() throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		conference = new Integer[Integer.parseInt(br.readLine())][2];
		StringTokenizer stn;
		for(int i = 0; i < conference.length; i++) {
			stn = new StringTokenizer(br.readLine(), " " );
			while(stn.hasMoreTokens()) {
				conference[i][0] = Integer.parseInt(stn.nextToken());
				conference[i][1] = Integer.parseInt(stn.nextToken());
			}
		}
		
		Arrays.sort(conference, new Comparator<Integer[]>() {
			@Override
			public int compare(Integer[] o1, Integer[] o2) {
				
				if(o1[1] == o2[1]) return o1[0] - o2[0];
				return o1[1] - o2[1];
			}
		});
	}

}
