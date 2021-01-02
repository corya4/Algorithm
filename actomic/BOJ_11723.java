
package JAVA;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.StringTokenizer;


public class BOJ_11723 {
	
	public static void main(String[] args) throws IOException {
		StringTokenizer stn; BufferedReader br = new BufferedReader(new InputStreamReader(System.in)); BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
		int set = 0;int base = 1;int loop = Integer.valueOf(br.readLine());int num = 0; 
		while(loop>0) {
		stn = new StringTokenizer(br.readLine(), " ");
			switch(stn.nextToken()) {
			case "all" :
				set = (base<<20)-1;
				break;
			case "empty" :
				set = 0;
				break;
			case "add" :
				num = Integer.parseInt(stn.nextToken())-1;
				if((set & base<<num) == 0) {
					set|= (base<<num);
				}
				break;
			case "remove" :
				num = Integer.parseInt(stn.nextToken())-1;
				if((set & base<<num) != 0) {
					set&= ~(base<<num);
				}
				break;
			case "check" :
				num = Integer.parseInt(stn.nextToken())-1;
				if((set & base<<num) != 0) {
					bw.write("1" + '\n');
				}else {
					bw.write("0" + '\n');
				}
				break;
			case "toggle" :
				num = Integer.parseInt(stn.nextToken())-1;
				set ^= 1<<num;
				break; 
			}
			loop--;
		}
		bw.close();
	}
}