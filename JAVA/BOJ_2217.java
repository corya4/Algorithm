
package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;

public class BOJ_2217  {
	
	public static void main(String[] args) throws IOException {
		BufferedReader rd = new BufferedReader(new InputStreamReader(System.in));
		int[] rope = new int[Integer.parseInt(rd.readLine())];
		for(int i = 0; i < rope.length; i++) {
			rope[i] = Integer.parseInt(rd.readLine());
		}
		ArrayList<Integer> list = new ArrayList<Integer>();
		Arrays.sort(rope);
		
		for(int i = 0; i < rope.length; i++) {
			if(i == 0) {
				list.add(rope[rope.length-1]);
			}
			list.add((i+1)*rope[rope.length-(i+1)]);
		}
		System.out.println(list.stream().max((x,y)->x-y).orElse(-1));
	}
} 