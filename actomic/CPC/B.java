package CPC;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.StringTokenizer;

public class B {
	static long a, b, c;
	static long x, xx, y, yy;
	
	public static void main(String[] args) throws IOException {
		BufferedReader br = null; 
		
		/*
		 * br = new BufferedReader(new InputStreamReader(System.in)); path =
		 * Arrays.asList(br.readLine().split(" ")).
		 * stream().mapToInt(Integer::parseInt).toArray(); wArea =
		 * Arrays.asList(br.readLine().split(" ")).
		 * stream().mapToInt(Integer::parseInt).toArray();
		 */
		
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");
		a = Long.parseLong(stn.nextToken());
		b = Long.parseLong(stn.nextToken());
		c = Long.parseLong(stn.nextToken());
		
		stn = new StringTokenizer(br.readLine(), " ");
		x = Long.parseLong(stn.nextToken());
		xx = Long.parseLong(stn.nextToken());
		y = Long.parseLong(stn.nextToken());
		yy = Long.parseLong(stn.nextToken());
		
		solv();
	}
	
	private static void solv() {
		long t1, t2;
		if(a == 0) {
			t1 = -c;
			t2 = b;
			if(t2 < 0) {
				 t1	*= -1; t2 *= -1;
			}
			if(t2 * y < t1 && t1 < t2 * yy) System.out.println("Poor");
			else System.out.println("Lucky");
			return;
		}
		
		if(b == 0) {
			t1 = -c;
			t2 = a;
			if(t2 < 0) {
				t1 *= -1; t2 *= -1;
			}
			if(t2 * x < t1 && t1 < t2* xx) System.out.println("Poor");
			else System.out.println("Lucky");
			return;
		}
		
		if(checkPath(-a*x-c, y, yy, b)) return;
		if(checkPath(-a*xx-c, y, yy, b)) return;
		if(checkPath(-b*y-c, x, xx, a)) return;
		if(checkPath(-b*yy-c, x, xx, a)) return;
		
		System.out.println("Lucky");
	}
	
	private static boolean checkPath(long cx, long x, long y, long z) {
		if(z < 0) {
			cx *= -1;
			z *= -1;
		}
		
		if(z * x < cx && cx < z * y) {
			System.out.println("Poor");
			return true;
		}
		
		return false;
	}
	
}









