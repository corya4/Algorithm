package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;

public class KMP {

	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String org = br.readLine();
		String comp = br.readLine();
		
		ArrayList<Integer> repo = kmp(org, comp);
		
		System.out.println(repo);
		System.out.println(repo.size());
	}
	
	static int[] fail_function(String c) {
		int[] pi = new int[c.length()];
		int j = 0;
		
		for(int i = 1; i < c.length(); i++) {
			while(j > 0 && c.charAt(i) != c.charAt(j)) {
				j = pi[j-1];
			}
			
			if(c.charAt(i) == c.charAt(j)) {
				pi[i] = ++j;
			}else {
				j = pi[j];
			}
			
		}
		
		return pi;
	}

	static ArrayList<Integer> kmp(String o, String c){
		ArrayList<Integer> list = new ArrayList<Integer>();
		int m = o.length();
		int j = 0;
		
		int[] pi = fail_function(c);
		
		for(int i = 0; i < m; i++) {
			while(j > 0 && o.charAt(i) != c.charAt(j)) {
				j = pi[j-1];
			}
			
			if(o.charAt(i) == c.charAt(j)) {
				if(j == c.length()-1) {
					list.add(i - j + 1);
				}else {
					j++;
				}
			}else {
				j = pi[j];
			}
		}
		
		
		return list;
	}
}





