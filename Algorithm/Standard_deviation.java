package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.StringTokenizer;

public class Standard_deviation {
	static ArrayList<Integer> result = new ArrayList<Integer>();
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
		
		for(int i = 0; i < length; i++) numList.add(Integer.parseInt(br.readLine()));
	
		int total = (int)numList.stream().mapToInt(Integer::valueOf).average().getAsDouble();
		int dvTotal = numList.parallelStream().mapToInt(i -> (int)(Math.pow(i-total, 2))).sum() / (length-1);
		int stdv = (int)Math.sqrt((int)dvTotal);
		
		for(int j = 0; j < length; j++) {
			int lot_id = numList.get(j);
			edge(lot_id, stdv, 0);
		}
		
		for(int answer : result) System.out.println(answer);
	}
	
	static void edge(int num, int limit, int count) {
		
		if(count > time_out) {
			result.add(-1);
			return;
		}
		
		if((target + limit) > num && (target - limit) < num) {
			result.add(count);
			return;
		}
		
		edge(num-melt, limit, count+1);
		
		return;
	}

}




