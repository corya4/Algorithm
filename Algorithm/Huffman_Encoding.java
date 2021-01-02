package study;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Comparator;
import java.util.HashMap;
import java.util.PriorityQueue;

/*
 * 압축알고리즘
 * 
 */

class CharNode{
	
	char nodeChar;
	int nodeCount;
	CharNode left, right;
}

public class Huffman_Encoding {
	private static PriorityQueue<CharNode> queue;
	private static HashMap<Character, String> map = new HashMap<Character, String>();
	private static CharNode header;
	
	public static void main(String[] args) throws IOException {
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String text = br.readLine();
		
		
		//중복 문자횟수 구함
		HashMap<Character, Integer> mTmp = new HashMap<Character, Integer>();
		for(int i = 0; i < text.length(); i++) {
			char c = text.charAt(i);
			
			if(mTmp.get(c) != null) {
				mTmp.put(c, mTmp.get(c)+1);
			}else {
				mTmp.put(c,1);
			}
			
		}
		
		
		queue = new PriorityQueue<CharNode>(new Comparator<CharNode>() {
			@Override
			public int compare(CharNode o1, CharNode o2) {
				int na = o1.nodeCount;
				int nb = o2.nodeCount;
				return na - nb;
			}
		});
		
		for(char ct : mTmp.keySet()) {
			CharNode nTmp = new CharNode();
			nTmp.nodeChar = ct;
			nTmp.nodeCount = mTmp.get(ct);
			queue.add(nTmp);
		}
	
		
		int length = mTmp.size();
		header = setHuffman(length == 1 ? length : length - 1);
		
		huffmanTree(header, "");
		
		String encoding = "";
		for(int j = 0; j < text.length(); j++) {
			encoding += map.get(text.charAt(j));
		}
		
		System.out.println("ENCODEING == " + encoding);
		System.out.println("DECODING == " + Huffman_Decoding.getDecode(header, encoding));
	}
	
	static CharNode setHuffman(int length) {
		for(int i = 0; i < length; i++) {
			CharNode ns = new CharNode();
			
			ns.left = queue.poll();
			
			if(length != 1) {
				ns.right = queue.poll();
				ns.nodeCount = ns.left.nodeCount + ns.right.nodeCount;
			}
			queue.add(ns);
		}
		return queue.poll();
	}
	
	static void huffmanTree(CharNode n, String bit) {
		
		if(n == null) return;
		
		huffmanTree(n.left, bit + "0");
		huffmanTree(n.right, bit +"1");
		
		if(n.nodeChar != '\0') {
			map.put(n.nodeChar, bit);
			System.out.println(n.nodeChar + " : " + bit);
		}
		
	}

	
}









