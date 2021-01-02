package Contest4;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class PA {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int reward = Integer.parseInt(br.readLine());
		
		int receipt1, receipt2;
		
		int tax = (int)(reward * 0.22);
		receipt1 = reward - tax;
		
		int expenses = (int)(reward * 0.2);
		tax = (int)(expenses * 0.22);
		receipt2 = reward - tax;
		
		System.out.println(receipt1 + " " + receipt2);
	}

}
