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
				char ini1 = o1.charAt(0); //����1 ù��° �̴ϼ�
				int num1 = Integer.parseInt(o1.substring(3, o1.length())); // ���ڿ��� ����
				
				char ini2 = o2.charAt(0); //����2 ù��° �̴ϼ�
				int num2 = Integer.parseInt(o2.substring(3, o2.length())); // ���ڿ��� ����
				
				int compare = ini1 - ini2; // ù��° ���ĺ� ������� �̱� ���ؼ�
				
				if(ini1 > ini2) {
					return compare;
				}else if(ini1 < ini2){
					return compare;
				}else { // �տ� ���ĺ��� ���ٸ� �ڿ� ���ڷ� ��
					
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
