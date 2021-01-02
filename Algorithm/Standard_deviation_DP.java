package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.StringTokenizer;

public class Standard_deviation_DP {
	static HashMap<Integer, Integer> dp_map = new HashMap<Integer, Integer>();
	static int melt;
	static int target;
	static int time_out;
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		System.out.println("1.데이터 수     2.목표치     3.제거값(초 단위)    4.시간제한");
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");
		
		int length = Integer.parseInt(stn.nextToken());
		target = Integer.parseInt(stn.nextToken());
		melt = Integer.parseInt(stn.nextToken());
		time_out = Integer.parseInt(stn.nextToken());
		ArrayList<Integer> numList = new ArrayList<Integer>();
		ArrayList<Integer> divList = new ArrayList<Integer>();
		ArrayList<Integer> stdvList = new ArrayList<Integer>();
		
		int total = 0;
		for(int i = 0; i < length; i++){
			numList.add(Integer.parseInt(br.readLine()));
			total += numList.get(i);
		}
		
		int div = total/length;
		int divTotal = 0;
		for(int j = 0; j < length; j++) {
			divList.add(numList.get(j) - div);
			divTotal += divList.get(j);
		}
		
		int stdv = divTotal/length;
		int stdvTotal = 0;
		for(int z = 0; z < length; z++) {
			int stdvTemp = divList.get(z) - stdv;
			stdvList.add((int)(Math.pow(stdvTemp, 2)));
			stdvTotal += stdvList.get(z);
		}
		
		int stadard_div = stdvTotal/(length-1);
		
		System.out.println(div);
		System.out.println((int)(Math.sqrt(stadard_div)));
		//for(int answer : stdvList) System.out.println(answer);
		
		/*
		 * for(int j = 0; j < length; j++) { flag = false; int lot_id = numList.get(j);
		 * int temp = lot_id; if(dp_map.containsKey(lot_id)) { System.out.println("DP");
		 * stdvList.add(dp_map.get(lot_id)); continue; } for(int z = 0; z < time_out;
		 * z++) {
		 * 
		 * if(min > temp) break;
		 * 
		 * if(max <= temp && temp >= min) { dp_map.put(lot_id, z); stdvList.add(z); flag
		 * = true; break; } temp -= melt; } if(!flag) stdvList.add(-1); } for(int answer
		 * : stdvList) System.out.println(answer);
		 */
	}
}





