package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.PriorityQueue;

public class Heap_1_moreHot {

	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		int[] scoville = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		int K = Integer.parseInt(br.readLine());

		System.out.println(solution(scoville, K));
		
	}
	
	static int solution(int[] scoville, int K) {
		 PriorityQueue<Integer> pie = setQueue(scoville, K);
			
			int answer = 0;
			
			while(!pie.isEmpty()) {
				if(pie.size() <= 1) {
	                
	                if(pie.size() == 1 && pie.poll() >= K) break;
	                
	              answer = -1;
	                break;
	            }
				int f = (int) pie.poll();
				int s = ((int) pie.poll() * 2);
				
				if(f >=  K) break; 
	            answer++;
	            
				int v = f + s;
	            pie.add(v);
			}
			
			return (answer == -1) ? -1 : answer;
	}

	static PriorityQueue<Integer> setQueue(int[] sArr, int K) {
		PriorityQueue<Integer> pie = new PriorityQueue<Integer>();
		for(int i = 0; i < sArr.length; i++) {
			pie.add(sArr[i]);
		}
		return pie;
	}
}






