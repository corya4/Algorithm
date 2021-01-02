
package JAVA;

import java.util.Scanner;


public class BOJ_1924 {
	
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int month = sc.nextInt();
		int day = sc.nextInt();
		String[][] year = new String[12][];
		
		for(int i = 1; i < year.length+1; i++) {
			
			year[i-1]=new String[31];
			
			if(i%2==0) {
				if(i==2) {
					year[i-1] = new String[28];
				}else {
					year[i-1] = new String[30];
				}
			}else {
				year[i-1] = new String[31];
			}
			
			if(i/2 >= 4) {
				if(i%2 == 0) {
					year[i-1] = new String[31];
				}else {
					year[i-1] = new String[30];
				}
			}
			
			
			
		}
		
		String[] week = {"SUN" , "MON", "TUE", "WED", "THU", "FRI", "SAT" };
		int nmg = 1;
		for(int i = 0; i < year.length; i++) {
			for(int j = 0; j < year[i].length; j++) {
				
				
				year[i][j] = week[nmg];
				
				nmg++;
				if(nmg==7) {
					nmg=0;
				}
				
			}
		
		}
		System.out.println(year[month-1][day-1]);
		
	}
}