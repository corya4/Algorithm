
package JAVA;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.ArrayList;
import java.util.StringTokenizer;


public class BOJ_15787 {
	
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");
		int[] train = new int[Integer.parseInt(stn.nextToken())];
		int order = Integer.parseInt(stn.nextToken());
		int x = 0;
		int man = 0;
		for(int i = 0; i < order; i++) {
			stn = new StringTokenizer(br.readLine(), " ");
			while(stn.hasMoreTokens()) {
				switch(stn.nextToken()) {
				case "1" :
					x = Integer.parseInt(stn.nextToken())-1;
					man = 1<<(Integer.parseInt(stn.nextToken())-1);
					if((train[x] & man) == 0) {
						train[x] |= man;
					}
					break;
				case "2" :
					x = Integer.parseInt(stn.nextToken())-1;
					man = 1<<(Integer.parseInt(stn.nextToken())-1);
					if((train[x] & man) != 0) {
						train[x] ^= (man);
					}
					break;
				case "3" :
					x = Integer.parseInt(stn.nextToken())-1;
					train[x] = train[x]<<1;
					if(train[x] >= (1<<20)) {
						train[x] ^= (1<<20);
					}
					break;
				case "4" :
					x = Integer.parseInt(stn.nextToken())-1;
					train[x] = train[x]>>1;
					break;
				}
			}
		}
		
		ArrayList<Integer> pass = new ArrayList<Integer>();
		for(int i = 0; i < train.length; i++) {
			if(!pass.contains(train[i])) pass.add(train[i]);
		}
		bw.write(String.valueOf(pass.size()));
		bw.close();
	}

}