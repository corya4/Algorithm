package study;

import java.util.Comparator;
import java.util.PriorityQueue;
class Solution {
    public String solution(int[] numbers) {
        String answer = "";
		PriorityQueue<String> priority = new PriorityQueue<String>(new Comparator<String>() {
			@Override
			public int compare(String o1, String o2) {
				String str1 = String.valueOf(o1);
				String str2 = String.valueOf(o2);
				
				String temp = str1 + str2;
				String temp2 = str2 + str1;
				
				return temp2.compareTo(temp);
			}
		});
		
		for(int n : numbers) priority.add(String.valueOf(n));
		for(int i = 0; i < numbers.length; i++) {
			answer += priority.poll();
			if(answer.equals("0")) return answer = "0";
		}
		return answer;
    }
}