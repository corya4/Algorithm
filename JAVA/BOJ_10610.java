
package JAVA;

import java.util.Arrays;
import java.util.Scanner;

public class BOJ_10610 {
	
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String strArr = sc.nextLine();
		
		char[] chArr= new char[strArr.length()];
		int sum = 0;
		
		for(int i = 0; i < strArr.length(); i++) {
			sum += Integer.parseInt(strArr.charAt(i)+"");
			chArr[i] = (char) Integer.parseInt(strArr.charAt(i)+"");
		}
		
		if(!(strArr.contains("0")) || sum%3!=0) {
			System.out.println(-1);
		}else {
			Arrays.sort(chArr);
			char temp = 0;
			for(int i = 0; i < chArr.length/2; i++) {
				temp = chArr[i];
				chArr[i] = chArr[(chArr.length-1)-i];
				chArr[(chArr.length-1)-i] = temp;
			}
			
			for(int a : chArr) {
				System.out.print(a);
			}
		}
	}
} 