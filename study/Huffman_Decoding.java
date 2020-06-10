package study;

public class Huffman_Decoding {

	public static String getDecode(CharNode node, String encoding) {
		
		String decode = "";
		
		int lenght = encoding.length();
		int index = 0;
		CharNode nTmp = node;
		while(index < lenght) {
			
			if(encoding.charAt(index) == '0') {
				nTmp = nTmp.left;
			}else if(encoding.charAt(index) == '1') {
				nTmp = nTmp.right;
			}
			
			if(nTmp.left == null && nTmp.right == null) {
				decode += String.valueOf(nTmp.nodeChar);
				nTmp = node;
			}
			
			index++;
		}
		
		return decode;
	}
}
