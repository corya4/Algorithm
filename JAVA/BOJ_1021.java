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
		int l = index.length-1;
		int v = index[n];
		int[] copy_index = Arrays.copyOf(index, index.length);
		
		while(n < l) {
			if(deque.peekFirst() == v) {
				v = index[++n];
				deque.pollFirst();
				length--;
				change_index(copy_index, -1, true);
				continue;
			}
			
			if(copy_index[n] > length) {
				change_index(copy_index, 1, false);
				int temp = deque.pollLast();
				deque.addFirst(temp);
				
			}else {
				change_index(copy_index, -1, false);
				int temp = deque.pollFirst();
				deque.addLast(temp);
			}
			
			count++;
		}
		
		System.out.println(count);
	}
	
	static void change_index(int[] index, int d, boolean flag) {
		
		if(flag) {
			int[] t_index = new int[index.length-1];
			System.arraycopy(index, 1, t_index, 0, index.length);
		}
			
		for(int i = 0; i < index.length; i++) {
			index[i]+=d;
				
			if(index[i] == 0) index[i] = index.length;
			else if(index[i] < index.length) index[i] = 1; 
		}
		
		System.out.println(Arrays.toString(index));
	}
	
}







