package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Deque;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.List;

public class Sniffy_Editor {

	
	// 1. 추가 2. 삭제 3. 출력
	// 메소드 생성.
	// 좆같은 시간초과
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		String[] write = br.readLine().split("");
		Deque<String> stack = new LinkedList<String>();
		
		int i = 1;
		int count = 2;
		
		stack.add(write[0]);
		
		while(true) {
			
			if(write[i].equals(stack.getFirst())) {
				Iterator<String> itr = stack.iterator();
				int ii = i;
				boolean flag = true;
				while(itr.hasNext()) {
					if(write[ii].equals(itr.next())) {
						ii+=1;
						continue;
					}
					flag = false;
					break;
				}
				
				if(flag) {
					i = ii;
				}else {
					stack.add(write[ii-1]);
					i++;
				}
				
			}else {
				stack.add(write[i]);
				i++;
			}
			count++;
			
			if(i >= write.length) break;
		}
		System.out.println(count);
	}

}








