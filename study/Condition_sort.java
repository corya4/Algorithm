package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class Condition_sort {

	int max = 1000000000;
	
	public static void main(String[] args) throws IOException {
		Condition_sort cs = new Condition_sort();
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int[] iArr = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		int cMax = Integer.parseInt(br.readLine());
		
		if(iArr.length > 8) return;
		
		int result = cs.solution(iArr, cMax);
		System.out.println(result);
	}

	public int solution(int[] numbers, int K) {
		int answer = 0;
		int min = max;
		
		for(int i = 0; i < numbers.length-1; i++) {
			
			if(Math.abs(numbers[i] - numbers[i+1]) <= K) continue;
			int[] arrTmp = Arrays.copyOf(numbers, numbers.length);
			min = Math.min(minSwap(numbers, arrTmp,i,K), min);
			
		}
		
		return answer = (min == max) ? -1:min;
	}
	
	public int minSwap(int[] origin, int[] arrTmp, int index, int K) {
		
		if(condition(arrTmp, K)) {
			System.out.println(Arrays.toString(arrTmp) + "  " + swapCount(origin, arrTmp));
			return swapCount(origin, arrTmp);
		}
		if(index >= arrTmp.length) return max;
		
		int min = max;
		for(int i = index; i < arrTmp.length; i ++) {
			swapArr(arrTmp,i,index);
			min = Math.min(min, minSwap(origin, arrTmp,index+1,K));
			swapArr(arrTmp,index,i);
		}

		return min;
	}
	
	//arr index swap
	public void swapArr(int[] numbers, int s, int e) {
		int temp = 0;
		temp = numbers[s];
		numbers[s] = numbers[e];
		numbers[e] = temp;
	}
	
	//condition search
	public boolean condition(int[] numbers, int K) {
		for(int i = 0; i < numbers.length-1; i++) {
			if(Math.abs(numbers[i] - numbers[i+1]) > K) return false;
		}
		return true;
	}
	
	//notMatch origin index
	public int swapCount(int[] arrTmp, int[] numbers) {
		int count = 0;
		for(int i = 0; i < numbers.length; i++) {
			if(arrTmp[i] != numbers[i]) count++;
		}
		return (count+1)/2;
	}
}


















