package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;


//Time over
//anwer study/Binary_tree.java
class T_Node{
	int weight;
	T_Node left;
	T_Node right;
	
	T_Node(int value){
		weight = value;
	}
}

public class BOJ_13325 {
	static int index = 0;
	static int totalSum = 0;
	
	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int height = Integer.parseInt(br.readLine());
		String[] weighies = br.readLine().split(" ");
		
		T_Node route = new T_Node(0);
		for(int i = 0 ; i < height; i++) {
			setNode(route, weighies);
		}
		
		int max = getMaxValue(route);
		matchWeight(route, max, 0);
		System.out.println(totalSum);
	//	System.out.println(sumNodeWeight(route));
	}
	
	static int sumNodeWeight(T_Node route) {
		if(route == null) return 0;
		
		int sum = sumNodeWeight(route.left) + sumNodeWeight(route.right) + route.weight;
		
		return sum;
	}
	
	/*
	 * 
	 * 현 루트 가중치값에 max와 같은값이 있을때까지 +1 (while)
	 * 있을 시 loop break 후 
	 * left와  right 노드 재귀호출 <-- 재귀호출시 weight값은 가중시킨다.
	 * node가 null이면 return
	 * 
	 * 
	 */
	
	//Legacy
	//루트 가중치 맞추기
	static void matchWeight(T_Node route, int max, int sum) {
		
		if(route == null) return;
		
		while(max != getMaxValue(route)) { // 노드 높이 조정루프
			route.weight++;
		}
		totalSum += route.weight;
		matchWeight(route.left, max-route.weight, route.weight);
		matchWeight(route.right, max-route.weight, route.weight);	
	}
	
	
	//최대값 찾기
	static int getMaxValue(T_Node node) {
		
		if(node == null) {
			return 0;
		}
		
		int max = 0;
		max = Math.max(max, getMaxValue(node.left) + node.weight);
		max = Math.max(max, getMaxValue(node.right) + node.weight);
		return max;
	}
	
	//노드 연결
	static void setNode(T_Node node, String[] weighies) {
		
		if(node.left != null) {
			setNode(node.left, weighies);
			
		}
		
		if(node.right != null) {
			setNode(node.right, weighies);
		}
		
		if(node.left == null) node.left = new T_Node(Integer.parseInt(weighies[index++]));
		if(node.right == null) node.right = new T_Node(Integer.parseInt(weighies[index++]));
		
	}
}
