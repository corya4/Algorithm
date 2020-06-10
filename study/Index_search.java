package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Index_search {
	
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		Index_search s = new Index_search();
		String[] participant = null;
		String v = br.readLine();
		participant = v.replace("[", "").replace("\"", "").replace("]", "").replaceAll(" ", "").split(",");
		boolean value = s.solution(participant);
		System.out.println(value);
		
	}
	public boolean solution(String[] phone_book) {
		boolean answer = true;
		for(int i = 0; i < phone_book.length; i++) {
			for(int j = 0; j < phone_book.length; j++) {
				if(i == j || phone_book[i].length() > phone_book[j].length()) continue;
				if(phone_book[j].indexOf(phone_book[i]) == 0) return false;
			}
		}
		return answer;
	}
}