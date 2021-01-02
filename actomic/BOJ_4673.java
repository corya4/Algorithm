
package JAVA;

import java.util.ArrayList;
import java.util.List;


public class BOJ_4673 {
	
	public static void main(String[] args) {
		List<String> selfnum = new ArrayList<String>();
		for(int i = 1; i <= 10000; i++) {
			selfnum.add(i+"");
		}
		getSelfNum(selfnum);
	}
	
	static void getSelfNum(List<String> num) {
		int value = 1;
		int set = 0;
		
		while(set <= 10000) {
			set+=1;
			value = function(set);
			num.remove(value+"");
			}
		
		for(String result : num) {
		System.out.println(result);
		}
		
	}
	
	static int function(int v) {
		String a = String.valueOf(v);
		
		int remainder = 10;
		int y = v;
		int b = 0;
		for(int i = 0; i < a.length(); i++) {
			b += y%10;
			y = y / remainder;
		}
		
		return v+b;
		
	}
}