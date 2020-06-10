
package JAVA;

import java.util.Scanner;
import java.util.stream.Stream;

public class BOJ_4344 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		double[] score_arr = new double[sc.nextInt()];
		sc.nextLine();
		for(int j = 0; j < score_arr.length; j++) {
			int[] students = Stream.of(sc.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
			int sum = 0;
			for(int i = 1; i <= students[0]; i++) {
				sum+=students[i];
			}
			score_arr[j] = print(students, sum/students[0]);
		}
		for(double score : score_arr) {
			System.out.printf("%.3f%c%n",score,37);
		}
	}
	static double print(int[] students, int average) {
		int under = 0;
		for(int i = 1; i <= students[0]; i++) {
			if(students[i] > average) {
				under++;
			}
		}
		return (double)under/students[0]*100;
	}
}