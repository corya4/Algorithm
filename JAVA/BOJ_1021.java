import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;
import java.util.Arrays;
import java.util.Deque;

public class BOJ_1021 {

	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		Deque<Integer> deque = new ArrayDeque<Integer>();
		int[] ini = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		
		for(int i = 0; i < ini[0]; i++) deque.add(i+1);
		int[] index = new int[ini[1]];
		index = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();

		solv(deque, index, ini[0]);
		
	}

	static void solv(Deque<Integer> deque, int[] index, int length) {
		
		int count = 0;
		int n = 0;
		int l = index.length;
		int v = index[n];
		int[] copy_index = index.clone();
		
		while(n < l) {
			
			if(deque.peekFirst() == v) {
				deque.pollFirst();
				change_index(copy_index, n, -1, length);
				length--;
				n++;
				if(n < index.length) v = index[n];
				continue;
				
			}
			
			if(copy_index[n] > half_length(length)) {
				change_index(copy_index, n, 1, length);
				int temp = deque.pollLast();
				deque.addFirst(temp);
				
			}else {
				change_index(copy_index, n, -1, length);
				int temp = deque.pollFirst();
				deque.addLast(temp);
			}
			
			count++;
		}
		System.out.println(count);
	}
	
	static void change_index(int[] index, int num, int d, int length) {
		
		for(int i = num; i < index.length; i++) {
			index[i] = index[i] + d;
				
			if(index[i] == 0) index[i] = length;
			else if(index[i] > length) index[i] = 1; 
			
		}
	}
	
	static int half_length(int length) {
		
		return length%2 == 0 ? length/2 : (length/2) +1 ;
	}
}










