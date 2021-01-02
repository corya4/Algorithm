package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

public class Combination_hash {

	public static void main(String[] args) throws IOException {
		Combination_hash s = new Combination_hash();
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		StringBuilder sbr = new StringBuilder(br.readLine());
		sbr.deleteCharAt(0);
		sbr.deleteCharAt(sbr.length()-1);
		String[] item = sbr.toString().split("],");
		String[][] clothes = new String[item.length][2];
		for(int i = 0; i < item.length; i++) {
			clothes[i] = item[i].replaceAll("\\[", "").replaceAll("\\]","").replaceAll("\"", "").replaceAll(" ", "").split(",");
	}
		System.out.println(s.solution(clothes));
	}
	 public int solution(String[][] clothes) {
	     int answer = 1;
	     Map<String, Integer> spy = new HashMap<String, Integer>();
	     for(int i = 0; i < clothes.length; i++) {
	      	if(spy.containsKey(clothes[i][1])) {
	      		spy.computeIfPresent(clothes[i][1], (k,v) -> spy.get(k)+1);
	       	}else {
	       		spy.putIfAbsent(clothes[i][1],1);
	       	}
	    }

	     System.out.println(spy);
	     ArrayList<Integer> list = new ArrayList<Integer>();
	     
	     for(String a : spy.keySet()) list.add(spy.get(a));
	     for(int i = 1; i <= list.size(); i++) {
	    	 answer += combination(list, 0, i, 1);
	     }
	     
	       return answer-1;
	    }
	 public int combination(ArrayList<Integer> list, int s, int e, int total) {
		 	if(e == 0) return total;
		 	int sum = 0;
		 	for(int i = s; i < list.size(); i++) {
		 		sum += combination(list, i+1, e-1, total)*list.get(i);
		 	}
		 	
		 	return sum;
	 	}
	 
	}