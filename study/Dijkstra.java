package study;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.Iterator;

class Node implements Comparator<Node>{
	ArrayList<Node> route;
	int cost;
	char identity;
	
	Node(int c, char i) {
		route = new ArrayList<Node>();
		cost = c;
		identity = i;
	}
	
	void addRoute(Node n){
		route.add(n);
	}
	
	int getSize() {
		return route.size();
	}

	char getIdentity() {
		return identity;
	}
	
	int getCost() {
		return cost;
	}

	@Override
	public int compare(Node o1, Node o2) {
		int n1 = o1.getIdentity();
		int n2 = o2.getIdentity();
		
		if(n1 == n2) {
			return 0;
		}
		
		return -1;
	}

}

public class Dijkstra {
	static int max = 10000000;
	static Node A, B, C, D, E, F;
	static ArrayList<Node> checkRoute = new ArrayList<Node>();
	
	public static void main(String[] args) {
		A = new Node(3, 'A');
		B = new Node(5, 'B');
		C = new Node(2, 'C');
		D = new Node(20, 'D');
		E = new Node(6, 'E');
		F = new Node(10, 'F');
		init();
		
		int answer = find_shortRoute(E, F);
		System.out.println(answer == max ? -1 : answer);
	}
	
	static void init() {
		A.addRoute(C);
		B.addRoute(A);
		C.addRoute(D);
		D.addRoute(B); D.addRoute(C);
		E.addRoute(B); E.addRoute(D);
	}
	
	static int find_shortRoute(Node start, Node end) {
		checkRoute.add(start);
		if(start == end) {
			return 0;
		}
		
		Iterator<Node> iter = start.route.iterator();
		int sum = max;
		
		while(iter.hasNext()) {
			Node s = iter.next();
			if(checkRoute.contains(s)) continue;
			sum = Math.min(sum, find_shortRoute(s, end) + s.getCost());
			checkRoute.remove(s);
		}
		
		return sum;
	}
}






