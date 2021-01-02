
package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

class HashSort {
	
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String msg = br.readLine();
		System.out.println(Arrays.toString(hashSorter(msg)));
	}
	public static int[] hashSorter(String msg) {
		int[] answer = {};	  
		
		Map<String, Integer> map = new HashMap<String, Integer>();
		ArrayList<Integer> arr = new ArrayList<Integer>();
		String lzw = null;
		int length = 26;
		char c;
		for(int i = 1 ; i <= 26; i++) {
			c = (char)(64+i);
			map.put(String.valueOf(c),i);
		}
		for(int i = 0; i < msg.length(); i++) {
			lzw = String.valueOf(msg.charAt(i));
			for(int j = i+1; j < msg.length(); j++) {
				if(map.containsKey(lzw+String.valueOf(msg.charAt(j)))) {
					lzw+=String.valueOf(msg.charAt(j));
					i++;
				}else {
					map.put(lzw+String.valueOf(msg.charAt(j)), ++length);
					j = msg.length();
				}
			}
			arr.add(map.get(lzw));
		}
		
		answer = new int[arr.size()];
		for(int i = 0; i < arr.size(); i++) answer[i] = arr.get(i);
		return answer;
	}
}