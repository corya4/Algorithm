
package JAVA;

import java.util.Scanner;

public class BOJ_8958 {
	
	static int value = 0;
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int count = Integer.parseInt(sc.nextLine());
		for(int i = 0; i < count; i++) {
			deduction(sc.nextLine());
			System.out.println(value);
			value=0;
		}
	}
	static void deduction(String str) {
		int plus = 1;
		for(int i = 0; i < str.length(); i++) {
			if(String.valueOf(str.charAt(i)).equals("O")) {
				value += plus;
				plus++;
			}else {
				plus=1;
			}
		}
	}
}