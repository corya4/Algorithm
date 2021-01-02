
package JAVA;

import java.util.Arrays;
import java.util.Scanner;
import java.util.StringTokenizer;

public class BOJ_1920 {
	static int[] fa;
	static int[] sa;
	static boolean flag;
	
	public static void main(String[] args) {
		setting();
		for(int i = 0; i < sa.length; i++) {
		flag = true;
		int begin = 0;
		int end = fa.length-1;
		binary(begin, end, i);
		}
	}

	static void setting() {
		Scanner sc = new Scanner(System.in);
		int fl = Integer.valueOf(sc.next());
		if(!(1<=fl&&fl<=100000)) {
			return;
		}
		sc.nextLine();
		String one = sc.nextLine();
		fa = new int[fl];
		StringTokenizer fst = new StringTokenizer(one," ");
		if(!(1 <= fst.countTokens() && fst.countTokens() <= 100000)) {
			return;
		}
		for(int i = 0; i < fa.length; i++) {
			try{
				fa[i] = Integer.valueOf(fst.nextToken());
			}catch(Exception e) {
				return;
			}
		}
		  int sl = Integer.valueOf(sc.next());
		  if(!(1<=sl&&sl<=100000)) {
				return;
			}
		  sa = new int[sl];
		  sc.nextLine();
		  String two = sc.nextLine();
		  StringTokenizer sst = new StringTokenizer(two," ");
		  if(!(1 <= sst.countTokens() && sst.countTokens() <= 100000)) {
				return;
			}
		  for(int j = 0; j < sa.length; j ++) {
			  try {
				  sa[j] = Integer.parseInt(sst.nextToken()); 
			  }catch(Exception e) {
				  return;
			  }
		  }
		 
		Arrays.sort(fa);
	}
	
	static void binary(int begin, int end, int sort) {
		if(!flag) {
			return;
		}
		if(begin > end) {
			System.out.println(0);
			flag=false;
			return;
		}
		
		int center = ((end+begin)/2);
		if(fa[center] == sa[sort]) {
			System.out.println(1);
			flag=false;
			return;
		}else if(fa[center] > sa[sort]){
			end = center-1;
			binary(begin,end,sort);
		}else {
			begin = center+1;
			binary(begin,end,sort);
		}
		return;
	}
}

