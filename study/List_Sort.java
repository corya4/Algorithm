package help;

import java.util.Arrays;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;

public class List_Sort {

	public static void main(String[] args) {
		List<String> targetList =
				Arrays.asList("KAL12","KOR2","JAL23","JAL23","ANA13","KOR5","JAL5","JAL1","ANA3","ANA25");
		
		Collections.sort(targetList, new Comparator<String>() {

			@Override
			public int compare(String o1, String o2) {
				char ini1 = o1.charAt(0); //인자1 첫번째 이니셜
				int num1 = Integer.parseInt(o1.substring(3, o1.length())); // 문자열뒤 숫자
				
				char ini2 = o2.charAt(0); //인자2 첫번째 이니셜
				int num2 = Integer.parseInt(o2.substring(3, o2.length())); // 문자열뒤 숫자
				
				int compare = ini1 - ini2; // 첫번째 알파벳 순서대로 뽑기 위해서
				
				if(ini1 > ini2) {
					return compare;
				}else if(ini1 < ini2){
					return compare;
				}else { // 앞에 알파벳이 같다면 뒤에 숫자로 비교
					
					if(num2 < num1) {
						return 1;
					}else {
						return -1;
					}
				}
				
			}
			
		});
		
		System.out.println(targetList);
	}

}
