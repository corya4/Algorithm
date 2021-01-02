package Contest4;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class PB {

	static int x = 0, y = 0;
	
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");
		
		int index, K;
		index = Integer.parseInt(stn.nextToken());
		K = Integer.parseInt(stn.nextToken());
		
		int[] flag = new int[index];
		int[] dArr = new int[index];
		
		for(int i = 0; i < index; i++) {
			stn = new StringTokenizer(br.readLine(), " ");
			flag[i] = Integer.parseInt(stn.nextToken());
			dArr[i] = stn.nextToken().equals("right") ? 0 : 1;
		}
		
		int current = 0;
		int m = 0;
		String direction = "right";
		
		for(int j = 0; j < flag.length; j++) {
			m = flag[j];
			int n = m - current;
			
			direction = Redirect(direction, n);
			direction = curve(direction, dArr[j]);
			
			current = m;
		}
		Redirect(direction, K - m);
		System.out.println(x + " " + y);
	}
	
	static String Redirect(String c, int n) {
		
		
		switch(c) {
		case "right":
			x += n;
			break;
		case "left":
			x -= n;
			break;
		case "up":
			y += n;
			break;
		case "down":
			y -= n;
			break;
		}
		
		return c;
	}
	
	static String curve(String c, int d) {
		
		switch(c) {
		case "right":
			if(d == 0) return "down";
			else return "up";
		case "left":
			if(d == 0) return "up";
			else return "down";
		case "up":
			if(d == 0) return "right";
			else return "left";
		case "down":
			if(d == 0) return "left";
			else return "right";
		case "":
			return c;
		}
		
		return null;
	}

}
