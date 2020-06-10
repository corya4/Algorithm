package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;

public class Cookie_Test3 {

	public static void main(String[] args) throws NumberFormatException, IOException {
		Cookie_Test3 ct3 = new Cookie_Test3();
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int k = Integer.parseInt(br.readLine());
		int[] a = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		
		if(k < a.length) return;
		
		int result = ct3.solution(k, a);
		System.out.println(result);

	}
	
	public int solution(int K, int[] A) {
		int answer = 0;
		ArrayList<Integer> obs = new ArrayList<Integer>();
		for(int i : A) obs.add(i);
		
		for(int j = 0; j < A.length; j++) {
			int remove = A[j];
			if(!obs.contains(remove)) continue;
			
				aWay(obs, remove, j);
				answer++;
		
		}
		
		return answer;
	}
	
	public void aWay(ArrayList<Integer> obs, int r, int t) {
		
		while(obs.contains(r)) {
			t = obs.indexOf(r);
			obs.remove((Object)r);
			r++;
			int index = obs.indexOf(r);
			if(index < t) break;
		}
	}
}



