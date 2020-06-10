package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;

public class Cookie_Test1 {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		Cookie_Test1 ct1 = new Cookie_Test1();
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String[] cookies = br.readLine().split(" ");
		int result = ct1.solution(cookies);
		System.out.println(result);
	}

	public int solution(String[] names) {
		int answer = 0;
		HashMap<Character, ArrayList<String>> init = new HashMap<Character, ArrayList<String>>();
		
		for(int i = 0; i < names.length; i++) {
			char c = names[i].charAt(0);
			if(init.containsKey(c)) {
				init.get(c).add(names[i]);
			}else {
				init.put(c, new ArrayList<String>());
				init.get(c).add(names[i]);
			}
		}
		
		Iterator<Character> iter = init.keySet().iterator();
		while(iter.hasNext()) {
			int sum = init.get(iter.next()).size();
			if(sum <= 2) continue;
			answer += splitCount(sum);
		}
		return answer;
	}

	public int splitCount(int cookies) {
		int half = cookies/2;
		return fact(half) + fact(cookies - half);
	}
	
	public int fact(int i) {
		if(i <= 1) return 0;
		if(i == 2) return 1;
		return i-1 + fact(i-1);
	}
}















