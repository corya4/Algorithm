package IGRUS_Newbie;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class B {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int bit = Integer.toBinaryString(Integer.parseInt(br.readLine())).length();
		
		System.out.println(bit <= 1 ? 1 : bit);

	}

}
