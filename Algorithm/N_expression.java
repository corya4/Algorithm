package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.Iterator;
import java.util.StringTokenizer;

public class N_expression {

	public static void main(String[] args) throws IOException {
		N_expression ne = new N_expression();
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");
		int N = Integer.parseInt(stn.nextToken());
		int number = Integer.parseInt(stn.nextToken());
		
		System.out.println(ne.solution(N, number));

	}

	public int solution(int N, int number) {
		if(N == number) return 1;
		ArrayList<HashSet<Integer>> dpList = new ArrayList<HashSet<Integer>>();
		ArrayList<Integer> calcuList = new ArrayList<Integer>();
		init(dpList, calcuList, N);
		
		for(int i = 1; i < 8; i++) {
			for(int ii = 0; ii < i; ii++) {
				HashSet<Integer> tempList = dpList.get(i-ii-1);
				for(int temp : dpList.get(ii)) {
					Iterator<Integer> iter = tempList.iterator();
					while(iter.hasNext()) {
						int listNum = iter.next();
						dpList.get(i).add(temp + listNum);
						dpList.get(i).add(temp - listNum);
						dpList.get(i).add(temp * listNum);
						if(listNum != 0) dpList.get(i).add(temp /listNum);
					}
					dpList.get(i).add(calcuList.get(i));
					if(dpList.get(i).contains(number)) return i+1;
				}
			}
		}
		return -1;
	}

	static void init(ArrayList<HashSet<Integer>> L1, ArrayList<Integer> L2, int N) {
		L2.add(N);
		for(int i = 0; i < 8; i++) L1.add(new HashSet<Integer>());
		for(int i = 0; i < 7; i++) L2.add(L2.get(0) * (int)Math.pow(10, i+1) + L2.get(i));
		L1.get(0).add(0);
		L1.get(0).add(N);
	}
}
